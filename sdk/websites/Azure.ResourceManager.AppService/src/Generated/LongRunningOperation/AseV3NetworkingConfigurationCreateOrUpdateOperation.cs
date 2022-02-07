// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Update networking configuration of an App Service Environment. </summary>
    public partial class AseV3NetworkingConfigurationCreateOrUpdateOperation : Operation<AseV3NetworkingConfiguration>
    {
        private readonly OperationOrResponseInternals<AseV3NetworkingConfiguration> _operation;

        /// <summary> Initializes a new instance of AseV3NetworkingConfigurationCreateOrUpdateOperation for mocking. </summary>
        protected AseV3NetworkingConfigurationCreateOrUpdateOperation()
        {
        }

        internal AseV3NetworkingConfigurationCreateOrUpdateOperation(ArmClient armClient, Response<AseV3NetworkingConfigurationData> response)
        {
            _operation = new OperationOrResponseInternals<AseV3NetworkingConfiguration>(Response.FromValue(new AseV3NetworkingConfiguration(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AseV3NetworkingConfiguration Value => _operation.Value;

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
        public override ValueTask<Response<AseV3NetworkingConfiguration>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AseV3NetworkingConfiguration>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
