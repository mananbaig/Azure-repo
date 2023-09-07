// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Model class for event details of a HyperVReplica E2A event. </summary>
    public partial class HyperVReplicaAzureEventDetails : SiteRecoveryEventProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureEventDetails"/>. </summary>
        internal HyperVReplicaAzureEventDetails()
        {
            InstanceType = "HyperVReplicaAzure";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureEventDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="containerName"> The container friendly name. </param>
        /// <param name="fabricName"> The fabric friendly name. </param>
        /// <param name="remoteContainerName"> The remote container name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HyperVReplicaAzureEventDetails(string instanceType, string containerName, string fabricName, string remoteContainerName, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            ContainerName = containerName;
            FabricName = fabricName;
            RemoteContainerName = remoteContainerName;
            InstanceType = instanceType ?? "HyperVReplicaAzure";
        }

        /// <summary> The container friendly name. </summary>
        public string ContainerName { get; }
        /// <summary> The fabric friendly name. </summary>
        public string FabricName { get; }
        /// <summary> The remote container name. </summary>
        public string RemoteContainerName { get; }
    }
}
