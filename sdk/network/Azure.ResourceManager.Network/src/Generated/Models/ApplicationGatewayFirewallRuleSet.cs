// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A web application firewall rule set. </summary>
    public partial class ApplicationGatewayFirewallRuleSet : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallRuleSet"/>. </summary>
        public ApplicationGatewayFirewallRuleSet()
        {
            RuleGroups = new ChangeTrackingList<ApplicationGatewayFirewallRuleGroup>();
            Tiers = new ChangeTrackingList<ApplicationGatewayTierType>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayFirewallRuleSet"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="provisioningState"> The provisioning state of the web application firewall rule set. </param>
        /// <param name="ruleSetType"> The type of the web application firewall rule set. </param>
        /// <param name="ruleSetVersion"> The version of the web application firewall rule set type. </param>
        /// <param name="ruleGroups"> The rule groups of the web application firewall rule set. </param>
        /// <param name="tiers"> Tier of an application gateway that support the rule set. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayFirewallRuleSet(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, NetworkProvisioningState? provisioningState, string ruleSetType, string ruleSetVersion, IList<ApplicationGatewayFirewallRuleGroup> ruleGroups, IList<ApplicationGatewayTierType> tiers, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, location, tags, rawData)
        {
            ProvisioningState = provisioningState;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            RuleGroups = ruleGroups;
            Tiers = tiers;
        }

        /// <summary> The provisioning state of the web application firewall rule set. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The type of the web application firewall rule set. </summary>
        public string RuleSetType { get; set; }
        /// <summary> The version of the web application firewall rule set type. </summary>
        public string RuleSetVersion { get; set; }
        /// <summary> The rule groups of the web application firewall rule set. </summary>
        public IList<ApplicationGatewayFirewallRuleGroup> RuleGroups { get; }
        /// <summary> Tier of an application gateway that support the rule set. </summary>
        public IList<ApplicationGatewayTierType> Tiers { get; }
    }
}
