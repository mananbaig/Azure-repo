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
    /// <summary> Creates or updates an express route circuit. </summary>
    public partial class ExpressRouteCircuitCreateOrUpdateOperation : Operation<ExpressRouteCircuit>, IOperationSource<ExpressRouteCircuit>
    {
        private readonly OperationInternals<ExpressRouteCircuit> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of ExpressRouteCircuitCreateOrUpdateOperation for mocking. </summary>
        protected ExpressRouteCircuitCreateOrUpdateOperation()
        {
        }

        internal ExpressRouteCircuitCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ExpressRouteCircuit>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "ExpressRouteCircuitCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ExpressRouteCircuit Value => _operation.Value;

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
        public override ValueTask<Response<ExpressRouteCircuit>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExpressRouteCircuit>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ExpressRouteCircuit IOperationSource<ExpressRouteCircuit>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ExpressRouteCircuitData.DeserializeExpressRouteCircuitData(document.RootElement);
            return new ExpressRouteCircuit(_armClient, data);
        }

        async ValueTask<ExpressRouteCircuit> IOperationSource<ExpressRouteCircuit>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ExpressRouteCircuitData.DeserializeExpressRouteCircuitData(document.RootElement);
            return new ExpressRouteCircuit(_armClient, data);
        }
    }
}
