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

namespace Azure.ResourceManager.Network
{
    internal class ExpressRouteCircuitAuthorizationOperationSource : IOperationSource<ExpressRouteCircuitAuthorization>
    {
        private readonly ArmClient _client;

        internal ExpressRouteCircuitAuthorizationOperationSource(ArmClient client)
        {
            _client = client;
        }

        ExpressRouteCircuitAuthorization IOperationSource<ExpressRouteCircuitAuthorization>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ExpressRouteCircuitAuthorizationData.DeserializeExpressRouteCircuitAuthorizationData(document.RootElement);
            return new ExpressRouteCircuitAuthorization(_client, data);
        }

        async ValueTask<ExpressRouteCircuitAuthorization> IOperationSource<ExpressRouteCircuitAuthorization>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ExpressRouteCircuitAuthorizationData.DeserializeExpressRouteCircuitAuthorizationData(document.RootElement);
            return new ExpressRouteCircuitAuthorization(_client, data);
        }
    }
}
