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

namespace Azure.ResourceManager.KeyVault
{
    internal class VaultOperationSource : IOperationSource<VaultResource>
    {
        private readonly ArmClient _client;

        internal VaultOperationSource(ArmClient client)
        {
            _client = client;
        }

        VaultResource IOperationSource<VaultResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VaultData.DeserializeVaultData(document.RootElement);
            return new VaultResource(_client, data);
        }

        async ValueTask<VaultResource> IOperationSource<VaultResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VaultData.DeserializeVaultData(document.RootElement);
            return new VaultResource(_client, data);
        }
    }
}
