// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The UnknownEffectiveBaseSecurityAdminRule. </summary>
    internal partial class UnknownEffectiveBaseSecurityAdminRule : EffectiveBaseSecurityAdminRule
    {
        /// <summary> Initializes a new instance of <see cref="UnknownEffectiveBaseSecurityAdminRule"/>. </summary>
        /// <param name="resourceId"> Resource ID. </param>
        /// <param name="configurationDescription"> A description of the security admin configuration. </param>
        /// <param name="ruleCollectionDescription"> A description of the rule collection. </param>
        /// <param name="ruleCollectionAppliesToGroups"> Groups for rule collection. </param>
        /// <param name="ruleGroups"> Effective configuration groups. </param>
        /// <param name="kind"> Whether the rule is custom or default. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownEffectiveBaseSecurityAdminRule(ResourceIdentifier resourceId, string configurationDescription, string ruleCollectionDescription, IReadOnlyList<NetworkManagerSecurityGroupItem> ruleCollectionAppliesToGroups, IReadOnlyList<NetworkConfigurationGroup> ruleGroups, EffectiveAdminRuleKind kind, Dictionary<string, BinaryData> rawData) : base(resourceId, configurationDescription, ruleCollectionDescription, ruleCollectionAppliesToGroups, ruleGroups, kind, rawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownEffectiveBaseSecurityAdminRule"/> for deserialization. </summary>
        internal UnknownEffectiveBaseSecurityAdminRule()
        {
        }
    }
}
