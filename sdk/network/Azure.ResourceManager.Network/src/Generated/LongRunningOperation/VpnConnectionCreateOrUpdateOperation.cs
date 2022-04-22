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
    /// <summary> Creates a vpn connection to a scalable vpn gateway if it doesn&apos;t exist else updates the existing connection. </summary>
    public partial class VpnConnectionCreateOrUpdateOperation : Operation<VpnConnection>, IOperationSource<VpnConnection>
    {
        private readonly OperationInternals<VpnConnection> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of VpnConnectionCreateOrUpdateOperation for mocking. </summary>
        protected VpnConnectionCreateOrUpdateOperation()
        {
        }

        internal VpnConnectionCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VpnConnection>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VpnConnectionCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VpnConnection Value => _operation.Value;

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
        public override ValueTask<Response<VpnConnection>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnConnection>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VpnConnection IOperationSource<VpnConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VpnConnectionData.DeserializeVpnConnectionData(document.RootElement);
            return new VpnConnection(_armClient, data);
        }

        async ValueTask<VpnConnection> IOperationSource<VpnConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VpnConnectionData.DeserializeVpnConnectionData(document.RootElement);
            return new VpnConnection(_armClient, data);
        }
    }
}
