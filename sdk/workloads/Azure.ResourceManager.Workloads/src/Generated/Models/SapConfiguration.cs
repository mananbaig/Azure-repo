// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// The SAP Configuration.
    /// Please note <see cref="SapConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DeploymentConfiguration"/>, <see cref="DeploymentWithOSConfiguration"/> and <see cref="DiscoveryConfiguration"/>.
    /// </summary>
    public abstract partial class SapConfiguration
    {
        /// <summary> Initializes a new instance of SapConfiguration. </summary>
        protected SapConfiguration()
        {
        }

        /// <summary> Initializes a new instance of SapConfiguration. </summary>
        /// <param name="configurationType"> The configuration Type. </param>
        internal SapConfiguration(SapConfigurationType configurationType)
        {
            ConfigurationType = configurationType;
        }

        /// <summary> The configuration Type. </summary>
        internal SapConfigurationType ConfigurationType { get; set; }
    }
}
