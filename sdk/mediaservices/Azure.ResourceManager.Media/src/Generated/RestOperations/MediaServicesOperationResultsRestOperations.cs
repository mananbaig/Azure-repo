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

namespace Azure.ResourceManager.Media
{
    internal partial class MediaServicesOperationResultsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of MediaServicesOperationResultsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public MediaServicesOperationResultsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-11-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string locationName, string operationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.Media/locations/", false);
            uri.AppendPath(locationName, true);
            uri.AppendPath("/mediaServicesOperationResults/", false);
            uri.AppendPath(operationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get media service operation result. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MediaServiceData>> GetAsync(string subscriptionId, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var message = CreateGetRequest(subscriptionId, locationName, operationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaServiceData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MediaServiceData.DeserializeMediaServiceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                case 404:
                    return Response.FromValue((MediaServiceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get media service operation result. </summary>
        /// <param name="subscriptionId"> The unique identifier for a Microsoft Azure subscription. </param>
        /// <param name="locationName"> Location name. </param>
        /// <param name="operationId"> Operation Id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MediaServiceData> Get(string subscriptionId, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            using var message = CreateGetRequest(subscriptionId, locationName, operationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MediaServiceData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MediaServiceData.DeserializeMediaServiceData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 202:
                case 404:
                    return Response.FromValue((MediaServiceData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
