// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The result of the Service Fabric runtime versions. </summary>
    public partial class ServiceFabricManagedClusterVersion : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedClusterVersion"/>. </summary>
        internal ServiceFabricManagedClusterVersion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedClusterVersion"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="clusterCodeVersion"> The Service Fabric runtime version of the cluster. </param>
        /// <param name="versionSupportExpireOn"> The date of expiry of support of the version. </param>
        /// <param name="osType"> Cluster operating system, the default will be Windows. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricManagedClusterVersion(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string clusterCodeVersion, DateTimeOffset? versionSupportExpireOn, ServiceFabricManagedClusterOSType? osType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ClusterCodeVersion = clusterCodeVersion;
            VersionSupportExpireOn = versionSupportExpireOn;
            OSType = osType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Service Fabric runtime version of the cluster. </summary>
        public string ClusterCodeVersion { get; }
        /// <summary> The date of expiry of support of the version. </summary>
        public DateTimeOffset? VersionSupportExpireOn { get; }
        /// <summary> Cluster operating system, the default will be Windows. </summary>
        public ServiceFabricManagedClusterOSType? OSType { get; }
    }
}
