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
using Azure.ResourceManager.AppService;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Creates or updates a domain. </summary>
    public partial class DomainCreateOrUpdateOperation : Operation<AppServiceDomain>, IOperationSource<AppServiceDomain>
    {
        private readonly OperationInternals<AppServiceDomain> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of DomainCreateOrUpdateOperation for mocking. </summary>
        protected DomainCreateOrUpdateOperation()
        {
        }

        internal DomainCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AppServiceDomain>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DomainCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AppServiceDomain Value => _operation.Value;

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
        public override ValueTask<Response<AppServiceDomain>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AppServiceDomain>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AppServiceDomain IOperationSource<AppServiceDomain>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AppServiceDomainData.DeserializeAppServiceDomainData(document.RootElement);
            return new AppServiceDomain(_operationBase, data);
        }

        async ValueTask<AppServiceDomain> IOperationSource<AppServiceDomain>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AppServiceDomainData.DeserializeAppServiceDomainData(document.RootElement);
            return new AppServiceDomain(_operationBase, data);
        }
    }
}
