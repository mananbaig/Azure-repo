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
    internal class CassandraDataCenterOperationSource : IOperationSource<CassandraDataCenterResource>
    {
        private readonly ArmClient _client;

        internal CassandraDataCenterOperationSource(ArmClient client)
        {
            _client = client;
        }

        CassandraDataCenterResource IOperationSource<CassandraDataCenterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CassandraDataCenterData.DeserializeCassandraDataCenterData(document.RootElement);
            return new CassandraDataCenterResource(_client, data);
        }

        async ValueTask<CassandraDataCenterResource> IOperationSource<CassandraDataCenterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CassandraDataCenterData.DeserializeCassandraDataCenterData(document.RootElement);
            return new CassandraDataCenterResource(_client, data);
        }
    }
}
