// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AgFoodPlatform.Models;

namespace Azure.ResourceManager.AgFoodPlatform
{
    internal partial class ExtensionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ExtensionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ExtensionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-09-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId)
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
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeats/", false);
            uri.AppendPath(farmBeatsResourceName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(extensionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Install extension. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExtensionData>> CreateAsync(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        ExtensionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExtensionData.DeserializeExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Install extension. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExtensionData> Create(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        ExtensionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExtensionData.DeserializeExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId)
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
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeats/", false);
            uri.AppendPath(farmBeatsResourceName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(extensionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get installed extension details by extension id. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExtensionData>> GetAsync(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExtensionData.DeserializeExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExtensionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get installed extension details by extension id. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExtensionData> Get(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExtensionData.DeserializeExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ExtensionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeats/", false);
            uri.AppendPath(farmBeatsResourceName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(extensionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Upgrade to latest extension. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExtensionData>> UpdateAsync(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExtensionData.DeserializeExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Upgrade to latest extension. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExtensionData> Update(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExtensionData.DeserializeExtensionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId)
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
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeats/", false);
            uri.AppendPath(farmBeatsResourceName, true);
            uri.AppendPath("/extensions/", false);
            uri.AppendPath(extensionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Uninstall extension. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionId);
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

        /// <summary> Uninstall extension. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionId"> Id of extension resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="farmBeatsResourceName"/> or <paramref name="extensionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, string extensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));
            Argument.AssertNotNullOrEmpty(extensionId, nameof(extensionId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionId);
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

        internal HttpMessage CreateListByFarmBeatsRequest(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, IEnumerable<string> extensionIds, IEnumerable<string> extensionCategories, int? maxPageSize, string skipToken)
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
            uri.AppendPath("/providers/Microsoft.AgFoodPlatform/farmBeats/", false);
            uri.AppendPath(farmBeatsResourceName, true);
            uri.AppendPath("/extensions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (extensionIds != null && !(extensionIds is ChangeTrackingList<string> changeTrackingList && changeTrackingList.IsUndefined))
            {
                foreach (var param in extensionIds)
                {
                    uri.AppendQuery("extensionIds", param, true);
                }
            }
            if (extensionCategories != null && !(extensionCategories is ChangeTrackingList<string> changeTrackingList0 && changeTrackingList0.IsUndefined))
            {
                foreach (var param in extensionCategories)
                {
                    uri.AppendQuery("extensionCategories", param, true);
                }
            }
            if (maxPageSize != null)
            {
                uri.AppendQuery("$maxPageSize", maxPageSize.Value, true);
            }
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get installed extensions details. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionIds"> Installed extension ids. </param>
        /// <param name="extensionCategories"> Installed extension categories. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="farmBeatsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExtensionListResponse>> ListByFarmBeatsAsync(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, IEnumerable<string> extensionIds = null, IEnumerable<string> extensionCategories = null, int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var message = CreateListByFarmBeatsRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionIds, extensionCategories, maxPageSize, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExtensionListResponse.DeserializeExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get installed extensions details. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionIds"> Installed extension ids. </param>
        /// <param name="extensionCategories"> Installed extension categories. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="farmBeatsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExtensionListResponse> ListByFarmBeats(string subscriptionId, string resourceGroupName, string farmBeatsResourceName, IEnumerable<string> extensionIds = null, IEnumerable<string> extensionCategories = null, int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var message = CreateListByFarmBeatsRequest(subscriptionId, resourceGroupName, farmBeatsResourceName, extensionIds, extensionCategories, maxPageSize, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExtensionListResponse.DeserializeExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByFarmBeatsNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string farmBeatsResourceName, IEnumerable<string> extensionIds, IEnumerable<string> extensionCategories, int? maxPageSize, string skipToken)
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

        /// <summary> Get installed extensions details. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionIds"> Installed extension ids. </param>
        /// <param name="extensionCategories"> Installed extension categories. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="farmBeatsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ExtensionListResponse>> ListByFarmBeatsNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string farmBeatsResourceName, IEnumerable<string> extensionIds = null, IEnumerable<string> extensionCategories = null, int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var message = CreateListByFarmBeatsNextPageRequest(nextLink, subscriptionId, resourceGroupName, farmBeatsResourceName, extensionIds, extensionCategories, maxPageSize, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionListResponse value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ExtensionListResponse.DeserializeExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get installed extensions details. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="extensionIds"> Installed extension ids. </param>
        /// <param name="extensionCategories"> Installed extension categories. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="farmBeatsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ExtensionListResponse> ListByFarmBeatsNextPage(string nextLink, string subscriptionId, string resourceGroupName, string farmBeatsResourceName, IEnumerable<string> extensionIds = null, IEnumerable<string> extensionCategories = null, int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(farmBeatsResourceName, nameof(farmBeatsResourceName));

            using var message = CreateListByFarmBeatsNextPageRequest(nextLink, subscriptionId, resourceGroupName, farmBeatsResourceName, extensionIds, extensionCategories, maxPageSize, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ExtensionListResponse value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ExtensionListResponse.DeserializeExtensionListResponse(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
