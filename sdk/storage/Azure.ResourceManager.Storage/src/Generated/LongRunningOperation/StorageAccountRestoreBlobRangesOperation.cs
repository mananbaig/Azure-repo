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

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Restore blobs in the specified blob ranges. </summary>
    public partial class StorageAccountRestoreBlobRangesOperation : Operation<BlobRestoreStatus>, IOperationSource<BlobRestoreStatus>
    {
        private readonly OperationInternals<BlobRestoreStatus> _operation;

        /// <summary> Initializes a new instance of StorageAccountRestoreBlobRangesOperation for mocking. </summary>
        protected StorageAccountRestoreBlobRangesOperation()
        {
        }

        internal StorageAccountRestoreBlobRangesOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<BlobRestoreStatus>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "StorageAccountRestoreBlobRangesOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BlobRestoreStatus Value => _operation.Value;

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
        public override ValueTask<Response<BlobRestoreStatus>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BlobRestoreStatus>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        BlobRestoreStatus IOperationSource<BlobRestoreStatus>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return BlobRestoreStatus.DeserializeBlobRestoreStatus(document.RootElement);
        }

        async ValueTask<BlobRestoreStatus> IOperationSource<BlobRestoreStatus>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return BlobRestoreStatus.DeserializeBlobRestoreStatus(document.RootElement);
        }
    }
}
