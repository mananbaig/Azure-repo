// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    internal class MSDeployStatusOperationSource : IOperationSource<MSDeployStatusResource>
    {
        private readonly ArmClient _client;

        internal MSDeployStatusOperationSource(ArmClient client)
        {
            _client = client;
        }

        MSDeployStatusResource IOperationSource<MSDeployStatusResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return MSDeployStatusResource.GetResource(_client, data);
        }

        async ValueTask<MSDeployStatusResource> IOperationSource<MSDeployStatusResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MSDeployStatusData.DeserializeMSDeployStatusData(document.RootElement);
            return MSDeployStatusResource.GetResource(_client, data);
        }
    }
}
