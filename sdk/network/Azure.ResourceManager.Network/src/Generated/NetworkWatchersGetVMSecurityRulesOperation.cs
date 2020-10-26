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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Gets the configured and effective security group rules on the specified VM. </summary>
    public partial class NetworkWatchersGetVMSecurityRulesOperation : Operation<SecurityGroupViewResult>, IOperationSource<SecurityGroupViewResult>
    {
        private readonly ArmOperationHelpers<SecurityGroupViewResult> _operation;
        internal NetworkWatchersGetVMSecurityRulesOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<SecurityGroupViewResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "NetworkWatchersGetVMSecurityRulesOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SecurityGroupViewResult Value => _operation.Value;

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
        public override ValueTask<Response<SecurityGroupViewResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SecurityGroupViewResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SecurityGroupViewResult IOperationSource<SecurityGroupViewResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return SecurityGroupViewResult.DeserializeSecurityGroupViewResult(document.RootElement);
        }

        async ValueTask<SecurityGroupViewResult> IOperationSource<SecurityGroupViewResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return SecurityGroupViewResult.DeserializeSecurityGroupViewResult(document.RootElement);
        }
    }
}
