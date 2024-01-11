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
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    internal partial class DataSetMappingsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of DataSetMappingsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public DataSetMappingsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/dataSetMappings/", false);
            uri.AppendPath(dataSetMappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName)
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
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/dataSetMappings/", false);
            uri.AppendPath(dataSetMappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get a DataSetMapping in a shareSubscription. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ShareDataSetMappingData>> GetAsync(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ShareDataSetMappingData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ShareDataSetMappingData.DeserializeShareDataSetMappingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ShareDataSetMappingData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get a DataSetMapping in a shareSubscription. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ShareDataSetMappingData> Get(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ShareDataSetMappingData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ShareDataSetMappingData.DeserializeShareDataSetMappingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ShareDataSetMappingData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateCreateRequestUri(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, ShareDataSetMappingData data)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/dataSetMappings/", false);
            uri.AppendPath(dataSetMappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, ShareDataSetMappingData data)
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
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/dataSetMappings/", false);
            uri.AppendPath(dataSetMappingName, true);
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

        /// <summary> Create a DataSetMapping. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the share subscription which will hold the data set sink. </param>
        /// <param name="dataSetMappingName"> The name of the data set mapping to be created. </param>
        /// <param name="data"> Destination data set configuration details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/>, <paramref name="dataSetMappingName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ShareDataSetMappingData>> CreateAsync(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, ShareDataSetMappingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ShareDataSetMappingData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ShareDataSetMappingData.DeserializeShareDataSetMappingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a DataSetMapping. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the share subscription which will hold the data set sink. </param>
        /// <param name="dataSetMappingName"> The name of the data set mapping to be created. </param>
        /// <param name="data"> Destination data set configuration details. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/>, <paramref name="dataSetMappingName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ShareDataSetMappingData> Create(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, ShareDataSetMappingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    {
                        ShareDataSetMappingData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ShareDataSetMappingData.DeserializeShareDataSetMappingData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateDeleteRequestUri(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/dataSetMappings/", false);
            uri.AppendPath(dataSetMappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName)
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
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/dataSetMappings/", false);
            uri.AppendPath(dataSetMappingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a DataSetMapping in a shareSubscription. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
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

        /// <summary> Delete a DataSetMapping in a shareSubscription. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the shareSubscription. </param>
        /// <param name="dataSetMappingName"> The name of the dataSetMapping. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/>, <paramref name="shareSubscriptionName"/> or <paramref name="dataSetMappingName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string dataSetMappingName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));
            Argument.AssertNotNullOrEmpty(dataSetMappingName, nameof(dataSetMappingName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, dataSetMappingName);
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

        internal RequestUriBuilder CreateListByShareSubscriptionRequestUri(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken, string filter, string orderby)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/dataSetMappings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            return uri;
        }

        internal HttpMessage CreateListByShareSubscriptionRequest(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken, string filter, string orderby)
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
            uri.AppendPath("/providers/Microsoft.DataShare/accounts/", false);
            uri.AppendPath(accountName, true);
            uri.AppendPath("/shareSubscriptions/", false);
            uri.AppendPath(shareSubscriptionName, true);
            uri.AppendPath("/dataSetMappings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            if (filter != null)
            {
                uri.AppendQuery("$filter", filter, true);
            }
            if (orderby != null)
            {
                uri.AppendQuery("$orderby", orderby, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List DataSetMappings in a share subscription. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the share subscription. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataSetMappingList>> ListByShareSubscriptionAsync(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var message = CreateListByShareSubscriptionRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, skipToken, filter, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataSetMappingList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataSetMappingList.DeserializeDataSetMappingList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List DataSetMappings in a share subscription. </summary>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the share subscription. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataSetMappingList> ListByShareSubscription(string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var message = CreateListByShareSubscriptionRequest(subscriptionId, resourceGroupName, accountName, shareSubscriptionName, skipToken, filter, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataSetMappingList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataSetMappingList.DeserializeDataSetMappingList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByShareSubscriptionNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken, string filter, string orderby)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByShareSubscriptionNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken, string filter, string orderby)
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

        /// <summary> List DataSetMappings in a share subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the share subscription. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<DataSetMappingList>> ListByShareSubscriptionNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var message = CreateListByShareSubscriptionNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, shareSubscriptionName, skipToken, filter, orderby);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataSetMappingList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DataSetMappingList.DeserializeDataSetMappingList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List DataSetMappings in a share subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="shareSubscriptionName"> The name of the share subscription. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="filter"> Filters the results using OData syntax. </param>
        /// <param name="orderby"> Sorts the results using OData syntax. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="accountName"/> or <paramref name="shareSubscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<DataSetMappingList> ListByShareSubscriptionNextPage(string nextLink, string subscriptionId, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = null, string filter = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNullOrEmpty(shareSubscriptionName, nameof(shareSubscriptionName));

            using var message = CreateListByShareSubscriptionNextPageRequest(nextLink, subscriptionId, resourceGroupName, accountName, shareSubscriptionName, skipToken, filter, orderby);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DataSetMappingList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DataSetMappingList.DeserializeDataSetMappingList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
