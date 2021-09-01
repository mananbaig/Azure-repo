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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Create or update a gallery image version. </summary>
    public partial class GalleryImageVersionCreateOrUpdateOperation : Operation<GalleryImageVersion>, IOperationSource<GalleryImageVersion>
    {
        private readonly OperationInternals<GalleryImageVersion> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of GalleryImageVersionCreateOrUpdateOperation for mocking. </summary>
        protected GalleryImageVersionCreateOrUpdateOperation()
        {
        }

        internal GalleryImageVersionCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<GalleryImageVersion>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "GalleryImageVersionCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override GalleryImageVersion Value => _operation.Value;

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
        public override ValueTask<Response<GalleryImageVersion>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<GalleryImageVersion>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        GalleryImageVersion IOperationSource<GalleryImageVersion>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new GalleryImageVersion(_operationBase, GalleryImageVersionData.DeserializeGalleryImageVersionData(document.RootElement));
        }

        async ValueTask<GalleryImageVersion> IOperationSource<GalleryImageVersion>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new GalleryImageVersion(_operationBase, GalleryImageVersionData.DeserializeGalleryImageVersionData(document.RootElement));
        }
    }
}
