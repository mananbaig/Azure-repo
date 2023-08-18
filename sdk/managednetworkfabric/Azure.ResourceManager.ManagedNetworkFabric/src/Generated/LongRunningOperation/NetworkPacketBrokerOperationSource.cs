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
    internal class NetworkPacketBrokerOperationSource : Core.IOperationSource<NetworkPacketBrokerResource>
    {
        private readonly ArmClient _client;

        internal NetworkPacketBrokerOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkPacketBrokerResource Core.IOperationSource<NetworkPacketBrokerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkPacketBrokerData.DeserializeNetworkPacketBrokerData(document.RootElement);
            return new NetworkPacketBrokerResource(_client, data);
        }

        async ValueTask<NetworkPacketBrokerResource> Core.IOperationSource<NetworkPacketBrokerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkPacketBrokerData.DeserializeNetworkPacketBrokerData(document.RootElement);
            return new NetworkPacketBrokerResource(_client, data);
        }
    }
}
