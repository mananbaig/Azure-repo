// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Results of network security group evaluation. </summary>
    public partial class EvaluatedNetworkSecurityGroup
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EvaluatedNetworkSecurityGroup"/>. </summary>
        internal EvaluatedNetworkSecurityGroup()
        {
            RulesEvaluationResult = new ChangeTrackingList<NetworkSecurityRulesEvaluationResult>();
        }

        /// <summary> Initializes a new instance of <see cref="EvaluatedNetworkSecurityGroup"/>. </summary>
        /// <param name="networkSecurityGroupId"> Network security group ID. </param>
        /// <param name="appliedTo"> Resource ID of nic or subnet to which network security group is applied. </param>
        /// <param name="matchedRule"> Matched network security rule. </param>
        /// <param name="rulesEvaluationResult"> List of network security rules evaluation results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EvaluatedNetworkSecurityGroup(ResourceIdentifier networkSecurityGroupId, string appliedTo, MatchedRule matchedRule, IReadOnlyList<NetworkSecurityRulesEvaluationResult> rulesEvaluationResult, Dictionary<string, BinaryData> rawData)
        {
            NetworkSecurityGroupId = networkSecurityGroupId;
            AppliedTo = appliedTo;
            MatchedRule = matchedRule;
            RulesEvaluationResult = rulesEvaluationResult;
            _rawData = rawData;
        }

        /// <summary> Network security group ID. </summary>
        public ResourceIdentifier NetworkSecurityGroupId { get; }
        /// <summary> Resource ID of nic or subnet to which network security group is applied. </summary>
        public string AppliedTo { get; }
        /// <summary> Matched network security rule. </summary>
        public MatchedRule MatchedRule { get; }
        /// <summary> List of network security rules evaluation results. </summary>
        public IReadOnlyList<NetworkSecurityRulesEvaluationResult> RulesEvaluationResult { get; }
    }
}
