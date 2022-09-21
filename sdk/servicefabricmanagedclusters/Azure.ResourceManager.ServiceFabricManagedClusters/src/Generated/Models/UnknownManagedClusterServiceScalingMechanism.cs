// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The UnknownManagedClusterServiceScalingMechanism. </summary>
    internal partial class UnknownManagedClusterServiceScalingMechanism : ManagedClusterServiceScalingMechanism
    {
        /// <summary> Initializes a new instance of UnknownManagedClusterServiceScalingMechanism. </summary>
        /// <param name="kind"> Specifies the mechanism associated with this scaling policy. </param>
        internal UnknownManagedClusterServiceScalingMechanism(ServiceScalingMechanismKind kind) : base(kind)
        {
            Kind = kind;
        }
    }
}
