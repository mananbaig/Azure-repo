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

namespace Azure.ResourceManager.IoTHub
{
    internal class IoTHubPrivateEndpointConnectionOperationSource : IOperationSource<IoTHubPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal IoTHubPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        IoTHubPrivateEndpointConnectionResource IOperationSource<IoTHubPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IoTHubPrivateEndpointConnectionData.DeserializeIoTHubPrivateEndpointConnectionData(document.RootElement);
            return new IoTHubPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<IoTHubPrivateEndpointConnectionResource> IOperationSource<IoTHubPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IoTHubPrivateEndpointConnectionData.DeserializeIoTHubPrivateEndpointConnectionData(document.RootElement);
            return new IoTHubPrivateEndpointConnectionResource(_client, data);
        }
    }
}
