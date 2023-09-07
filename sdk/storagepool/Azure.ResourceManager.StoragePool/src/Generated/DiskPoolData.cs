// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary>
    /// A class representing the DiskPool data model.
    /// Response for Disk Pool request.
    /// </summary>
    public partial class DiskPoolData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiskPoolData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: ["1"]. </param>
        /// <param name="status"> Operational status of the Disk Pool. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilityZones"/> or <paramref name="subnetId"/> is null. </exception>
        public DiskPoolData(AzureLocation location, DiskPoolIscsiTargetProvisioningState provisioningState, IEnumerable<string> availabilityZones, StoragePoolOperationalStatus status, ResourceIdentifier subnetId) : base(location)
        {
            Argument.AssertNotNull(availabilityZones, nameof(availabilityZones));
            Argument.AssertNotNull(subnetId, nameof(subnetId));

            ManagedByExtended = new ChangeTrackingList<string>();
            ProvisioningState = provisioningState;
            AvailabilityZones = availabilityZones.ToList();
            Status = status;
            Disks = new ChangeTrackingList<WritableSubResource>();
            SubnetId = subnetId;
            AdditionalCapabilities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Determines the SKU of the Disk pool. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="provisioningState"> State of the operation on the resource. </param>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: ["1"]. </param>
        /// <param name="status"> Operational status of the Disk Pool. </param>
        /// <param name="disks"> List of Azure Managed Disks to attach to a Disk Pool. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <param name="additionalCapabilities"> List of additional capabilities for Disk Pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskPoolData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, StoragePoolSku sku, string managedBy, IReadOnlyList<string> managedByExtended, DiskPoolIscsiTargetProvisioningState provisioningState, IList<string> availabilityZones, StoragePoolOperationalStatus status, IList<WritableSubResource> disks, ResourceIdentifier subnetId, IList<string> additionalCapabilities, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            ProvisioningState = provisioningState;
            AvailabilityZones = availabilityZones;
            Status = status;
            Disks = disks;
            SubnetId = subnetId;
            AdditionalCapabilities = additionalCapabilities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolData"/> for deserialization. </summary>
        internal DiskPoolData()
        {
        }

        /// <summary> Determines the SKU of the Disk pool. </summary>
        public StoragePoolSku Sku { get; set; }
        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IReadOnlyList<string> ManagedByExtended { get; }
        /// <summary> State of the operation on the resource. </summary>
        public DiskPoolIscsiTargetProvisioningState ProvisioningState { get; }
        /// <summary> Logical zone for Disk Pool resource; example: ["1"]. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> Operational status of the Disk Pool. </summary>
        public StoragePoolOperationalStatus Status { get; set; }
        /// <summary> List of Azure Managed Disks to attach to a Disk Pool. </summary>
        public IList<WritableSubResource> Disks { get; }
        /// <summary> Azure Resource ID of a Subnet for the Disk Pool. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> List of additional capabilities for Disk Pool. </summary>
        public IList<string> AdditionalCapabilities { get; }
    }
}
