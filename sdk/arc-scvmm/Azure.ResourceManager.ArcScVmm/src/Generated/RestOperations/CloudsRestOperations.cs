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
using Azure.ResourceManager.ArcScVmm.Models;

namespace Azure.ResourceManager.ArcScVmm
{
    internal partial class CloudsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of CloudsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public CloudsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-06-05-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string cloudName)
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
            uri.AppendPath("/providers/Microsoft.ScVmm/clouds/", false);
            uri.AppendPath(cloudName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Implements Cloud GET method. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ScVmmCloudData>> GetAsync(string subscriptionId, string resourceGroupName, string cloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudName, nameof(cloudName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScVmmCloudData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScVmmCloudData.DeserializeScVmmCloudData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ScVmmCloudData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Implements Cloud GET method. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ScVmmCloudData> Get(string subscriptionId, string resourceGroupName, string cloudName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudName, nameof(cloudName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, cloudName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScVmmCloudData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScVmmCloudData.DeserializeScVmmCloudData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ScVmmCloudData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string cloudName, ScVmmCloudData data)
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
            uri.AppendPath("/providers/Microsoft.ScVmm/clouds/", false);
            uri.AppendPath(cloudName, true);
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

        /// <summary> Onboards the ScVmm fabric cloud as an Azure cloud resource. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string cloudName, ScVmmCloudData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudName, nameof(cloudName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, cloudName, data);
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

        /// <summary> Onboards the ScVmm fabric cloud as an Azure cloud resource. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string cloudName, ScVmmCloudData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudName, nameof(cloudName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, cloudName, data);
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

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string cloudName, bool? force)
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
            uri.AppendPath("/providers/Microsoft.ScVmm/clouds/", false);
            uri.AppendPath(cloudName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (force != null)
            {
                uri.AppendQuery("force", force.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deregisters the ScVmm fabric cloud from Azure. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="force"> Forces the resource to be deleted from azure. The corresponding CR would be attempted to be deleted too. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string cloudName, bool? force = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudName, nameof(cloudName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, cloudName, force);
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

        /// <summary> Deregisters the ScVmm fabric cloud from Azure. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="force"> Forces the resource to be deleted from azure. The corresponding CR would be attempted to be deleted too. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string cloudName, bool? force = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudName, nameof(cloudName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, cloudName, force);
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

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string cloudName, ResourcePatch patch)
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
            uri.AppendPath("/providers/Microsoft.ScVmm/clouds/", false);
            uri.AppendPath(cloudName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(patch);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates the Clouds resource. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="patch"> Clouds patch payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string cloudName, ResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudName, nameof(cloudName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, cloudName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates the Clouds resource. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="patch"> Clouds patch payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="cloudName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string cloudName, ResourcePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(cloudName, nameof(cloudName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, cloudName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupRequest(string subscriptionId, string resourceGroupName)
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
            uri.AppendPath("/providers/Microsoft.ScVmm/clouds", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List of Clouds in a resource group. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudListResult>> ListByResourceGroupAsync(string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CloudListResult.DeserializeCloudListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List of Clouds in a resource group. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudListResult> ListByResourceGroup(string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CloudListResult.DeserializeCloudListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.ScVmm/clouds", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List of Clouds in a subscription. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudListResult>> ListBySubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListBySubscriptionRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CloudListResult.DeserializeCloudListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List of Clouds in a subscription. </summary>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudListResult> ListBySubscription(string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListBySubscriptionRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CloudListResult.DeserializeCloudListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByResourceGroupNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName)
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

        /// <summary> List of Clouds in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudListResult>> ListByResourceGroupNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CloudListResult.DeserializeCloudListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List of Clouds in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudListResult> ListByResourceGroupNextPage(string nextLink, string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));

            using var message = CreateListByResourceGroupNextPageRequest(nextLink, subscriptionId, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CloudListResult.DeserializeCloudListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListBySubscriptionNextPageRequest(string nextLink, string subscriptionId)
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

        /// <summary> List of Clouds in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<CloudListResult>> ListBySubscriptionNextPageAsync(string nextLink, string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListBySubscriptionNextPageRequest(nextLink, subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CloudListResult.DeserializeCloudListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List of Clouds in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The Azure subscription ID. This is a GUID-formatted string (e.g. 00000000-0000-0000-0000-000000000000). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="subscriptionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<CloudListResult> ListBySubscriptionNextPage(string nextLink, string subscriptionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));

            using var message = CreateListBySubscriptionNextPageRequest(nextLink, subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CloudListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CloudListResult.DeserializeCloudListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
