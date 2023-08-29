// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A list of firewall rules. </summary>
    internal partial class PostgreSqlFlexibleServerFirewallRuleListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerFirewallRuleListResult"/>. </summary>
        internal PostgreSqlFlexibleServerFirewallRuleListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlFlexibleServerFirewallRuleData>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerFirewallRuleListResult"/>. </summary>
        /// <param name="value"> The list of firewall rules in a server. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerFirewallRuleListResult(IReadOnlyList<PostgreSqlFlexibleServerFirewallRuleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of firewall rules in a server. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerFirewallRuleData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
