// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> managed cluster properties for snapshot, these properties are read only. </summary>
    public partial class ManagedClusterPropertiesForSnapshot
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPropertiesForSnapshot"/>. </summary>
        internal ManagedClusterPropertiesForSnapshot()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterPropertiesForSnapshot"/>. </summary>
        /// <param name="kubernetesVersion"> The current kubernetes version. </param>
        /// <param name="sku"> The current managed cluster sku. </param>
        /// <param name="enableRbac"> Whether the cluster has enabled Kubernetes Role-Based Access Control or not. </param>
        /// <param name="networkProfile"> The current network profile. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterPropertiesForSnapshot(string kubernetesVersion, ManagedClusterSku sku, bool? enableRbac, ContainerServiceNetworkProfileForSnapshot networkProfile, Dictionary<string, BinaryData> rawData)
        {
            KubernetesVersion = kubernetesVersion;
            Sku = sku;
            EnableRbac = enableRbac;
            NetworkProfile = networkProfile;
            _rawData = rawData;
        }

        /// <summary> The current kubernetes version. </summary>
        public string KubernetesVersion { get; }
        /// <summary> The current managed cluster sku. </summary>
        public ManagedClusterSku Sku { get; }
        /// <summary> Whether the cluster has enabled Kubernetes Role-Based Access Control or not. </summary>
        public bool? EnableRbac { get; }
        /// <summary> The current network profile. </summary>
        public ContainerServiceNetworkProfileForSnapshot NetworkProfile { get; }
    }
}
