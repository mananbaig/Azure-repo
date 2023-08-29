// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Managed service identity (User assigned identity). </summary>
    public partial class MobileNetworkManagedServiceIdentity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkManagedServiceIdentity"/>. </summary>
        /// <param name="identityType"> Type of managed service identity (currently only UserAssigned allowed). </param>
        public MobileNetworkManagedServiceIdentity(MobileNetworkManagedServiceIdentityType identityType)
        {
            IdentityType = identityType;
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkManagedServiceIdentity"/>. </summary>
        /// <param name="identityType"> Type of managed service identity (currently only UserAssigned allowed). </param>
        /// <param name="userAssignedIdentities"> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkManagedServiceIdentity(MobileNetworkManagedServiceIdentityType identityType, IDictionary<string, UserAssignedIdentity> userAssignedIdentities, Dictionary<string, BinaryData> rawData)
        {
            IdentityType = identityType;
            UserAssignedIdentities = userAssignedIdentities;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkManagedServiceIdentity"/> for deserialization. </summary>
        internal MobileNetworkManagedServiceIdentity()
        {
        }

        /// <summary> Type of managed service identity (currently only UserAssigned allowed). </summary>
        public MobileNetworkManagedServiceIdentityType IdentityType { get; set; }
        /// <summary> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </summary>
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
