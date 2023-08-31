// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The content trust policy for a container registry. </summary>
    public partial class ContainerRegistryTrustPolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTrustPolicy"/>. </summary>
        public ContainerRegistryTrustPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryTrustPolicy"/>. </summary>
        /// <param name="policyType"> The type of trust policy. </param>
        /// <param name="status"> The value that indicates whether the policy is enabled or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryTrustPolicy(ContainerRegistryTrustPolicyType? policyType, ContainerRegistryPolicyStatus? status, Dictionary<string, BinaryData> rawData)
        {
            PolicyType = policyType;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> The type of trust policy. </summary>
        public ContainerRegistryTrustPolicyType? PolicyType { get; set; }
        /// <summary> The value that indicates whether the policy is enabled or not. </summary>
        public ContainerRegistryPolicyStatus? Status { get; set; }
    }
}
