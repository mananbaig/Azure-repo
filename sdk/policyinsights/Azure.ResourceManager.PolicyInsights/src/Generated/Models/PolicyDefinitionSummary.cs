// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Policy definition summary. </summary>
    public partial class PolicyDefinitionSummary
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PolicyDefinitionSummary"/>. </summary>
        internal PolicyDefinitionSummary()
        {
            PolicyDefinitionGroupNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PolicyDefinitionSummary"/>. </summary>
        /// <param name="policyDefinitionId"> Policy definition ID. </param>
        /// <param name="policyDefinitionReferenceId"> Policy definition reference ID. </param>
        /// <param name="policyDefinitionGroupNames"> Policy definition group names. </param>
        /// <param name="effect"> Policy effect, i.e. policy definition action. </param>
        /// <param name="results"> Compliance summary for the policy definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyDefinitionSummary(ResourceIdentifier policyDefinitionId, string policyDefinitionReferenceId, IReadOnlyList<string> policyDefinitionGroupNames, string effect, PolicySummaryResults results, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyDefinitionId = policyDefinitionId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            PolicyDefinitionGroupNames = policyDefinitionGroupNames;
            Effect = effect;
            Results = results;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Policy definition ID. </summary>
        public ResourceIdentifier PolicyDefinitionId { get; }
        /// <summary> Policy definition reference ID. </summary>
        public string PolicyDefinitionReferenceId { get; }
        /// <summary> Policy definition group names. </summary>
        public IReadOnlyList<string> PolicyDefinitionGroupNames { get; }
        /// <summary> Policy effect, i.e. policy definition action. </summary>
        public string Effect { get; }
        /// <summary> Compliance summary for the policy definition. </summary>
        public PolicySummaryResults Results { get; }
    }
}
