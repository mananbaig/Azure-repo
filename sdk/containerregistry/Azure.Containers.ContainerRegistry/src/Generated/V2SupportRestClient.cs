// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class V2SupportRestClient
    {
        private string url;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of V2SupportRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="url"/> is null. </exception>
        public V2SupportRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            if (url == null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            this.url = url;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCheckRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(url, false);
            uri.AppendPath("/v2/", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Tells whether this Docker Registry instance supports Docker Registry HTTP API v2. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> CheckAsync(CancellationToken cancellationToken = default)
        {
            using var message = CreateCheckRequest();
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Tells whether this Docker Registry instance supports Docker Registry HTTP API v2. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Check(CancellationToken cancellationToken = default)
        {
            using var message = CreateCheckRequest();
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
