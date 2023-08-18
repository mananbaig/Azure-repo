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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    internal class NetworkFabricInternalNetworkOperationSource : Core.IOperationSource<NetworkFabricInternalNetworkResource>
    {
        private readonly ArmClient _client;

        internal NetworkFabricInternalNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkFabricInternalNetworkResource Core.IOperationSource<NetworkFabricInternalNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkFabricInternalNetworkData.DeserializeNetworkFabricInternalNetworkData(document.RootElement);
            return new NetworkFabricInternalNetworkResource(_client, data);
        }

        async ValueTask<NetworkFabricInternalNetworkResource> Core.IOperationSource<NetworkFabricInternalNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkFabricInternalNetworkData.DeserializeNetworkFabricInternalNetworkData(document.RootElement);
            return new NetworkFabricInternalNetworkResource(_client, data);
        }
    }
}
