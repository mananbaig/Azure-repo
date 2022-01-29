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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    internal partial class JitRequestsRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of JitRequestsRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public JitRequestsRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2019-07-01";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal Azure.Core.HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string jitRequestName)
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
            uri.AppendPath("/providers/Microsoft.Solutions/jitRequests/", false);
            uri.AppendPath(jitRequestName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Gets the JIT request. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="jitRequestName"/> is null. </exception>
        public async Task<Response<JitRequestData>> GetAsync(string subscriptionId, string resourceGroupName, string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, jitRequestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JitRequestData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JitRequestData.DeserializeJitRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((JitRequestData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the JIT request. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="jitRequestName"/> is null. </exception>
        public Response<JitRequestData> Get(string subscriptionId, string resourceGroupName, string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, jitRequestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JitRequestData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JitRequestData.DeserializeJitRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((JitRequestData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string jitRequestName, JitRequestData parameters)
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
            uri.AppendPath("/providers/Microsoft.Solutions/jitRequests/", false);
            uri.AppendPath(jitRequestName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Creates or updates the JIT request. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="parameters"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="jitRequestName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string jitRequestName, JitRequestData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, jitRequestName, parameters);
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

        /// <summary> Creates or updates the JIT request. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="parameters"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="jitRequestName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string jitRequestName, JitRequestData parameters, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, jitRequestName, parameters);
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

        internal Azure.Core.HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string jitRequestName, IDictionary<string, string> tags)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Solutions/jitRequests/", false);
            uri.AppendPath(jitRequestName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            JitRequestPatchable jitRequestPatchable = new JitRequestPatchable();
            if (tags != null)
            {
                foreach (var value in tags)
                {
                    jitRequestPatchable.Tags.Add(value);
                }
            }
            var model = jitRequestPatchable;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Updates the JIT request. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="tags"> Jit request tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="jitRequestName"/> is null. </exception>
        public async Task<Response<JitRequestData>> UpdateAsync(string subscriptionId, string resourceGroupName, string jitRequestName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, jitRequestName, tags);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JitRequestData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JitRequestData.DeserializeJitRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Updates the JIT request. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="tags"> Jit request tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="jitRequestName"/> is null. </exception>
        public Response<JitRequestData> Update(string subscriptionId, string resourceGroupName, string jitRequestName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, jitRequestName, tags);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JitRequestData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JitRequestData.DeserializeJitRequestData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string jitRequestName)
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
            uri.AppendPath("/providers/Microsoft.Solutions/jitRequests/", false);
            uri.AppendPath(jitRequestName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Deletes the JIT request. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="jitRequestName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, jitRequestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the JIT request. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, or <paramref name="jitRequestName"/> is null. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string jitRequestName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, jitRequestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateListBySubscriptionRequest(string subscriptionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Solutions/jitRequests", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Retrieves all JIT requests within the subscription. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public async Task<Response<JitRequestListResult>> ListBySubscriptionAsync(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreateListBySubscriptionRequest(subscriptionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JitRequestListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JitRequestListResult.DeserializeJitRequestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves all JIT requests within the subscription. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> is null. </exception>
        public Response<JitRequestListResult> ListBySubscription(string subscriptionId, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }

            using var message = CreateListBySubscriptionRequest(subscriptionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JitRequestListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JitRequestListResult.DeserializeJitRequestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateListByResourceGroupRequest(string subscriptionId, string resourceGroupName)
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
            uri.AppendPath("/providers/Microsoft.Solutions/jitRequests", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Retrieves all JIT requests within the resource group. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<JitRequestListResult>> ListByResourceGroupAsync(string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JitRequestListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = JitRequestListResult.DeserializeJitRequestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves all JIT requests within the resource group. </summary>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<JitRequestListResult> ListByResourceGroup(string subscriptionId, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateListByResourceGroupRequest(subscriptionId, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        JitRequestListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = JitRequestListResult.DeserializeJitRequestListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
