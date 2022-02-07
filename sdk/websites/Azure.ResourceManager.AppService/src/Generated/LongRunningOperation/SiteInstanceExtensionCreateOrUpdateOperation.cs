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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Invoke the MSDeploy web app extension. </summary>
    public partial class SiteInstanceExtensionCreateOrUpdateOperation : Operation<SiteInstanceExtension>, IOperationSource<SiteInstanceExtension>
    {
        private readonly OperationInternals<SiteInstanceExtension> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SiteInstanceExtensionCreateOrUpdateOperation for mocking. </summary>
        protected SiteInstanceExtensionCreateOrUpdateOperation()
        {
        }

        internal SiteInstanceExtensionCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SiteInstanceExtension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SiteInstanceExtensionCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteInstanceExtension Value => _operation.Value;

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
        public override ValueTask<Response<SiteInstanceExtension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteInstanceExtension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SiteInstanceExtension IOperationSource<SiteInstanceExtension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return new SiteInstanceExtension(_armClient, data);
        }

        async ValueTask<SiteInstanceExtension> IOperationSource<SiteInstanceExtension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return new SiteInstanceExtension(_armClient, data);
        }
    }
}
