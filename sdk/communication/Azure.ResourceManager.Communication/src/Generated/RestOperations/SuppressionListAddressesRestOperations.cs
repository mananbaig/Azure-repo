// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Communication.Models;

namespace Azure.ResourceManager.Communication
{
    internal partial class SuppressionListAddressesRestOperations
    {
        private string _skipTokenQueryParameter = "$skipToken";
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of SuppressionListAddressesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SuppressionListAddressesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName)
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
            uri.AppendPath("/providers/Microsoft.Communication/emailServices/", false);
            uri.AppendPath(emailServiceName, true);
            uri.AppendPath("/domains/", false);
            uri.AppendPath(domainName, true);
            uri.AppendPath("/suppressionLists/", false);
            uri.AppendPath(suppressionListName, true);
            uri.AppendPath("/suppressionListAddresses", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all the addresses in a suppression list. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/> or <paramref name="suppressionListName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/> or <paramref name="suppressionListName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Models.SuppressionListAddressResourceCollection>> ListAsync(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.SuppressionListAddressResourceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.SuppressionListAddressResourceCollection.DeserializeSuppressionListAddressResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all the addresses in a suppression list. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/> or <paramref name="suppressionListName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/> or <paramref name="suppressionListName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Models.SuppressionListAddressResourceCollection> List(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.SuppressionListAddressResourceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.SuppressionListAddressResourceCollection.DeserializeSuppressionListAddressResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId)
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
            uri.AppendPath("/providers/Microsoft.Communication/emailServices/", false);
            uri.AppendPath(emailServiceName, true);
            uri.AppendPath("/domains/", false);
            uri.AppendPath(domainName, true);
            uri.AppendPath("/suppressionLists/", false);
            uri.AppendPath(suppressionListName, true);
            uri.AppendPath("/suppressionListAddresses/", false);
            uri.AppendPath(addressId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a SuppressionListAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="addressId"> The id of the address in a suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SuppressionListAddressResourceData>> GetAsync(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));
            Argument.AssertNotNullOrEmpty(addressId, nameof(addressId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName, addressId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SuppressionListAddressResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SuppressionListAddressResourceData.DeserializeSuppressionListAddressResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SuppressionListAddressResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a SuppressionListAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="addressId"> The id of the address in a suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SuppressionListAddressResourceData> Get(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));
            Argument.AssertNotNullOrEmpty(addressId, nameof(addressId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName, addressId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        SuppressionListAddressResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SuppressionListAddressResourceData.DeserializeSuppressionListAddressResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((SuppressionListAddressResourceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId, SuppressionListAddressResourceData data)
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
            uri.AppendPath("/providers/Microsoft.Communication/emailServices/", false);
            uri.AppendPath(emailServiceName, true);
            uri.AppendPath("/domains/", false);
            uri.AppendPath(domainName, true);
            uri.AppendPath("/suppressionLists/", false);
            uri.AppendPath(suppressionListName, true);
            uri.AppendPath("/suppressionListAddresses/", false);
            uri.AppendPath(addressId, true);
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

        /// <summary> Create or update a SuppressionListAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="addressId"> The id of the address in a suppression list. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/>, <paramref name="addressId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<SuppressionListAddressResourceData>> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId, SuppressionListAddressResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));
            Argument.AssertNotNullOrEmpty(addressId, nameof(addressId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName, addressId, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SuppressionListAddressResourceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SuppressionListAddressResourceData.DeserializeSuppressionListAddressResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update a SuppressionListAddress. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="addressId"> The id of the address in a suppression list. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/>, <paramref name="addressId"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<SuppressionListAddressResourceData> CreateOrUpdate(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId, SuppressionListAddressResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));
            Argument.AssertNotNullOrEmpty(addressId, nameof(addressId));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName, addressId, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        SuppressionListAddressResourceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SuppressionListAddressResourceData.DeserializeSuppressionListAddressResourceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId)
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
            uri.AppendPath("/providers/Microsoft.Communication/emailServices/", false);
            uri.AppendPath(emailServiceName, true);
            uri.AppendPath("/domains/", false);
            uri.AppendPath(domainName, true);
            uri.AppendPath("/suppressionLists/", false);
            uri.AppendPath(suppressionListName, true);
            uri.AppendPath("/suppressionListAddresses/", false);
            uri.AppendPath(addressId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Operation to delete a single address from a suppression list. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="addressId"> The id of the address in a suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));
            Argument.AssertNotNullOrEmpty(addressId, nameof(addressId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName, addressId);
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

        /// <summary> Operation to delete a single address from a suppression list. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="addressId"> The id of the address in a suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/>, <paramref name="suppressionListName"/> or <paramref name="addressId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, string addressId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));
            Argument.AssertNotNullOrEmpty(addressId, nameof(addressId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName, addressId);
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

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName)
        {
            if (string.IsNullOrWhiteSpace(nextLink))
                return default;

            var query = HttpUtility.ParseQueryString(new Uri(nextLink).Query);
            var skipToken = query.Get(_skipTokenQueryParameter);

            if (string.IsNullOrWhiteSpace(skipToken))
                return default;

            var skipTokenQueryParam = $"{_skipTokenQueryParameter}={skipToken}";

            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(skipTokenQueryParam, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get all the addresses in a suppression list. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/> or <paramref name="suppressionListName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/> or <paramref name="suppressionListName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<Models.SuppressionListAddressResourceCollection>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.SuppressionListAddressResourceCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.SuppressionListAddressResourceCollection.DeserializeSuppressionListAddressResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get all the addresses in a suppression list. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. The value must be an UUID. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="emailServiceName"> The name of the EmailService resource. </param>
        /// <param name="domainName"> The name of the Domains resource. </param>
        /// <param name="suppressionListName"> The name of the suppression list. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/> or <paramref name="suppressionListName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="emailServiceName"/>, <paramref name="domainName"/> or <paramref name="suppressionListName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<Models.SuppressionListAddressResourceCollection> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string emailServiceName, string domainName, string suppressionListName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(emailServiceName, nameof(emailServiceName));
            Argument.AssertNotNullOrEmpty(domainName, nameof(domainName));
            Argument.AssertNotNullOrEmpty(suppressionListName, nameof(suppressionListName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, emailServiceName, domainName, suppressionListName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.SuppressionListAddressResourceCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.SuppressionListAddressResourceCollection.DeserializeSuppressionListAddressResourceCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
