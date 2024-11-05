// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.StorageActions
{
    internal class StorageTaskOperationSource : IOperationSource<StorageTaskResource>
    {
        private readonly ArmClient _client;

        internal StorageTaskOperationSource(ArmClient client)
        {
            _client = client;
        }

        StorageTaskResource IOperationSource<StorageTaskResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = StorageTaskData.DeserializeStorageTaskData(document.RootElement);
            return new StorageTaskResource(_client, data);
        }

        async ValueTask<StorageTaskResource> IOperationSource<StorageTaskResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = StorageTaskData.DeserializeStorageTaskData(document.RootElement);
            return new StorageTaskResource(_client, data);
        }
    }
}
