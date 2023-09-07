// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Protectable Container Class.
    /// Please note <see cref="ProtectableContainer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="StorageProtectableContainer"/> and <see cref="VmAppContainerProtectableContainer"/>.
    /// </summary>
    [DeserializationProxy(typeof(UnknownProtectableContainer))]
    public abstract partial class ProtectableContainer
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ProtectableContainer"/>. </summary>
        protected ProtectableContainer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProtectableContainer"/>. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="protectableContainerType">
        /// Type of the container. The value of this property for
        /// 1. Compute Azure VM is Microsoft.Compute/virtualMachines
        /// 2. Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines
        /// </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerId"> Fabric Id of the container such as ARM Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProtectableContainer(string friendlyName, BackupManagementType? backupManagementType, ProtectableContainerType protectableContainerType, string healthStatus, string containerId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FriendlyName = friendlyName;
            BackupManagementType = backupManagementType;
            ProtectableContainerType = protectableContainerType;
            HealthStatus = healthStatus;
            ContainerId = containerId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Friendly name of the container. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Type of backup management for the container. </summary>
        public BackupManagementType? BackupManagementType { get; set; }
        /// <summary>
        /// Type of the container. The value of this property for
        /// 1. Compute Azure VM is Microsoft.Compute/virtualMachines
        /// 2. Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines
        /// </summary>
        internal ProtectableContainerType ProtectableContainerType { get; set; }
        /// <summary> Status of health of the container. </summary>
        public string HealthStatus { get; set; }
        /// <summary> Fabric Id of the container such as ARM Id. </summary>
        public string ContainerId { get; set; }
    }
}
