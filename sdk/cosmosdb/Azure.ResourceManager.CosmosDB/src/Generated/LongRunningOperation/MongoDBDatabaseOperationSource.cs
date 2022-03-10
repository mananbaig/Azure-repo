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
    internal class MongoDBDatabaseOperationSource : IOperationSource<MongoDBDatabase>
    {
        private readonly ArmClient _client;

        internal MongoDBDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        MongoDBDatabase IOperationSource<MongoDBDatabase>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MongoDBDatabaseData.DeserializeMongoDBDatabaseData(document.RootElement);
            return new MongoDBDatabase(_client, data);
        }

        async ValueTask<MongoDBDatabase> IOperationSource<MongoDBDatabase>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MongoDBDatabaseData.DeserializeMongoDBDatabaseData(document.RootElement);
            return new MongoDBDatabase(_client, data);
        }
    }
}
