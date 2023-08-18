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
    internal class HDInsightApplicationOperationSource : Core.IOperationSource<HDInsightApplicationResource>
    {
        private readonly ArmClient _client;

        internal HDInsightApplicationOperationSource(ArmClient client)
        {
            _client = client;
        }

        HDInsightApplicationResource Core.IOperationSource<HDInsightApplicationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HDInsightApplicationData.DeserializeHDInsightApplicationData(document.RootElement);
            return new HDInsightApplicationResource(_client, data);
        }

        async ValueTask<HDInsightApplicationResource> Core.IOperationSource<HDInsightApplicationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HDInsightApplicationData.DeserializeHDInsightApplicationData(document.RootElement);
            return new HDInsightApplicationResource(_client, data);
        }
    }
}
