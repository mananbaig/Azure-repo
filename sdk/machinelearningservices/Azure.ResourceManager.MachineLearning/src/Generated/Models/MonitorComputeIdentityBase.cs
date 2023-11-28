// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Monitor compute identity base definition.
    /// Please note <see cref="MonitorComputeIdentityBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AmlTokenComputeIdentity"/> and <see cref="ManagedComputeIdentity"/>.
    /// </summary>
    public abstract partial class MonitorComputeIdentityBase
    {
        /// <summary> Initializes a new instance of <see cref="MonitorComputeIdentityBase"/>. </summary>
        protected MonitorComputeIdentityBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MonitorComputeIdentityBase"/>. </summary>
        /// <param name="computeIdentityType"> [Required] Monitor compute identity type enum. </param>
        internal MonitorComputeIdentityBase(MonitorComputeIdentityType computeIdentityType)
        {
            ComputeIdentityType = computeIdentityType;
        }

        /// <summary> [Required] Monitor compute identity type enum. </summary>
        internal MonitorComputeIdentityType ComputeIdentityType { get; set; }
    }
}
