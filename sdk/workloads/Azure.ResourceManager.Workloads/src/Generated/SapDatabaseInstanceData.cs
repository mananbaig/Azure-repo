// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary> A class representing the SapDatabaseInstance data model. </summary>
    public partial class SapDatabaseInstanceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SapDatabaseInstanceData. </summary>
        /// <param name="location"> The location. </param>
        public SapDatabaseInstanceData(AzureLocation location) : base(location)
        {
            VmDetails = new ChangeTrackingList<DatabaseVmDetails>();
        }

        /// <summary> Initializes a new instance of SapDatabaseInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="subnetId"> The database subnet. </param>
        /// <param name="databaseSid"> The database SID. </param>
        /// <param name="databaseType"> The SAP database type. </param>
        /// <param name="ipAddress"> The database IP Address. </param>
        /// <param name="vmDetails"> The list of virtual machines. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Defines the Database Instance errors. </param>
        internal SapDatabaseInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ResourceIdentifier subnetId, string databaseSid, string databaseType, string ipAddress, IReadOnlyList<DatabaseVmDetails> vmDetails, SapVirtualInstanceStatus? status, SapVirtualInstanceProvisioningState? provisioningState, SapVirtualInstanceError errors) : base(id, name, resourceType, systemData, tags, location)
        {
            SubnetId = subnetId;
            DatabaseSid = databaseSid;
            DatabaseType = databaseType;
            IPAddress = ipAddress;
            VmDetails = vmDetails;
            Status = status;
            ProvisioningState = provisioningState;
            Errors = errors;
        }

        /// <summary> The database subnet. </summary>
        public ResourceIdentifier SubnetId { get; }
        /// <summary> The database SID. </summary>
        public string DatabaseSid { get; }
        /// <summary> The SAP database type. </summary>
        public string DatabaseType { get; }
        /// <summary> The database IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> The list of virtual machines. </summary>
        public IReadOnlyList<DatabaseVmDetails> VmDetails { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Defines the provisioning states. </summary>
        public SapVirtualInstanceProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the Database Instance errors. </summary>
        internal SapVirtualInstanceError Errors { get; }
        /// <summary> The Virtual Instance for SAP error body. </summary>
        public SapVirtualInstanceErrorDetail ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
