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

namespace Azure.ResourceManager.HDInsight
{
    internal class HDInsightPrivateEndpointConnectionOperationSource : Core.IOperationSource<HDInsightPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal HDInsightPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        HDInsightPrivateEndpointConnectionResource Core.IOperationSource<HDInsightPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HDInsightPrivateEndpointConnectionData.DeserializeHDInsightPrivateEndpointConnectionData(document.RootElement);
            return new HDInsightPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<HDInsightPrivateEndpointConnectionResource> Core.IOperationSource<HDInsightPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HDInsightPrivateEndpointConnectionData.DeserializeHDInsightPrivateEndpointConnectionData(document.RootElement);
            return new HDInsightPrivateEndpointConnectionResource(_client, data);
        }
    }
}
