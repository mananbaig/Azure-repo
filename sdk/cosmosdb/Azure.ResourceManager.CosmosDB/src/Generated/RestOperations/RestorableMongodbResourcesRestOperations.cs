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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    internal partial class RestorableMongodbResourcesRestOperations
    {
        private readonly string _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of RestorableMongodbResourcesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public RestorableMongodbResourcesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-15";
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string location, string instanceId, string restoreLocation, string restoreTimestampInUtc)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.DocumentDB/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/restorableDatabaseAccounts/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/restorableMongodbResources", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (restoreLocation != null)
            {
                uri.AppendQuery("restoreLocation", restoreLocation, true);
            }
            if (restoreTimestampInUtc != null)
            {
                uri.AppendQuery("restoreTimestampInUtc", restoreTimestampInUtc, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Return a list of database and collection combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public async Task<Response<RestorableMongodbResourcesListResult>> ListAsync(string subscriptionId, string location, string instanceId, string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var message = CreateListRequest(subscriptionId, location, instanceId, restoreLocation, restoreTimestampInUtc);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestorableMongodbResourcesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RestorableMongodbResourcesListResult.DeserializeRestorableMongodbResourcesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Return a list of database and collection combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/> or <paramref name="instanceId"/> is null. </exception>
        public Response<RestorableMongodbResourcesListResult> List(string subscriptionId, string location, string instanceId, string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var message = CreateListRequest(subscriptionId, location, instanceId, restoreLocation, restoreTimestampInUtc);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestorableMongodbResourcesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RestorableMongodbResourcesListResult.DeserializeRestorableMongodbResourcesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
