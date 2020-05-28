// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Properties of an application rule. </summary>
    public partial class AzureFirewallApplicationRule
    {
        /// <summary> Initializes a new instance of AzureFirewallApplicationRule. </summary>
        public AzureFirewallApplicationRule()
        {
        }

        /// <summary> Initializes a new instance of AzureFirewallApplicationRule. </summary>
        /// <param name="name"> Name of the application rule. </param>
        /// <param name="description"> Description of the rule. </param>
        /// <param name="sourceAddresses"> List of source IP addresses for this rule. </param>
        /// <param name="protocols"> Array of ApplicationRuleProtocols. </param>
        /// <param name="targetFqdns"> List of FQDNs for this rule. </param>
        /// <param name="fqdnTags"> List of FQDN Tags for this rule. </param>
        /// <param name="sourceIpGroups"> List of source IpGroups for this rule. </param>
        internal AzureFirewallApplicationRule(string name, string description, IList<string> sourceAddresses, IList<AzureFirewallApplicationRuleProtocol> protocols, IList<string> targetFqdns, IList<string> fqdnTags, IList<string> sourceIpGroups)
        {
            Name = name;
            Description = description;
            SourceAddresses = sourceAddresses;
            Protocols = protocols;
            TargetFqdns = targetFqdns;
            FqdnTags = fqdnTags;
            SourceIpGroups = sourceIpGroups;
        }

        /// <summary> Name of the application rule. </summary>
        public string Name { get; set; }
        /// <summary> Description of the rule. </summary>
        public string Description { get; set; }
        /// <summary> List of source IP addresses for this rule. </summary>
        public IList<string> SourceAddresses { get; set; }
        /// <summary> Array of ApplicationRuleProtocols. </summary>
        public IList<AzureFirewallApplicationRuleProtocol> Protocols { get; set; }
        /// <summary> List of FQDNs for this rule. </summary>
        public IList<string> TargetFqdns { get; set; }
        /// <summary> List of FQDN Tags for this rule. </summary>
        public IList<string> FqdnTags { get; set; }
        /// <summary> List of source IpGroups for this rule. </summary>
        public IList<string> SourceIpGroups { get; set; }
    }
}
