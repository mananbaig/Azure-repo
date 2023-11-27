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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    internal partial class TemplateSpecVersionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TemplateSpecVersionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TemplateSpecVersionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal Core.HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionData data)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(templateSpecVersion, true);
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

        /// <summary> Creates or updates a Template Spec version. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="data"> Template Spec Version supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, <paramref name="templateSpecVersion"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TemplateSpecVersionData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));
            Argument.AssertNotNullOrEmpty(templateSpecVersion, nameof(templateSpecVersion));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, templateSpecName, templateSpecVersion, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        TemplateSpecVersionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersionData.DeserializeTemplateSpecVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a Template Spec version. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="data"> Template Spec Version supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, <paramref name="templateSpecVersion"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TemplateSpecVersionData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));
            Argument.AssertNotNullOrEmpty(templateSpecVersion, nameof(templateSpecVersion));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, templateSpecName, templateSpecVersion, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        TemplateSpecVersionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersionData.DeserializeTemplateSpecVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionPatch patch)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(templateSpecVersion, true);
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

        /// <summary> Updates Template Spec Version tags with specified values. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="patch"> Template Spec Version resource with the tags to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, <paramref name="templateSpecVersion"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TemplateSpecVersionData>> UpdateAsync(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));
            Argument.AssertNotNullOrEmpty(templateSpecVersion, nameof(templateSpecVersion));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, templateSpecName, templateSpecVersion, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersionData.DeserializeTemplateSpecVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates Template Spec Version tags with specified values. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="patch"> Template Spec Version resource with the tags to be updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/>, <paramref name="templateSpecVersion"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TemplateSpecVersionData> Update(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, TemplateSpecVersionPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));
            Argument.AssertNotNullOrEmpty(templateSpecVersion, nameof(templateSpecVersion));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, templateSpecName, templateSpecVersion, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersionData.DeserializeTemplateSpecVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(templateSpecVersion, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a Template Spec version from a specific Template Spec. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TemplateSpecVersionData>> GetAsync(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));
            Argument.AssertNotNullOrEmpty(templateSpecVersion, nameof(templateSpecVersion));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, templateSpecName, templateSpecVersion);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersionData.DeserializeTemplateSpecVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TemplateSpecVersionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a Template Spec version from a specific Template Spec. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TemplateSpecVersionData> Get(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));
            Argument.AssertNotNullOrEmpty(templateSpecVersion, nameof(templateSpecVersion));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, templateSpecName, templateSpecVersion);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersionData.DeserializeTemplateSpecVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TemplateSpecVersionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(templateSpecVersion, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes a specific version from a Template Spec. When operation completes, status code 200 returned without content. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));
            Argument.AssertNotNullOrEmpty(templateSpecVersion, nameof(templateSpecVersion));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, templateSpecName, templateSpecVersion);
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

        /// <summary> Deletes a specific version from a Template Spec. When operation completes, status code 200 returned without content. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="templateSpecVersion"> The version of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="templateSpecName"/> or <paramref name="templateSpecVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string templateSpecName, string templateSpecVersion, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));
            Argument.AssertNotNullOrEmpty(templateSpecVersion, nameof(templateSpecVersion));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, templateSpecName, templateSpecVersion);
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

        internal Core.HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string templateSpecName)
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
            uri.AppendPath("/providers/Microsoft.Resources/templateSpecs/", false);
            uri.AppendPath(templateSpecName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TemplateSpecVersionsListResult>> ListAsync(string subscriptionId, string resourceGroupName, string templateSpecName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, templateSpecName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersionsListResult.DeserializeTemplateSpecVersionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TemplateSpecVersionsListResult> List(string subscriptionId, string resourceGroupName, string templateSpecName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, templateSpecName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersionsListResult.DeserializeTemplateSpecVersionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Core.HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string templateSpecName)
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

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TemplateSpecVersionsListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string templateSpecName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, templateSpecName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TemplateSpecVersionsListResult.DeserializeTemplateSpecVersionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all the Template Spec versions in the specified Template Spec. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Subscription Id which forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="templateSpecName"> Name of the Template Spec. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="templateSpecName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TemplateSpecVersionsListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string templateSpecName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(templateSpecName, nameof(templateSpecName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, templateSpecName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TemplateSpecVersionsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TemplateSpecVersionsListResult.DeserializeTemplateSpecVersionsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
