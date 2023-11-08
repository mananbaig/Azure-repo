// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> IaaS VM workload-specific backup item representing an Azure Resource Manager virtual machine. </summary>
    public partial class IaasComputeVmContainer : IaasVmContainer
    {
        /// <summary> Initializes a new instance of <see cref="IaasComputeVmContainer"/>. </summary>
        public IaasComputeVmContainer()
        {
            ContainerType = ProtectableContainerType.MicrosoftComputeVirtualMachines;
        }

        /// <summary> Initializes a new instance of <see cref="IaasComputeVmContainer"/>. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="registrationStatus"> Status of registration of the container with the Recovery Services Vault. </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerType">
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </param>
        /// <param name="protectableObjectType"> Type of the protectable object associated with this container. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="virtualMachineId"> Fully qualified ARM url of the virtual machine represented by this Azure IaaS VM container. </param>
        /// <param name="virtualMachineVersion"> Specifies whether the container represents a Classic or an Azure Resource Manager VM. </param>
        /// <param name="resourceGroup"> Resource group name of Recovery Services Vault. </param>
        internal IaasComputeVmContainer(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string healthStatus, ProtectableContainerType containerType, string protectableObjectType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier virtualMachineId, string virtualMachineVersion, string resourceGroup) : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType, protectableObjectType, serializedAdditionalRawData, virtualMachineId, virtualMachineVersion, resourceGroup)
        {
            ContainerType = containerType;
        }
    }
}
