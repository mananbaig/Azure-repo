// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A provider specific settings. </summary>
    public partial class A2ACrossClusterMigrationReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of <see cref="A2ACrossClusterMigrationReplicationDetails"/>. </summary>
        internal A2ACrossClusterMigrationReplicationDetails()
        {
            InstanceType = "A2ACrossClusterMigration";
        }

        /// <summary> Initializes a new instance of <see cref="A2ACrossClusterMigrationReplicationDetails"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="fabricObjectId"> The fabric specific object Id of the virtual machine. </param>
        /// <param name="primaryFabricLocation"> Primary fabric location. </param>
        /// <param name="osType"> The type of operating system. </param>
        /// <param name="vmProtectionState"> The protection state for the vm. </param>
        /// <param name="vmProtectionStateDescription"> The protection state description for the vm. </param>
        /// <param name="lifecycleId"> An id associated with the PE that survives actions like switch protection which change the backing PE/CPE objects internally.The lifecycle id gets carried forward to have a link/continuity in being able to have an Id that denotes the "same" protected item even though other internal Ids/ARM Id might be changing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal A2ACrossClusterMigrationReplicationDetails(string instanceType, ResourceIdentifier fabricObjectId, AzureLocation? primaryFabricLocation, string osType, string vmProtectionState, string vmProtectionStateDescription, string lifecycleId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            FabricObjectId = fabricObjectId;
            PrimaryFabricLocation = primaryFabricLocation;
            OSType = osType;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            LifecycleId = lifecycleId;
            InstanceType = instanceType ?? "A2ACrossClusterMigration";
        }

        /// <summary> The fabric specific object Id of the virtual machine. </summary>
        public ResourceIdentifier FabricObjectId { get; }
        /// <summary> Primary fabric location. </summary>
        public AzureLocation? PrimaryFabricLocation { get; }
        /// <summary> The type of operating system. </summary>
        public string OSType { get; }
        /// <summary> The protection state for the vm. </summary>
        public string VmProtectionState { get; }
        /// <summary> The protection state description for the vm. </summary>
        public string VmProtectionStateDescription { get; }
        /// <summary> An id associated with the PE that survives actions like switch protection which change the backing PE/CPE objects internally.The lifecycle id gets carried forward to have a link/continuity in being able to have an Id that denotes the "same" protected item even though other internal Ids/ARM Id might be changing. </summary>
        public string LifecycleId { get; }
    }
}
