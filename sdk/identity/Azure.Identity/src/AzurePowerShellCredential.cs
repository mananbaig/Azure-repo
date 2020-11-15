﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Identity
{
    /// <summary>
    /// Enables authentication to Azure Active Directory using Azure PowerShell to obtain an access token.
    /// </summary>
    public class AzurePowerShellCredential: TokenCredential
    {
        private readonly CredentialPipeline _pipeline;
        private readonly IProcessService _processService;
        private const int PowerShellProcessTimeoutMs = 10000;

        private static readonly string DefaultWorkingDirWindows = Environment.GetFolderPath(Environment.SpecialFolder.System);
        //private const string DefaultPathNonWindows = "/usr/bin:/usr/local/bin";
        private const string DefaultWorkingDirNonWindows = "/bin/";
        private static readonly string DefaultWorkingDir = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? DefaultWorkingDirWindows : DefaultWorkingDirNonWindows;


        /// <summary>
        /// Create an instance of AzurePowerShellCredential class.
        /// </summary>
        public AzurePowerShellCredential()
            : this(CredentialPipeline.GetInstance(null), default)
        { }

        internal AzurePowerShellCredential(CredentialPipeline pipeline, IProcessService processService)
        {
            _pipeline = pipeline;
            _processService = processService ?? ProcessService.Default;
        }

        /// <summary>
        /// Obtains a access token from Azure PowerShell, using the access token to authenticate. This method id called by Azure SDK clients.
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override AccessToken GetToken(TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            return GetTokenImplAsync(false, requestContext, cancellationToken).EnsureCompleted();
        }

        /// <summary>
        /// Obtains a access token from Azure PowerShell, using the access token to authenticate. This method id called by Azure SDK clients.
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async ValueTask<AccessToken> GetTokenAsync(TokenRequestContext requestContext, CancellationToken cancellationToken = default)
        {
            return await GetTokenImplAsync(true, requestContext, cancellationToken).ConfigureAwait(false);
        }

        private async ValueTask<AccessToken> GetTokenImplAsync(bool async, TokenRequestContext requestContext, CancellationToken cancellationToken)
        {
            using CredentialDiagnosticScope scope = _pipeline.StartGetTokenScope("AzurePowerShellCredential.GetToken", requestContext);

            try
            {
                AccessToken token = await RequestAzurePowerShellAccessTokenAsync(async, requestContext.Scopes, cancellationToken).ConfigureAwait(false);
                return scope.Succeeded(token);
            }
            catch (Exception e)
            {
                throw scope.FailWrapAndThrow(e);
            }
        }

        private async ValueTask<AccessToken> RequestAzurePowerShellAccessTokenAsync(bool async, string[] scopes, CancellationToken cancellationToken)
        {
            string resource = ScopeUtilities.ScopesToResource(scopes);

            ScopeUtilities.ValidateScope(resource);

            GetFileNameAndArguments(resource, out string fileName, out string argument);
            ProcessStartInfo processStartInfo = GetAzurePowerShellProcessStartInfo(fileName, argument);
            var processRunner = new ProcessRunner(_processService.Create(processStartInfo), TimeSpan.FromMilliseconds(PowerShellProcessTimeoutMs), cancellationToken);

            string output = string.Empty;
            try
            {
                output = async ? await processRunner.RunAsync().ConfigureAwait(false) : processRunner.Run();
            }
            catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested)
            {
                throw new AuthenticationFailedException("AzureCliTimeoutError");
            }
            catch (InvalidOperationException exception)
            {

                throw new AuthenticationFailedException($"{exception.Message}");

                // bool isWinError = exception.Message.StartsWith(WinAzureCLIError, StringComparison.CurrentCultureIgnoreCase);

                // bool isOtherOsError = AzNotFoundPattern.IsMatch(exception.Message);

                //   if (isWinError || isOtherOsError)
                //     {
                //        throw new CredentialUnavailableException(AzureCLINotInstalled);
                //    }

               // bool isLoginError = exception.Message.IndexOf("az login", StringComparison.OrdinalIgnoreCase) != -1 || exception.Message.IndexOf("az account set", StringComparison.OrdinalIgnoreCase) != -1;


         //       throw new AuthenticationFailedException($"{AzureCliFailedError} {exception.Message}");
            }

            return DeserializeOutput(output);
        }

        private ProcessStartInfo GetAzurePowerShellProcessStartInfo(string fileName, string argument) =>
            new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = argument,
                UseShellExecute = false,
                ErrorDialog = false,
                CreateNoWindow = true,
                WorkingDirectory = DefaultWorkingDir
               // Environment = { { "PATH", _path } }
            };

        private static void GetFileNameAndArguments(string resource, out string fileName, out string argument)
        {

            string command = $"powershell -c \"$skip = $false; $c = Get-AzContext; if (! $c) {{$skip = $true; Write-Error 'ERROR!'}} ; if (! $skip) {{$token = [Microsoft.Azure.Commands.Common.Authentication.AzureSession]::Instance.AuthenticationFactory.Authenticate($c.Account, $c.Environment, $c.Tenant.Id, $null, $null, $null, '{resource}'); return $token.AccessToken}}\"";

            //string command = $"az account get-access-token --output json --resource {resource}";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "cmd.exe");
                argument = $"/c \"{command}\"";
            }
            else
            {
                fileName = "/bin/sh";
                argument = $"-c \"{command}\"";
            }
        }


        private static AccessToken DeserializeOutput(string output)
        {
            //TODO: Create the right token
            return new AccessToken(output, DateTimeOffset.MaxValue);
        }

    }
}
