// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The AdaptiveNetworkHardeningEnforceContent. </summary>
    public partial class AdaptiveNetworkHardeningEnforceContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AdaptiveNetworkHardeningEnforceContent"/>. </summary>
        /// <param name="rules"> The rules to enforce. </param>
        /// <param name="networkSecurityGroups"> The Azure resource IDs of the effective network security groups that will be updated with the created security rules from the Adaptive Network Hardening rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rules"/> or <paramref name="networkSecurityGroups"/> is null. </exception>
        public AdaptiveNetworkHardeningEnforceContent(IEnumerable<RecommendedSecurityRule> rules, IEnumerable<string> networkSecurityGroups)
        {
            Argument.AssertNotNull(rules, nameof(rules));
            Argument.AssertNotNull(networkSecurityGroups, nameof(networkSecurityGroups));

            Rules = rules.ToList();
            NetworkSecurityGroups = networkSecurityGroups.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AdaptiveNetworkHardeningEnforceContent"/>. </summary>
        /// <param name="rules"> The rules to enforce. </param>
        /// <param name="networkSecurityGroups"> The Azure resource IDs of the effective network security groups that will be updated with the created security rules from the Adaptive Network Hardening rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdaptiveNetworkHardeningEnforceContent(IList<RecommendedSecurityRule> rules, IList<string> networkSecurityGroups, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Rules = rules;
            NetworkSecurityGroups = networkSecurityGroups;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AdaptiveNetworkHardeningEnforceContent"/> for deserialization. </summary>
        internal AdaptiveNetworkHardeningEnforceContent()
        {
        }

        /// <summary> The rules to enforce. </summary>
        public IList<RecommendedSecurityRule> Rules { get; }
        /// <summary> The Azure resource IDs of the effective network security groups that will be updated with the created security rules from the Adaptive Network Hardening rules. </summary>
        public IList<string> NetworkSecurityGroups { get; }
    }
}
