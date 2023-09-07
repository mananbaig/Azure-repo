// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Existing recovery virtual network input. </summary>
    public partial class ExistingRecoveryVirtualNetwork : RecoveryVirtualNetworkCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="ExistingRecoveryVirtualNetwork"/>. </summary>
        /// <param name="recoveryVirtualNetworkId"> The recovery virtual network Id. Will throw error, if resource does not exist. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryVirtualNetworkId"/> is null. </exception>
        public ExistingRecoveryVirtualNetwork(ResourceIdentifier recoveryVirtualNetworkId)
        {
            Argument.AssertNotNull(recoveryVirtualNetworkId, nameof(recoveryVirtualNetworkId));

            RecoveryVirtualNetworkId = recoveryVirtualNetworkId;
            ResourceType = "Existing";
        }

        /// <summary> Initializes a new instance of <see cref="ExistingRecoveryVirtualNetwork"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="recoveryVirtualNetworkId"> The recovery virtual network Id. Will throw error, if resource does not exist. </param>
        /// <param name="recoverySubnetName"> The recovery subnet name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExistingRecoveryVirtualNetwork(string resourceType, ResourceIdentifier recoveryVirtualNetworkId, string recoverySubnetName, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(resourceType, serializedAdditionalRawData)
        {
            RecoveryVirtualNetworkId = recoveryVirtualNetworkId;
            RecoverySubnetName = recoverySubnetName;
            ResourceType = resourceType ?? "Existing";
        }

        /// <summary> Initializes a new instance of <see cref="ExistingRecoveryVirtualNetwork"/> for deserialization. </summary>
        internal ExistingRecoveryVirtualNetwork()
        {
        }

        /// <summary> The recovery virtual network Id. Will throw error, if resource does not exist. </summary>
        public ResourceIdentifier RecoveryVirtualNetworkId { get; set; }
        /// <summary> The recovery subnet name. </summary>
        public string RecoverySubnetName { get; set; }
    }
}
