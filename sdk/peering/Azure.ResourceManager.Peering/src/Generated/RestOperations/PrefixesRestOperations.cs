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
using Azure.ResourceManager.Peering.Models;

namespace Azure.ResourceManager.Peering
{
    internal partial class PrefixesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrefixesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PrefixesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-10-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName, string expand)
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
            uri.AppendPath("/providers/Microsoft.Peering/peeringServices/", false);
            uri.AppendPath(peeringServiceName, true);
            uri.AppendPath("/prefixes/", false);
            uri.AppendPath(prefixName, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an existing prefix with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PeeringServicePrefixData>> GetAsync(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, peeringServiceName, prefixName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringServicePrefixData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PeeringServicePrefixData.DeserializePeeringServicePrefixData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PeeringServicePrefixData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an existing prefix with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PeeringServicePrefixData> Get(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, peeringServiceName, prefixName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringServicePrefixData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PeeringServicePrefixData.DeserializePeeringServicePrefixData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PeeringServicePrefixData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName, PeeringServicePrefixData data)
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
            uri.AppendPath("/providers/Microsoft.Peering/peeringServices/", false);
            uri.AppendPath(peeringServiceName, true);
            uri.AppendPath("/prefixes/", false);
            uri.AppendPath(prefixName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = data;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a new prefix with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="data"> The properties needed to create a prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/>, <paramref name="prefixName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PeeringServicePrefixData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName, PeeringServicePrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, peeringServiceName, prefixName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        PeeringServicePrefixData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PeeringServicePrefixData.DeserializePeeringServicePrefixData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new prefix with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="data"> The properties needed to create a prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/>, <paramref name="prefixName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PeeringServicePrefixData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName, PeeringServicePrefixData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, peeringServiceName, prefixName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        PeeringServicePrefixData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PeeringServicePrefixData.DeserializePeeringServicePrefixData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName)
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
            uri.AppendPath("/providers/Microsoft.Peering/peeringServices/", false);
            uri.AppendPath(peeringServiceName, true);
            uri.AppendPath("/prefixes/", false);
            uri.AppendPath(prefixName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an existing prefix with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, peeringServiceName, prefixName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an existing prefix with the specified name under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="prefixName"> The name of the prefix. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="peeringServiceName"/> or <paramref name="prefixName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string peeringServiceName, string prefixName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));
            Argument.AssertNotNullOrEmpty(prefixName, nameof(prefixName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, peeringServiceName, prefixName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPeeringServiceRequest(string subscriptionId, string resourceGroupName, string peeringServiceName, string expand)
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
            uri.AppendPath("/providers/Microsoft.Peering/peeringServices/", false);
            uri.AppendPath(peeringServiceName, true);
            uri.AppendPath("/prefixes", false);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all prefixes under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PeeringServicePrefixListResult>> ListByPeeringServiceAsync(string subscriptionId, string resourceGroupName, string peeringServiceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var message = CreateListByPeeringServiceRequest(subscriptionId, resourceGroupName, peeringServiceName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringServicePrefixListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PeeringServicePrefixListResult.DeserializePeeringServicePrefixListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all prefixes under the given subscription, resource group and peering service. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PeeringServicePrefixListResult> ListByPeeringService(string subscriptionId, string resourceGroupName, string peeringServiceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var message = CreateListByPeeringServiceRequest(subscriptionId, resourceGroupName, peeringServiceName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringServicePrefixListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PeeringServicePrefixListResult.DeserializePeeringServicePrefixListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByPeeringServiceNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string peeringServiceName, string expand)
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

        /// <summary> Lists all prefixes under the given subscription, resource group and peering service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<PeeringServicePrefixListResult>> ListByPeeringServiceNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string peeringServiceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var message = CreateListByPeeringServiceNextPageRequest(nextLink, subscriptionId, resourceGroupName, peeringServiceName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringServicePrefixListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PeeringServicePrefixListResult.DeserializePeeringServicePrefixListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all prefixes under the given subscription, resource group and peering service. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="peeringServiceName"> The name of the peering service. </param>
        /// <param name="expand"> The properties to be expanded. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="peeringServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<PeeringServicePrefixListResult> ListByPeeringServiceNextPage(string nextLink, string subscriptionId, string resourceGroupName, string peeringServiceName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(peeringServiceName, nameof(peeringServiceName));

            using var message = CreateListByPeeringServiceNextPageRequest(nextLink, subscriptionId, resourceGroupName, peeringServiceName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PeeringServicePrefixListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PeeringServicePrefixListResult.DeserializePeeringServicePrefixListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
