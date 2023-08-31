// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Allow to exclude some variable satisfy the condition for the WAF check. </summary>
    public partial class ManagedRulesDefinition
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedRulesDefinition"/>. </summary>
        /// <param name="managedRuleSets"> The managed rule sets that are associated with the policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedRuleSets"/> is null. </exception>
        public ManagedRulesDefinition(IEnumerable<ManagedRuleSet> managedRuleSets)
        {
            Argument.AssertNotNull(managedRuleSets, nameof(managedRuleSets));

            Exclusions = new ChangeTrackingList<OwaspCrsExclusionEntry>();
            ManagedRuleSets = managedRuleSets.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRulesDefinition"/>. </summary>
        /// <param name="exclusions"> The Exclusions that are applied on the policy. </param>
        /// <param name="managedRuleSets"> The managed rule sets that are associated with the policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedRulesDefinition(IList<OwaspCrsExclusionEntry> exclusions, IList<ManagedRuleSet> managedRuleSets, Dictionary<string, BinaryData> rawData)
        {
            Exclusions = exclusions;
            ManagedRuleSets = managedRuleSets;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedRulesDefinition"/> for deserialization. </summary>
        internal ManagedRulesDefinition()
        {
        }

        /// <summary> The Exclusions that are applied on the policy. </summary>
        public IList<OwaspCrsExclusionEntry> Exclusions { get; }
        /// <summary> The managed rule sets that are associated with the policy. </summary>
        public IList<ManagedRuleSet> ManagedRuleSets { get; }
    }
}
