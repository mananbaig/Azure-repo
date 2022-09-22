// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary>
    /// The target service properties
    /// Please note <see cref="TargetServiceBaseInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureResourceInfo"/>, <see cref="ConfluentBootstrapServerInfo"/> and <see cref="ConfluentSchemaRegistryInfo"/>.
    /// </summary>
    public abstract partial class TargetServiceBaseInfo
    {
        /// <summary> Initializes a new instance of TargetServiceBaseInfo. </summary>
        protected TargetServiceBaseInfo()
        {
        }

        /// <summary> Initializes a new instance of TargetServiceBaseInfo. </summary>
        /// <param name="targetServiceType"> The target service type. </param>
        internal TargetServiceBaseInfo(TargetServiceType targetServiceType)
        {
            TargetServiceType = targetServiceType;
        }

        /// <summary> The target service type. </summary>
        internal TargetServiceType TargetServiceType { get; set; }
    }
}
