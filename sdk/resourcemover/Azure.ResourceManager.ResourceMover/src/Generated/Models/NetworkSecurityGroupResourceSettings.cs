// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ResourceMover;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the NSG resource settings. </summary>
    public partial class NetworkSecurityGroupResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupResourceSettings"/>. </summary>
        public NetworkSecurityGroupResourceSettings()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            SecurityRules = new ChangeTrackingList<NetworkSecurityGroupSecurityRule>();
            ResourceType = "Microsoft.Network/networkSecurityGroups";
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupResourceSettings"/>. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="targetResourceGroupName"> Gets or sets the target resource group name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="securityRules"> Gets or sets Security rules of network security group. </param>
        internal NetworkSecurityGroupResourceSettings(string resourceType, string targetResourceName, string targetResourceGroupName, IDictionary<string, BinaryData> serializedAdditionalRawData, IDictionary<string, string> tags, IList<NetworkSecurityGroupSecurityRule> securityRules) : base(resourceType, targetResourceName, targetResourceGroupName, serializedAdditionalRawData)
        {
            Tags = tags;
            SecurityRules = securityRules;
            ResourceType = resourceType ?? "Microsoft.Network/networkSecurityGroups";
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets Security rules of network security group. </summary>
        public IList<NetworkSecurityGroupSecurityRule> SecurityRules { get; }
    }
}
