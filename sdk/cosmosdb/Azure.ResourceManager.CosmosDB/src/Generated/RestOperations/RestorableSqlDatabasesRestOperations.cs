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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    internal partial class RestorableSqlDatabasesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of RestorableSqlDatabasesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public RestorableSqlDatabasesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-10-15";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, AzureLocation location, string instanceId)
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
            uri.AppendPath("/restorableSqlDatabases", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB SQL databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="instanceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RestorableSqlDatabasesListResult>> ListAsync(string subscriptionId, AzureLocation location, string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var message = CreateListRequest(subscriptionId, location, instanceId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestorableSqlDatabasesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RestorableSqlDatabasesListResult.DeserializeRestorableSqlDatabasesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Show the event feed of all mutations done on all the Azure Cosmos DB SQL databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="location"> Cosmos DB region, with spaces between words and each word capitalized. </param>
        /// <param name="instanceId"> The instanceId GUID of a restorable database account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="instanceId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/> or <paramref name="instanceId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RestorableSqlDatabasesListResult> List(string subscriptionId, AzureLocation location, string instanceId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(instanceId, nameof(instanceId));

            using var message = CreateListRequest(subscriptionId, location, instanceId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RestorableSqlDatabasesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RestorableSqlDatabasesListResult.DeserializeRestorableSqlDatabasesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
