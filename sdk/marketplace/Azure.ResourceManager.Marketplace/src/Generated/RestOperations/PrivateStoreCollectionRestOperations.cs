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
using Azure.ResourceManager.Marketplace.Models;

namespace Azure.ResourceManager.Marketplace
{
    internal partial class PrivateStoreCollectionRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of PrivateStoreCollectionRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public PrivateStoreCollectionRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-03-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(Guid privateStoreId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets private store collections list. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<CollectionsList>> ListAsync(Guid privateStoreId, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(privateStoreId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CollectionsList.DeserializeCollectionsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets private store collections list. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<CollectionsList> List(Guid privateStoreId, CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest(privateStoreId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CollectionsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CollectionsList.DeserializeCollectionsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(Guid privateStoreId, Guid collectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets private store collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PrivateStoreCollectionInfoData>> GetAsync(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(privateStoreId, collectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreCollectionInfoData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateStoreCollectionInfoData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets private store collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateStoreCollectionInfoData> Get(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetRequest(privateStoreId, collectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreCollectionInfoData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((PrivateStoreCollectionInfoData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(Guid privateStoreId, Guid collectionId, PrivateStoreCollectionInfoData info)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Core.Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(info);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create or update private store collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="info"> The PrivateStoreCollectionInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public async Task<Response<PrivateStoreCollectionInfoData>> CreateOrUpdateAsync(Guid privateStoreId, Guid collectionId, PrivateStoreCollectionInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var message = CreateCreateOrUpdateRequest(privateStoreId, collectionId, info);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreCollectionInfoData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update private store collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="info"> The PrivateStoreCollectionInfo to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="info"/> is null. </exception>
        public Response<PrivateStoreCollectionInfoData> CreateOrUpdate(Guid privateStoreId, Guid collectionId, PrivateStoreCollectionInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(info, nameof(info));

            using var message = CreateCreateOrUpdateRequest(privateStoreId, collectionId, info);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreCollectionInfoData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(Guid privateStoreId, Guid collectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a collection from the given private store. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteRequest(privateStoreId, collectionId);
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

        /// <summary> Delete a collection from the given private store. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDeleteRequest(privateStoreId, collectionId);
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

        internal HttpMessage CreatePostRequest(Guid privateStoreId, Guid collectionId, PrivateStoreOperation? payload)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (payload != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Core.Utf8JsonRequestContent();
                content.JsonWriter.WriteStringValue(payload.Value.ToString());
                request.Content = content;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete Private store collection. This is a workaround. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="payload"> The PrivateStoreOperation to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> PostAsync(Guid privateStoreId, Guid collectionId, PrivateStoreOperation? payload = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostRequest(privateStoreId, collectionId, payload);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete Private store collection. This is a workaround. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="payload"> The PrivateStoreOperation to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Post(Guid privateStoreId, Guid collectionId, PrivateStoreOperation? payload = null, CancellationToken cancellationToken = default)
        {
            using var message = CreatePostRequest(privateStoreId, collectionId, payload);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateTransferOffersRequest(Guid privateStoreId, Guid collectionId, TransferOffersContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/transferOffers", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (content != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content0 = new Core.Utf8JsonRequestContent();
                content0.JsonWriter.WriteObjectValue(content);
                request.Content = content0;
            }
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> transferring offers (copy or move) from source collection to target collection(s). </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="content"> The TransferOffersContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<TransferOffersResult>> TransferOffersAsync(Guid privateStoreId, Guid collectionId, TransferOffersContent content = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateTransferOffersRequest(privateStoreId, collectionId, content);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TransferOffersResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TransferOffersResult.DeserializeTransferOffersResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> transferring offers (copy or move) from source collection to target collection(s). </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="content"> The TransferOffersContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<TransferOffersResult> TransferOffers(Guid privateStoreId, Guid collectionId, TransferOffersContent content = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateTransferOffersRequest(privateStoreId, collectionId, content);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TransferOffersResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TransferOffersResult.DeserializeTransferOffersResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateApproveAllItemsRequest(Guid privateStoreId, Guid collectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/approveAllItems", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete all existing offers from the collection and enable approve all items. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PrivateStoreCollectionInfoData>> ApproveAllItemsAsync(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateApproveAllItemsRequest(privateStoreId, collectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreCollectionInfoData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete all existing offers from the collection and enable approve all items. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateStoreCollectionInfoData> ApproveAllItems(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateApproveAllItemsRequest(privateStoreId, collectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreCollectionInfoData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDisableApproveAllItemsRequest(Guid privateStoreId, Guid collectionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Marketplace/privateStores/", false);
            uri.AppendPath(privateStoreId, true);
            uri.AppendPath("/collections/", false);
            uri.AppendPath(collectionId, true);
            uri.AppendPath("/disableApproveAllItems", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Disable approve all items for the collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PrivateStoreCollectionInfoData>> DisableApproveAllItemsAsync(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDisableApproveAllItemsRequest(privateStoreId, collectionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreCollectionInfoData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Disable approve all items for the collection. </summary>
        /// <param name="privateStoreId"> The store ID - must use the tenant ID. </param>
        /// <param name="collectionId"> The collection ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PrivateStoreCollectionInfoData> DisableApproveAllItems(Guid privateStoreId, Guid collectionId, CancellationToken cancellationToken = default)
        {
            using var message = CreateDisableApproveAllItemsRequest(privateStoreId, collectionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        PrivateStoreCollectionInfoData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = PrivateStoreCollectionInfoData.DeserializePrivateStoreCollectionInfoData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
