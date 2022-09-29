// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Container for the workloads running inside Azure Compute or Classic Compute.
    /// Please note <see cref="AzureWorkloadContainer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureSqlAGWorkloadContainerProtectionContainer"/> and <see cref="AzureVmAppContainerProtectionContainer"/>.
    /// </summary>
    public partial class AzureWorkloadContainer : ProtectionContainer
    {
        /// <summary> Initializes a new instance of AzureWorkloadContainer. </summary>
        public AzureWorkloadContainer()
        {
            ContainerType = ProtectableContainerType.AzureWorkloadContainer;
        }

        /// <summary> Initializes a new instance of AzureWorkloadContainer. </summary>
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
        /// <param name="sourceResourceId"> ARM ID of the virtual machine represented by this Azure Workload Container. </param>
        /// <param name="lastUpdatedOn"> Time stamp when this container was updated. </param>
        /// <param name="extendedInfo"> Additional details of a workload container. </param>
        /// <param name="workloadType"> Workload type for which registration was sent. </param>
        /// <param name="operationType"> Re-Do Operation. </param>
        internal AzureWorkloadContainer(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string healthStatus, ProtectableContainerType containerType, string protectableObjectType, string sourceResourceId, DateTimeOffset? lastUpdatedOn, AzureWorkloadContainerExtendedInfo extendedInfo, WorkloadType? workloadType, OperationType? operationType) : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType, protectableObjectType)
        {
            SourceResourceId = sourceResourceId;
            LastUpdatedOn = lastUpdatedOn;
            ExtendedInfo = extendedInfo;
            WorkloadType = workloadType;
            OperationType = operationType;
            ContainerType = containerType;
        }

        /// <summary> ARM ID of the virtual machine represented by this Azure Workload Container. </summary>
        public string SourceResourceId { get; set; }
        /// <summary> Time stamp when this container was updated. </summary>
        public DateTimeOffset? LastUpdatedOn { get; set; }
        /// <summary> Additional details of a workload container. </summary>
        public AzureWorkloadContainerExtendedInfo ExtendedInfo { get; set; }
        /// <summary> Workload type for which registration was sent. </summary>
        public WorkloadType? WorkloadType { get; set; }
        /// <summary> Re-Do Operation. </summary>
        public OperationType? OperationType { get; set; }
    }
}
