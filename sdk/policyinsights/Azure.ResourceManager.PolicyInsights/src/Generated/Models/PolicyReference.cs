// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> Resource identifiers for a policy. </summary>
    public partial class PolicyReference
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PolicyReference"/>. </summary>
        internal PolicyReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyReference"/>. </summary>
        /// <param name="policyDefinitionId"> The resource identifier of the policy definition. </param>
        /// <param name="policySetDefinitionId"> The resource identifier of the policy set definition. </param>
        /// <param name="policyDefinitionReferenceId"> The reference identifier of a specific policy definition within a policy set definition. </param>
        /// <param name="policyAssignmentId"> The resource identifier of the policy assignment. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyReference(ResourceIdentifier policyDefinitionId, ResourceIdentifier policySetDefinitionId, string policyDefinitionReferenceId, ResourceIdentifier policyAssignmentId, Dictionary<string, BinaryData> rawData)
        {
            PolicyDefinitionId = policyDefinitionId;
            PolicySetDefinitionId = policySetDefinitionId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            PolicyAssignmentId = policyAssignmentId;
            _rawData = rawData;
        }

        /// <summary> The resource identifier of the policy definition. </summary>
        public ResourceIdentifier PolicyDefinitionId { get; }
        /// <summary> The resource identifier of the policy set definition. </summary>
        public ResourceIdentifier PolicySetDefinitionId { get; }
        /// <summary> The reference identifier of a specific policy definition within a policy set definition. </summary>
        public string PolicyDefinitionReferenceId { get; }
        /// <summary> The resource identifier of the policy assignment. </summary>
        public ResourceIdentifier PolicyAssignmentId { get; }
    }
}
