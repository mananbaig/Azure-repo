﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;


namespace Azure.Identity
{
    /// <summary>
    /// Enables authentication to Azure Active Directory using data from Visual Studio
    /// </summary>
    public class VisualStudioCredential : TokenCredential
    {
        private const string TokenProviderFilePath = @".IdentityService\AzureServiceAuth\tokenprovider.json";
        private const string ResourceArgumentName = "--resource";
        private const string TenantArgumentName = "--tenant";

        private readonly CredentialPipeline _pipeline;
        private readonly string _tenantId;

        /// <inheritdoc />
        public VisualStudioCredential() : this(default, default) {}

        /// <inheritdoc />
        public VisualStudioCredential(string tenantId, TokenCredentialOptions options)
        {
            _tenantId = tenantId;
            _pipeline = CredentialPipeline.GetInstance(options);
        }

        /// <inheritdoc />
        public override async ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken)
            => await GetTokenImplAsync(requestContext, true, cancellationToken).ConfigureAwait(false);

        /// <inheritdoc />
        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken)
            => GetTokenImplAsync(requestContext, false, cancellationToken).EnsureCompleted();

        private async ValueTask<AccessToken> GetTokenImplAsync(TokenRequestContext requestContext, bool async, CancellationToken cancellationToken)
        {
            using CredentialDiagnosticScope scope = _pipeline.StartGetTokenScope("VisualStudioCredential.GetToken", requestContext);

            try
            {
                var tokenProviderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), TokenProviderFilePath);
                var tokenProviders = GetTokenProviders(tokenProviderPath);

                var resource = ScopeUtilities.ScopesToResource(requestContext.Scopes);
                var processStartInfos = GetProcessStartInfos(tokenProviders, resource);

                if (processStartInfos.Count == 0)
                {
                    throw new CredentialUnavailableException($"No installed instance of Visual Studio was found");
                }

                return await RunProcessesAsync(processStartInfos, async, cancellationToken).ConfigureAwait(false);
            }
            catch (OperationCanceledException e)
            {
                scope.Failed(e);
                throw;
            }
            catch (CredentialUnavailableException e)
            {
                scope.Failed(e);
                throw;
            }
            catch (Exception e)
            {
                throw scope.FailAndWrap(e);
            }
        }

        private static async Task<AccessToken> RunProcessesAsync(List<ProcessStartInfo> processStartInfos, bool async, CancellationToken cancellationToken)
        {
            var exceptions = new List<Exception>();
            foreach (ProcessStartInfo processStartInfo in processStartInfos)
            {
                try
                {
                    string output = async
                        ? await ProcessService.RunProcessAsync(processStartInfo, TimeSpan.FromSeconds(30), cancellationToken).ConfigureAwait(false)
                        : ProcessService.RunProcess(processStartInfo, TimeSpan.FromSeconds(30), cancellationToken);

                    JsonElement root = JsonDocument.Parse(output).RootElement;
                    string accessToken = root.GetProperty("access_token").GetString();
                    DateTimeOffset expiresOn = root.GetProperty("expires_on").GetDateTimeOffset();
                    return new AccessToken(accessToken, expiresOn);
                }
                catch (Exception exception)
                {
                    exceptions.Add(exception);
                }
            }

            switch (exceptions.Count) {
                case 0:
                    throw new InvalidOperationException();
                case 1:
                    ExceptionDispatchInfo.Capture(exceptions[0]).Throw();
                    return default;
                default:
                    throw new AggregateException(exceptions);
            }
        }

        private List<ProcessStartInfo> GetProcessStartInfos(VisualStudioTokenProvider[] visualStudioTokenProviders, string resource)
        {
            List<ProcessStartInfo> processStartInfos = new List<ProcessStartInfo>();
            StringBuilder arguments = new StringBuilder();

            foreach (VisualStudioTokenProvider tokenProvider in visualStudioTokenProviders)
            {
                // If file does not exist, the version of Visual Studio that set the token provider may be uninstalled.
                if (!File.Exists(tokenProvider.Path))
                {
                    continue;
                }

                arguments.Clear();
                arguments.Append(ResourceArgumentName).Append(' ').Append(resource);

                if (_tenantId != default)
                {
                    arguments.Append(' ').Append(TenantArgumentName).Append(' ').Append(_tenantId);
                }

                // Add the arguments set in the token provider file.
                if (tokenProvider.Arguments?.Length > 0)
                {
                    foreach (var argument in tokenProvider.Arguments)
                    {
                        arguments.Append(' ').Append(argument);
                    }
                }

                var startInfo = new ProcessStartInfo
                {
                    FileName = tokenProvider.Path,
                    Arguments = arguments.ToString(),
                    UseShellExecute = false,
                    ErrorDialog = false,
                    CreateNoWindow = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                };

                processStartInfos.Add(startInfo);
            }

            return processStartInfos;
        }

        private static VisualStudioTokenProvider[] GetTokenProviders(string tokenProviderPath)
        {
            var content = GetTokenProviderContent(tokenProviderPath);

            JsonElement providersElement = JsonDocument.Parse(content).RootElement.GetProperty("TokenProviders");

            var providers = new VisualStudioTokenProvider[providersElement.GetArrayLength()];
            for (int i = 0; i < providers.Length; i++)
            {
                JsonElement providerElement = providersElement[i];

                var path = GetStringPropertyValue(providerElement, "Path");
                var arguments = GetStringArrayPropertyValue(providerElement, "Arguments");
                var preference = GetInt32PropertyValue(providerElement, "Preference");

                providers[i] = new VisualStudioTokenProvider(path, arguments, preference);
            }

            Array.Sort(providers);
            return providers;
        }

        private static string GetTokenProviderContent(string tokenProviderPath)
        {
            try
            {
                return File.ReadAllText(tokenProviderPath);
            }
            catch (FileNotFoundException exception)
            {
                throw new CredentialUnavailableException($"Visual Studio Token provider file not found at {tokenProviderPath}", exception);
            }
        }

        private static string GetStringPropertyValue(JsonElement element, string name) => element.GetProperty(name).GetString();

        private static int GetInt32PropertyValue(JsonElement element, string name) => element.GetProperty(name).GetInt32();

        private static string[] GetStringArrayPropertyValue(JsonElement element, string name)
        {
            JsonElement arrayElement = element.GetProperty(name);
            var array = new string[arrayElement.GetArrayLength()];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arrayElement[i].GetString();
            }

            return array;
        }

        private struct VisualStudioTokenProvider : IComparable<VisualStudioTokenProvider>
        {
            private readonly int _preference;

            public string Path { get; }
            public string[] Arguments { get; }

            public VisualStudioTokenProvider(string path, string[] arguments, int preference)
            {
                Path = path;
                Arguments = arguments;
                _preference = preference;
            }

            public int CompareTo(VisualStudioTokenProvider other) => _preference.CompareTo(other._preference);
        }
    }
}
