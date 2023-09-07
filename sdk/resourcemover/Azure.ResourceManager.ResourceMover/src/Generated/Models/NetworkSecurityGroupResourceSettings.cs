// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines the NSG resource settings. </summary>
    public partial class NetworkSecurityGroupResourceSettings : MoverResourceSettings
    {
        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupResourceSettings"/>. </summary>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        public NetworkSecurityGroupResourceSettings(string targetResourceName) : base(targetResourceName)
        {
            Argument.AssertNotNull(targetResourceName, nameof(targetResourceName));

            Tags = new ChangeTrackingDictionary<string, string>();
            SecurityRules = new ChangeTrackingList<NetworkSecurityGroupSecurityRule>();
            ResourceType = "Microsoft.Network/networkSecurityGroups";
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupResourceSettings"/>. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <param name="tags"> Gets or sets the Resource tags. </param>
        /// <param name="securityRules"> Gets or sets Security rules of network security group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityGroupResourceSettings(string resourceType, string targetResourceName, IDictionary<string, string> tags, IList<NetworkSecurityGroupSecurityRule> securityRules, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(resourceType, targetResourceName, serializedAdditionalRawData)
        {
            Tags = tags;
            SecurityRules = securityRules;
            ResourceType = resourceType ?? "Microsoft.Network/networkSecurityGroups";
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupResourceSettings"/> for deserialization. </summary>
        internal NetworkSecurityGroupResourceSettings()
        {
        }

        /// <summary> Gets or sets the Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets Security rules of network security group. </summary>
        public IList<NetworkSecurityGroupSecurityRule> SecurityRules { get; }
    }
}
