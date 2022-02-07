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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Updates an instance pool. </summary>
    public partial class InstancePoolUpdateOperation : Operation<InstancePool>, IOperationSource<InstancePool>
    {
        private readonly OperationInternals<InstancePool> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of InstancePoolUpdateOperation for mocking. </summary>
        protected InstancePoolUpdateOperation()
        {
        }

        internal InstancePoolUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<InstancePool>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "InstancePoolUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override InstancePool Value => _operation.Value;

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
        public override ValueTask<Response<InstancePool>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<InstancePool>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        InstancePool IOperationSource<InstancePool>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = InstancePoolData.DeserializeInstancePoolData(document.RootElement);
            return new InstancePool(_armClient, data);
        }

        async ValueTask<InstancePool> IOperationSource<InstancePool>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = InstancePoolData.DeserializeInstancePoolData(document.RootElement);
            return new InstancePool(_armClient, data);
        }
    }
}
