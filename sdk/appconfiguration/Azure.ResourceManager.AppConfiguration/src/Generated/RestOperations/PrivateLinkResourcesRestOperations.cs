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
using Azure.ResourceManager.AppConfiguration.Models;

namespace Azure.ResourceManager.AppConfiguration
{
    internal partial class PrivateLinkResourcesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrivateLinkResourcesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PrivateLinkResourcesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByConfigurationStoreRequest(string subscriptionId, string resourceGroupName, string configStoreName)
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
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateLinkResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AppConfigurationPrivateLinkResourceListResult>> ListByConfigurationStoreAsync(string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var message = CreateListByConfigurationStoreRequest(subscriptionId, resourceGroupName, configStoreName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppConfigurationPrivateLinkResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppConfigurationPrivateLinkResourceListResult.DeserializeAppConfigurationPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AppConfigurationPrivateLinkResourceListResult> ListByConfigurationStore(string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var message = CreateListByConfigurationStoreRequest(subscriptionId, resourceGroupName, configStoreName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppConfigurationPrivateLinkResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppConfigurationPrivateLinkResourceListResult.DeserializeAppConfigurationPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string configStoreName, string groupName)
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
            uri.AppendPath("/providers/Microsoft.AppConfiguration/configurationStores/", false);
            uri.AppendPath(configStoreName, true);
            uri.AppendPath("/privateLinkResources/", false);
            uri.AppendPath(groupName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a private link resource that need to be created for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/> or <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AppConfigurationPrivateLinkResourceData>> GetAsync(string subscriptionId, string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, configStoreName, groupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppConfigurationPrivateLinkResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppConfigurationPrivateLinkResourceData.DeserializeAppConfigurationPrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppConfigurationPrivateLinkResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a private link resource that need to be created for a configuration store. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="groupName"> The name of the private link resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/> or <paramref name="groupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="configStoreName"/> or <paramref name="groupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AppConfigurationPrivateLinkResourceData> Get(string subscriptionId, string resourceGroupName, string configStoreName, string groupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));
            Argument.AssertNotNullOrEmpty(groupName, nameof(groupName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, configStoreName, groupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppConfigurationPrivateLinkResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppConfigurationPrivateLinkResourceData.DeserializeAppConfigurationPrivateLinkResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((AppConfigurationPrivateLinkResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByConfigurationStoreNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName)
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

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<AppConfigurationPrivateLinkResourceListResult>> ListByConfigurationStoreNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var message = CreateListByConfigurationStoreNextPageRequest(nextLink, subscriptionId, resourceGroupName, configStoreName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppConfigurationPrivateLinkResourceListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = AppConfigurationPrivateLinkResourceListResult.DeserializeAppConfigurationPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the private link resources that need to be created for a configuration store. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="configStoreName"> The name of the configuration store. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="configStoreName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="configStoreName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<AppConfigurationPrivateLinkResourceListResult> ListByConfigurationStoreNextPage(string nextLink, string subscriptionId, string resourceGroupName, string configStoreName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(configStoreName, nameof(configStoreName));

            using var message = CreateListByConfigurationStoreNextPageRequest(nextLink, subscriptionId, resourceGroupName, configStoreName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        AppConfigurationPrivateLinkResourceListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = AppConfigurationPrivateLinkResourceListResult.DeserializeAppConfigurationPrivateLinkResourceListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
