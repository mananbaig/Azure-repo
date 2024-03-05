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
using Azure.ResourceManager.Batch.Models;

namespace Azure.ResourceManager.Batch
{
    internal partial class PrivateLinkResourceRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrivateLinkResourceRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PrivateLinkResourceRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-02-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByBatchAccountRequest(string subscriptionId, string resourceGroupName, string accountName, int? maxresults)
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
            uri.AppendPath("/providers/Microsoft.Batch/batchAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/privateLinkResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (maxresults != null)
            {
                uri.AppendQuery("maxresults", maxresults.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all of the private link resources in the specified account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListPrivateLinkResourcesResult>> ListByBatchAccountAsync(string subscriptionId, string resourceGroupName, string accountName, int? maxresults = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var message = CreateListByBatchAccountRequest(subscriptionId, resourceGroupName, accountName, maxresults);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListPrivateLinkResourcesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListPrivateLinkResourcesResult.DeserializeListPrivateLinkResourcesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the private link resources in the specified account. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListPrivateLinkResourcesResult> ListByBatchAccount(string subscriptionId, string resourceGroupName, string accountName, int? maxresults = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var message = CreateListByBatchAccountRequest(subscriptionId, resourceGroupName, accountName, maxresults);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListPrivateLinkResourcesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListPrivateLinkResourcesResult.DeserializeListPrivateLinkResourcesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string accountName, string privateLinkResourceName)
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
            uri.AppendPath("/providers/Microsoft.Batch/batchAccounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/privateLinkResources/", false);
            uri.AppendPath(privateLinkResourceName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets information about the specified private link resource. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="privateLinkResourceName"> The private link resource name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BatchPrivateLinkResourceData>> GetAsync(string subscriptionId, string resourceGroupName, string accountName, string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }
            if (privateLinkResourceName == null)
            {
                throw new ArgumentNullException(nameof(privateLinkResourceName));
            }
            if (privateLinkResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateLinkResourceName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, privateLinkResourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BatchPrivateLinkResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BatchPrivateLinkResourceData.DeserializeBatchPrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BatchPrivateLinkResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets information about the specified private link resource. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="privateLinkResourceName"> The private link resource name. This must be unique within the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateLinkResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="privateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BatchPrivateLinkResourceData> Get(string subscriptionId, string resourceGroupName, string accountName, string privateLinkResourceName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }
            if (privateLinkResourceName == null)
            {
                throw new ArgumentNullException(nameof(privateLinkResourceName));
            }
            if (privateLinkResourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(privateLinkResourceName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, privateLinkResourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BatchPrivateLinkResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BatchPrivateLinkResourceData.DeserializeBatchPrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BatchPrivateLinkResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByBatchAccountNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName, int? maxresults)
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

        /// <summary> Lists all of the private link resources in the specified account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ListPrivateLinkResourcesResult>> ListByBatchAccountNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, int? maxresults = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var message = CreateListByBatchAccountNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, maxresults);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListPrivateLinkResourcesResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ListPrivateLinkResourcesResult.DeserializeListPrivateLinkResourcesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the private link resources in the specified account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group that contains the Batch account. </param>
        /// <param name="accountName"> The name of the Batch account. </param>
        /// <param name="maxresults"> The maximum number of items to return in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ListPrivateLinkResourcesResult> ListByBatchAccountNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, int? maxresults = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (accountName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(accountName));
            }

            using var message = CreateListByBatchAccountNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, maxresults);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ListPrivateLinkResourcesResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ListPrivateLinkResourcesResult.DeserializeListPrivateLinkResourcesResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
