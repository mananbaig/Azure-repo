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
    internal partial class VirtualNetworkGatewayNatRulesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of VirtualNetworkGatewayNatRulesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public VirtualNetworkGatewayNatRulesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworkGateways/", false);
            uri.AppendPath(virtualNetworkGatewayName, true);
            uri.AppendPath("/natRules/", false);
            uri.AppendPath(natRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves the details of a nat rule. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<VirtualNetworkGatewayNatRuleData>> GetAsync(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualNetworkGatewayName, natRuleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualNetworkGatewayNatRuleData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = VirtualNetworkGatewayNatRuleData.DeserializeVirtualNetworkGatewayNatRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualNetworkGatewayNatRuleData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves the details of a nat rule. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<VirtualNetworkGatewayNatRuleData> Get(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, virtualNetworkGatewayName, natRuleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        VirtualNetworkGatewayNatRuleData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = VirtualNetworkGatewayNatRuleData.DeserializeVirtualNetworkGatewayNatRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((VirtualNetworkGatewayNatRuleData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, VirtualNetworkGatewayNatRuleData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworkGateways/", false);
            uri.AppendPath(virtualNetworkGatewayName, true);
            uri.AppendPath("/natRules/", false);
            uri.AppendPath(natRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn't exist else updates the existing nat rules. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="data"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/>, <paramref name="natRuleName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, VirtualNetworkGatewayNatRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, virtualNetworkGatewayName, natRuleName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn't exist else updates the existing nat rules. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="data"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/>, <paramref name="natRuleName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, VirtualNetworkGatewayNatRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, virtualNetworkGatewayName, natRuleName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworkGateways/", false);
            uri.AppendPath(virtualNetworkGatewayName, true);
            uri.AppendPath("/natRules/", false);
            uri.AppendPath(natRuleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a nat rule. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualNetworkGatewayName, natRuleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes a nat rule. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the Virtual Network Gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="virtualNetworkGatewayName"/> or <paramref name="natRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, string natRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            Argument.AssertNotNullOrEmpty(natRuleName, nameof(natRuleName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, virtualNetworkGatewayName, natRuleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVirtualNetworkGatewayRequest(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/virtualNetworkGateways/", false);
            uri.AppendPath(virtualNetworkGatewayName, true);
            uri.AppendPath("/natRules", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the virtual network gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListVirtualNetworkGatewayNatRulesResult>> ListByVirtualNetworkGatewayAsync(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var message = CreateListByVirtualNetworkGatewayRequest(subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualNetworkGatewayNatRulesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualNetworkGatewayNatRulesResult.DeserializeListVirtualNetworkGatewayNatRulesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the virtual network gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListVirtualNetworkGatewayNatRulesResult> ListByVirtualNetworkGateway(string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var message = CreateListByVirtualNetworkGatewayRequest(subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualNetworkGatewayNatRulesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualNetworkGatewayNatRulesResult.DeserializeListVirtualNetworkGatewayNatRulesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByVirtualNetworkGatewayNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the virtual network gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListVirtualNetworkGatewayNatRulesResult>> ListByVirtualNetworkGatewayNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var message = CreateListByVirtualNetworkGatewayNextPageRequest(nextLink, subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualNetworkGatewayNatRulesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListVirtualNetworkGatewayNatRulesResult.DeserializeListVirtualNetworkGatewayNatRulesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The resource group name of the virtual network gateway. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListVirtualNetworkGatewayNatRulesResult> ListByVirtualNetworkGatewayNextPage(string nextLink, string subscriptionId, string resourceGroupName, string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var message = CreateListByVirtualNetworkGatewayNextPageRequest(nextLink, subscriptionId, resourceGroupName, virtualNetworkGatewayName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListVirtualNetworkGatewayNatRulesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListVirtualNetworkGatewayNatRulesResult.DeserializeListVirtualNetworkGatewayNatRulesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
