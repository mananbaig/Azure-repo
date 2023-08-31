// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to update a firewall rule.
    /// Serialized Name: UpdateFirewallRuleParameters
    /// </summary>
    public partial class DataLakeAnalyticsFirewallRulePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsFirewallRulePatch"/>. </summary>
        public DataLakeAnalyticsFirewallRulePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsFirewallRulePatch"/>. </summary>
        /// <param name="startIPAddress">
        /// The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// Serialized Name: UpdateFirewallRuleParameters.properties.startIpAddress
        /// </param>
        /// <param name="endIPAddress">
        /// The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// Serialized Name: UpdateFirewallRuleParameters.properties.endIpAddress
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeAnalyticsFirewallRulePatch(IPAddress startIPAddress, IPAddress endIPAddress, Dictionary<string, BinaryData> rawData)
        {
            StartIPAddress = startIPAddress;
            EndIPAddress = endIPAddress;
            _rawData = rawData;
        }

        /// <summary>
        /// The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// Serialized Name: UpdateFirewallRuleParameters.properties.startIpAddress
        /// </summary>
        public IPAddress StartIPAddress { get; set; }
        /// <summary>
        /// The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// Serialized Name: UpdateFirewallRuleParameters.properties.endIpAddress
        /// </summary>
        public IPAddress EndIPAddress { get; set; }
    }
}
