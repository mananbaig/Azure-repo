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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class SecurityRulesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of SecurityRulesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public SecurityRulesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkSecurityGroups/", false);
            uri.AppendPath(networkSecurityGroupName, true);
            uri.AppendPath("/securityRules/", false);
            uri.AppendPath(securityRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes the specified network security rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkSecurityGroupName"/>, or <paramref name="securityRuleName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, networkSecurityGroupName, securityRuleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified network security rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkSecurityGroupName"/>, or <paramref name="securityRuleName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, networkSecurityGroupName, securityRuleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string networkSecurityGroupName, string securityRuleName)
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
            uri.AppendPath("/providers/Microsoft.Network/networkSecurityGroups/", false);
            uri.AppendPath(networkSecurityGroupName, true);
            uri.AppendPath("/securityRules/", false);
            uri.AppendPath(securityRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get the specified network security rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkSecurityGroupName"/>, or <paramref name="securityRuleName"/> is null. </exception>
        public async Task<Response<SecurityRuleData>> GetAsync(string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var message = CreateGetRequest(resourceGroupName, networkSecurityGroupName, securityRuleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityRuleData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityRuleData.DeserializeSecurityRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityRuleData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get the specified network security rule. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkSecurityGroupName"/>, or <paramref name="securityRuleName"/> is null. </exception>
        public Response<SecurityRuleData> Get(string resourceGroupName, string networkSecurityGroupName, string securityRuleName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }

            using var message = CreateGetRequest(resourceGroupName, networkSecurityGroupName, securityRuleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityRuleData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityRuleData.DeserializeSecurityRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SecurityRuleData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRuleData securityRuleParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/networkSecurityGroups/", false);
            uri.AppendPath(networkSecurityGroupName, true);
            uri.AppendPath("/securityRules/", false);
            uri.AppendPath(securityRuleName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(securityRuleParameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a security rule in the specified network security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="securityRuleParameters"> Parameters supplied to the create or update network security rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkSecurityGroupName"/>, <paramref name="securityRuleName"/>, or <paramref name="securityRuleParameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRuleData securityRuleParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }
            if (securityRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(securityRuleParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a security rule in the specified network security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="securityRuleName"> The name of the security rule. </param>
        /// <param name="securityRuleParameters"> Parameters supplied to the create or update network security rule operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="networkSecurityGroupName"/>, <paramref name="securityRuleName"/>, or <paramref name="securityRuleParameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string networkSecurityGroupName, string securityRuleName, SecurityRuleData securityRuleParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }
            if (securityRuleName == null)
            {
                throw new ArgumentNullException(nameof(securityRuleName));
            }
            if (securityRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(securityRuleParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, networkSecurityGroupName, securityRuleName, securityRuleParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllRequest(string resourceGroupName, string networkSecurityGroupName)
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
            uri.AppendPath("/providers/Microsoft.Network/networkSecurityGroups/", false);
            uri.AppendPath(networkSecurityGroupName, true);
            uri.AppendPath("/securityRules", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all security rules in a network security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="networkSecurityGroupName"/> is null. </exception>
        public async Task<Response<SecurityRuleListResult>> GetAllAsync(string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, networkSecurityGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityRuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityRuleListResult.DeserializeSecurityRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all security rules in a network security group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="networkSecurityGroupName"/> is null. </exception>
        public Response<SecurityRuleListResult> GetAll(string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, networkSecurityGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityRuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityRuleListResult.DeserializeSecurityRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink, string resourceGroupName, string networkSecurityGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets all security rules in a network security group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="networkSecurityGroupName"/> is null. </exception>
        public async Task<Response<SecurityRuleListResult>> GetAllNextPageAsync(string nextLink, string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, networkSecurityGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityRuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SecurityRuleListResult.DeserializeSecurityRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all security rules in a network security group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="networkSecurityGroupName"> The name of the network security group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="networkSecurityGroupName"/> is null. </exception>
        public Response<SecurityRuleListResult> GetAllNextPage(string nextLink, string resourceGroupName, string networkSecurityGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (networkSecurityGroupName == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroupName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, networkSecurityGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SecurityRuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SecurityRuleListResult.DeserializeSecurityRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
