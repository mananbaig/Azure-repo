// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> Describes a forwarding rule for PATCH operation. </summary>
    public partial class DnsForwardingRulePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRulePatch"/>. </summary>
        public DnsForwardingRulePatch()
        {
            TargetDnsServers = new ChangeTrackingList<TargetDnsServer>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsForwardingRulePatch"/>. </summary>
        /// <param name="targetDnsServers"> DNS servers to forward the DNS query to. </param>
        /// <param name="metadata"> Metadata attached to the forwarding rule. </param>
        /// <param name="dnsForwardingRuleState"> The state of forwarding rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsForwardingRulePatch(IList<TargetDnsServer> targetDnsServers, IDictionary<string, string> metadata, DnsForwardingRuleState? dnsForwardingRuleState, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TargetDnsServers = targetDnsServers;
            Metadata = metadata;
            DnsForwardingRuleState = dnsForwardingRuleState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> DNS servers to forward the DNS query to. </summary>
        public IList<TargetDnsServer> TargetDnsServers { get; }
        /// <summary> Metadata attached to the forwarding rule. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The state of forwarding rule. </summary>
        public DnsForwardingRuleState? DnsForwardingRuleState { get; set; }
    }
}
