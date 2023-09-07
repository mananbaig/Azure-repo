// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The UnknownServicePlacementPolicy. </summary>
    internal partial class UnknownServicePlacementPolicy : ManagedServicePlacementPolicy
    {
        /// <summary> Initializes a new instance of <see cref="UnknownServicePlacementPolicy"/>. </summary>
        /// <param name="servicePlacementPolicyType"> The type of placement policy for a service fabric service. Following are the possible values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownServicePlacementPolicy(ServicePlacementPolicyType servicePlacementPolicyType, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(servicePlacementPolicyType, serializedAdditionalRawData)
        {
            ServicePlacementPolicyType = servicePlacementPolicyType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownServicePlacementPolicy"/> for deserialization. </summary>
        internal UnknownServicePlacementPolicy()
        {
        }
    }
}
