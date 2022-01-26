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
using Azure.ResourceManager;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Updates the specified private endpoint connection on application gateway. </summary>
    public partial class ApplicationGatewayPrivateEndpointConnectionCreateOrUpdateOperation : Operation<ApplicationGatewayPrivateEndpointConnection>, IOperationSource<ApplicationGatewayPrivateEndpointConnection>
    {
        private readonly OperationInternals<ApplicationGatewayPrivateEndpointConnection> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of ApplicationGatewayPrivateEndpointConnectionCreateOrUpdateOperation for mocking. </summary>
        protected ApplicationGatewayPrivateEndpointConnectionCreateOrUpdateOperation()
        {
        }

        internal ApplicationGatewayPrivateEndpointConnectionCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ApplicationGatewayPrivateEndpointConnection>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "ApplicationGatewayPrivateEndpointConnectionCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ApplicationGatewayPrivateEndpointConnection Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ApplicationGatewayPrivateEndpointConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ApplicationGatewayPrivateEndpointConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ApplicationGatewayPrivateEndpointConnection IOperationSource<ApplicationGatewayPrivateEndpointConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApplicationGatewayPrivateEndpointConnectionData.DeserializeApplicationGatewayPrivateEndpointConnectionData(document.RootElement);
            return new ApplicationGatewayPrivateEndpointConnection(_armClient, data);
        }

        async ValueTask<ApplicationGatewayPrivateEndpointConnection> IOperationSource<ApplicationGatewayPrivateEndpointConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApplicationGatewayPrivateEndpointConnectionData.DeserializeApplicationGatewayPrivateEndpointConnectionData(document.RootElement);
            return new ApplicationGatewayPrivateEndpointConnection(_armClient, data);
        }
    }
}
