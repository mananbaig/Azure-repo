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
    internal partial class RestorableMongodbDatabasesRestOperations
    {
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of RestorableMongodbDatabasesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public RestorableMongodbDatabasesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? "2021-06-15";
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string location, string instanceId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.DocumentDB/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/restorableDatabaseAccounts/", false);
            uri.AppendPath(instanceId, true);
            uri.AppendPath("/restorableMongodbDatabases", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires  &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, or <paramref name="instanceId"/> is null. </exception>
        public async Task<Response<RestorableMongodbDatabasesList>> ListAsync(string subscriptionId, string location, string instanceId, CancellationToken cancellationToken = default)
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

            using var message = CreateListRequest(subscriptionId, location, instanceId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestorableMongodbDatabasesList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RestorableMongodbDatabasesList.DeserializeRestorableMongodbDatabasesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires  &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="location"/>, or <paramref name="instanceId"/> is null. </exception>
        public Response<RestorableMongodbDatabasesList> List(string subscriptionId, string location, string instanceId, CancellationToken cancellationToken = default)
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

            using var message = CreateListRequest(subscriptionId, location, instanceId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestorableMongodbDatabasesList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RestorableMongodbDatabasesList.DeserializeRestorableMongodbDatabasesList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
