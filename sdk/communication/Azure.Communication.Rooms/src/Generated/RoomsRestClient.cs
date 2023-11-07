// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Rooms
{
    internal partial class RoomsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of RoomsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public RoomsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint, string apiVersion = "2023-10-30-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateCreateRequest(DateTimeOffset? validFrom, DateTimeOffset? validUntil, bool? pstnDialOutEnabled, IDictionary<string, ParticipantProperties> participants)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rooms", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Repeatability-Request-ID", Guid.NewGuid());
            request.Headers.Add("Repeatability-First-Sent", DateTimeOffset.Now, "R");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            if (participants == null || !participants.Any())
            {
                participants = new ChangeTrackingDictionary<string, ParticipantProperties>();
            }
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartObject();
            if (Optional.IsDefined(validFrom))
            {
                content.JsonWriter.WritePropertyName("validFrom"u8);
                content.JsonWriter.WriteStringValue(validFrom.Value, "O");
            }
            if (Optional.IsDefined(validUntil))
            {
                content.JsonWriter.WritePropertyName("validUntil"u8);
                content.JsonWriter.WriteStringValue(validUntil.Value, "O");
            }
            if (Optional.IsDefined(pstnDialOutEnabled))
            {
                content.JsonWriter.WritePropertyName("pstnDialOutEnabled"u8);
                content.JsonWriter.WriteBooleanValue(pstnDialOutEnabled.Value);
            }
            if (Optional.IsCollectionDefined(participants))
            {
                content.JsonWriter.WritePropertyName("participants"u8);
                content.JsonWriter.WriteStartObject();
                foreach (var item in participants)
                {
                    content.JsonWriter.WritePropertyName(item.Key);
                    content.JsonWriter.WriteObjectValue(item.Value);
                }
                content.JsonWriter.WriteEndObject();
            }
            content.JsonWriter.WriteEndObject();
            request.Content = content;
            return message;
        }

        /// <summary> Creates a new room. </summary>
        /// <param name="validFrom"> The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. The default value is the current date time. </param>
        /// <param name="validUntil"> The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. The default value is the current date time plus 180 days. </param>
        /// <param name="pstnDialOutEnabled"> Set this flag to true if, at the time of the call, dial out to a PSTN number is enabled in a particular room. By default, this flag is set to false. </param>
        /// <param name="participants"> (Optional) Participants to be invited to the room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<CommunicationRoom>> CreateAsync(DateTimeOffset? validFrom = null, DateTimeOffset? validUntil = null, bool? pstnDialOutEnabled = null, IDictionary<string, ParticipantProperties> participants = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRequest(validFrom, validUntil, pstnDialOutEnabled, participants);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CommunicationRoom value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunicationRoom.DeserializeCommunicationRoom(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new room. </summary>
        /// <param name="validFrom"> The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. The default value is the current date time. </param>
        /// <param name="validUntil"> The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. The default value is the current date time plus 180 days. </param>
        /// <param name="pstnDialOutEnabled"> Set this flag to true if, at the time of the call, dial out to a PSTN number is enabled in a particular room. By default, this flag is set to false. </param>
        /// <param name="participants"> (Optional) Participants to be invited to the room. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<CommunicationRoom> Create(DateTimeOffset? validFrom = null, DateTimeOffset? validUntil = null, bool? pstnDialOutEnabled = null, IDictionary<string, ParticipantProperties> participants = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateCreateRequest(validFrom, validUntil, pstnDialOutEnabled, participants);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CommunicationRoom value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunicationRoom.DeserializeCommunicationRoom(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rooms", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves all created rooms. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<RoomsCollection>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoomsCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoomsCollection.DeserializeRoomsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves all created rooms. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<RoomsCollection> List(CancellationToken cancellationToken = default)
        {
            using var message = CreateListRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoomsCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoomsCollection.DeserializeRoomsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string roomId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves an existing room by id. </summary>
        /// <param name="roomId"> The id of the room requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response<CommunicationRoom>> GetAsync(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateGetRequest(roomId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationRoom value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunicationRoom.DeserializeCommunicationRoom(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves an existing room by id. </summary>
        /// <param name="roomId"> The id of the room requested. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response<CommunicationRoom> Get(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateGetRequest(roomId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationRoom value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunicationRoom.DeserializeCommunicationRoom(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string roomId, DateTimeOffset? validFrom, DateTimeOffset? validUntil, bool? pstnDialOutEnabled)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/merge-patch+json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteStartObject();
            if (Optional.IsDefined(validFrom))
            {
                content.JsonWriter.WritePropertyName("validFrom"u8);
                content.JsonWriter.WriteStringValue(validFrom.Value, "O");
            }
            if (Optional.IsDefined(validUntil))
            {
                content.JsonWriter.WritePropertyName("validUntil"u8);
                content.JsonWriter.WriteStringValue(validUntil.Value, "O");
            }
            if (Optional.IsDefined(pstnDialOutEnabled))
            {
                content.JsonWriter.WritePropertyName("pstnDialOutEnabled"u8);
                content.JsonWriter.WriteBooleanValue(pstnDialOutEnabled.Value);
            }
            content.JsonWriter.WriteEndObject();
            request.Content = content;
            return message;
        }

        /// <summary> Update a room with given changes. </summary>
        /// <param name="roomId"> The id of the room requested. </param>
        /// <param name="validFrom"> (Optional) The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="validUntil"> (Optional) The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="pstnDialOutEnabled"> Set this flag to true if, at the time of the call, dial out to a PSTN number is enabled in a particular room. By default, this flag is set to false. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response<CommunicationRoom>> UpdateAsync(string roomId, DateTimeOffset? validFrom = null, DateTimeOffset? validUntil = null, bool? pstnDialOutEnabled = null, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateUpdateRequest(roomId, validFrom, validUntil, pstnDialOutEnabled);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationRoom value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CommunicationRoom.DeserializeCommunicationRoom(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update a room with given changes. </summary>
        /// <param name="roomId"> The id of the room requested. </param>
        /// <param name="validFrom"> (Optional) The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="validUntil"> (Optional) The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="pstnDialOutEnabled"> Set this flag to true if, at the time of the call, dial out to a PSTN number is enabled in a particular room. By default, this flag is set to false. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response<CommunicationRoom> Update(string roomId, DateTimeOffset? validFrom = null, DateTimeOffset? validUntil = null, bool? pstnDialOutEnabled = null, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateUpdateRequest(roomId, validFrom, validUntil, pstnDialOutEnabled);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        CommunicationRoom value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CommunicationRoom.DeserializeCommunicationRoom(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string roomId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/rooms/", false);
            uri.AppendPath(roomId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Delete a room. </summary>
        /// <param name="roomId"> The id of the room to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public async Task<Response> DeleteAsync(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateDeleteRequest(roomId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a room. </summary>
        /// <param name="roomId"> The id of the room to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roomId"/> is null. </exception>
        public Response Delete(string roomId, CancellationToken cancellationToken = default)
        {
            if (roomId == null)
            {
                throw new ArgumentNullException(nameof(roomId));
            }

            using var message = CreateDeleteRequest(roomId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves all created rooms. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<RoomsCollection>> ListNextPageAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoomsCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RoomsCollection.DeserializeRoomsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves all created rooms. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<RoomsCollection> ListNextPage(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListNextPageRequest(nextLink);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RoomsCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RoomsCollection.DeserializeRoomsCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
