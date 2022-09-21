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

namespace Azure.ResourceManager.AppService
{
    internal class FunctionEnvelopeOperationSource : IOperationSource<FunctionEnvelopeResource>
    {
        private readonly ArmClient _client;

        internal FunctionEnvelopeOperationSource(ArmClient client)
        {
            _client = client;
        }

        FunctionEnvelopeResource IOperationSource<FunctionEnvelopeResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FunctionEnvelopeData.DeserializeFunctionEnvelopeData(document.RootElement);
            return FunctionEnvelopeResource.GetResource(_client, data);
        }

        async ValueTask<FunctionEnvelopeResource> IOperationSource<FunctionEnvelopeResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FunctionEnvelopeData.DeserializeFunctionEnvelopeData(document.RootElement);
            return FunctionEnvelopeResource.GetResource(_client, data);
        }
    }
}
