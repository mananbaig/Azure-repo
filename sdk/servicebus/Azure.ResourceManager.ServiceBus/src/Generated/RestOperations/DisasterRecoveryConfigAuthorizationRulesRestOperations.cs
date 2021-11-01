// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    internal partial class DisasterRecoveryConfigAuthorizationRulesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of DisasterRecoveryConfigAuthorizationRulesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> Subscription credentials that uniquely identify a Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public DisasterRecoveryConfigAuthorizationRulesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-06-01-preview")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateGetAllRequest(string resourceGroupName, string namespaceName, string @alias)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ServiceBus/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/disasterRecoveryConfigs/", false);
            uri.AppendPath(@alias, true);
            uri.AppendPath("/authorizationRules", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the authorization rules for a namespace. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, or <paramref name="alias"/> is null. </exception>
        public async Task<Response<SBAuthorizationRuleListResult>> GetAllAsync(string resourceGroupName, string namespaceName, string @alias, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var message = CreateGetAllRequest(resourceGroupName, namespaceName, @alias);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SBAuthorizationRuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SBAuthorizationRuleListResult.DeserializeSBAuthorizationRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the authorization rules for a namespace. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, or <paramref name="alias"/> is null. </exception>
        public Response<SBAuthorizationRuleListResult> GetAll(string resourceGroupName, string namespaceName, string @alias, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var message = CreateGetAllRequest(resourceGroupName, namespaceName, @alias);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SBAuthorizationRuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SBAuthorizationRuleListResult.DeserializeSBAuthorizationRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string namespaceName, string @alias, string authorizationRuleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ServiceBus/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/disasterRecoveryConfigs/", false);
            uri.AppendPath(@alias, true);
            uri.AppendPath("/authorizationRules/", false);
            uri.AppendPath(authorizationRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets an authorization rule for a namespace by rule name. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="alias"/>, or <paramref name="authorizationRuleName"/> is null. </exception>
        public async Task<Response<SBAuthorizationRuleData>> GetAsync(string resourceGroupName, string namespaceName, string @alias, string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var message = CreateGetRequest(resourceGroupName, namespaceName, @alias, authorizationRuleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SBAuthorizationRuleData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SBAuthorizationRuleData.DeserializeSBAuthorizationRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SBAuthorizationRuleData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets an authorization rule for a namespace by rule name. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="alias"/>, or <paramref name="authorizationRuleName"/> is null. </exception>
        public Response<SBAuthorizationRuleData> Get(string resourceGroupName, string namespaceName, string @alias, string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var message = CreateGetRequest(resourceGroupName, namespaceName, @alias, authorizationRuleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SBAuthorizationRuleData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SBAuthorizationRuleData.DeserializeSBAuthorizationRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SBAuthorizationRuleData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetKeysRequest(string resourceGroupName, string namespaceName, string @alias, string authorizationRuleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.ServiceBus/namespaces/", false);
            uri.AppendPath(namespaceName, true);
            uri.AppendPath("/disasterRecoveryConfigs/", false);
            uri.AppendPath(@alias, true);
            uri.AppendPath("/authorizationRules/", false);
            uri.AppendPath(authorizationRuleName, true);
            uri.AppendPath("/listKeys", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the primary and secondary connection strings for the namespace. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="alias"/>, or <paramref name="authorizationRuleName"/> is null. </exception>
        public async Task<Response<AccessKeys>> GetKeysAsync(string resourceGroupName, string namespaceName, string @alias, string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var message = CreateGetKeysRequest(resourceGroupName, namespaceName, @alias, authorizationRuleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AccessKeys value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AccessKeys.DeserializeAccessKeys(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the primary and secondary connection strings for the namespace. </summary>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, <paramref name="alias"/>, or <paramref name="authorizationRuleName"/> is null. </exception>
        public Response<AccessKeys> GetKeys(string resourceGroupName, string namespaceName, string @alias, string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var message = CreateGetKeysRequest(resourceGroupName, namespaceName, @alias, authorizationRuleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AccessKeys value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AccessKeys.DeserializeAccessKeys(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink, string resourceGroupName, string namespaceName, string @alias)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the authorization rules for a namespace. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, or <paramref name="alias"/> is null. </exception>
        public async Task<Response<SBAuthorizationRuleListResult>> GetAllNextPageAsync(string nextLink, string resourceGroupName, string namespaceName, string @alias, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, namespaceName, @alias);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SBAuthorizationRuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SBAuthorizationRuleListResult.DeserializeSBAuthorizationRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the authorization rules for a namespace. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="alias"> The Disaster Recovery configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, <paramref name="namespaceName"/>, or <paramref name="alias"/> is null. </exception>
        public Response<SBAuthorizationRuleListResult> GetAllNextPage(string nextLink, string resourceGroupName, string namespaceName, string @alias, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (namespaceName == null)
            {
                throw new ArgumentNullException(nameof(namespaceName));
            }
            if (@alias == null)
            {
                throw new ArgumentNullException(nameof(@alias));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, namespaceName, @alias);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SBAuthorizationRuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SBAuthorizationRuleListResult.DeserializeSBAuthorizationRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
