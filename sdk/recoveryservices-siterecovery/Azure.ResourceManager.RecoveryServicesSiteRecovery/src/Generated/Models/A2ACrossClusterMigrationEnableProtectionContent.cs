// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A Cross-Cluster Migration enable protection input. </summary>
    public partial class A2ACrossClusterMigrationEnableProtectionContent : EnableProtectionProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="A2ACrossClusterMigrationEnableProtectionContent"/>. </summary>
        public A2ACrossClusterMigrationEnableProtectionContent()
        {
            InstanceType = "A2ACrossClusterMigration";
        }

        /// <summary> Initializes a new instance of <see cref="A2ACrossClusterMigrationEnableProtectionContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="fabricObjectId"> The fabric specific object Id of the virtual machine. </param>
        /// <param name="recoveryContainerId"> The recovery container Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal A2ACrossClusterMigrationEnableProtectionContent(string instanceType, ResourceIdentifier fabricObjectId, ResourceIdentifier recoveryContainerId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            FabricObjectId = fabricObjectId;
            RecoveryContainerId = recoveryContainerId;
            InstanceType = instanceType ?? "A2ACrossClusterMigration";
        }

        /// <summary> The fabric specific object Id of the virtual machine. </summary>
        public ResourceIdentifier FabricObjectId { get; set; }
        /// <summary> The recovery container Id. </summary>
        public ResourceIdentifier RecoveryContainerId { get; set; }
    }
}
