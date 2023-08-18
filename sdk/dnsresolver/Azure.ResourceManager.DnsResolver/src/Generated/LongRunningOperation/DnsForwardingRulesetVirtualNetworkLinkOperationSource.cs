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

namespace Azure.ResourceManager.DnsResolver
{
    internal class DnsForwardingRulesetVirtualNetworkLinkOperationSource : Core.IOperationSource<DnsForwardingRulesetVirtualNetworkLinkResource>
    {
        private readonly ArmClient _client;

        internal DnsForwardingRulesetVirtualNetworkLinkOperationSource(ArmClient client)
        {
            _client = client;
        }

        DnsForwardingRulesetVirtualNetworkLinkResource Core.IOperationSource<DnsForwardingRulesetVirtualNetworkLinkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DnsForwardingRulesetVirtualNetworkLinkData.DeserializeDnsForwardingRulesetVirtualNetworkLinkData(document.RootElement);
            return new DnsForwardingRulesetVirtualNetworkLinkResource(_client, data);
        }

        async ValueTask<DnsForwardingRulesetVirtualNetworkLinkResource> Core.IOperationSource<DnsForwardingRulesetVirtualNetworkLinkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DnsForwardingRulesetVirtualNetworkLinkData.DeserializeDnsForwardingRulesetVirtualNetworkLinkData(document.RootElement);
            return new DnsForwardingRulesetVirtualNetworkLinkResource(_client, data);
        }
    }
}
