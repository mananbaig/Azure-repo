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

namespace Azure.ResourceManager.CosmosDB
{
    internal class CosmosDBServiceResourceOperationSource : IOperationSource<CosmosDBServiceResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBServiceResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBServiceResource IOperationSource<CosmosDBServiceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CosmosDBServiceResourceData.DeserializeCosmosDBServiceResourceData(document.RootElement);
            return new CosmosDBServiceResource(_client, data);
        }

        async ValueTask<CosmosDBServiceResource> IOperationSource<CosmosDBServiceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CosmosDBServiceResourceData.DeserializeCosmosDBServiceResourceData(document.RootElement);
            return new CosmosDBServiceResource(_client, data);
        }
    }
}
