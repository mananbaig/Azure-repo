// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the AvailabilitySet data model. </summary>
    public partial class AvailabilitySetData : TrackedResource
    {
        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="location"> The location. </param>
        public AvailabilitySetData(AzureLocation location) : base(location)
        {
            VirtualMachines = new ChangeTrackingList<WritableSubResource>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of AvailabilitySetData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of values. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks. Default value is &apos;Classic&apos;. </param>
        /// <param name="platformUpdateDomainCount"> Update Domain count. </param>
        /// <param name="platformFaultDomainCount"> Fault Domain count. </param>
        /// <param name="virtualMachines"> A list of references to all virtual machines in the availability set. </param>
        /// <param name="proximityPlacementGroup"> Specifies information about the proximity placement group that the availability set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal AvailabilitySetData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, Models.Sku sku, int? platformUpdateDomainCount, int? platformFaultDomainCount, IList<WritableSubResource> virtualMachines, WritableSubResource proximityPlacementGroup, IReadOnlyList<InstanceViewStatus> statuses) : base(id, name, type, tags, location)
        {
            Sku = sku;
            PlatformUpdateDomainCount = platformUpdateDomainCount;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachines = virtualMachines;
            ProximityPlacementGroup = proximityPlacementGroup;
            Statuses = statuses;
        }

        /// <summary> Sku of the availability set, only name is required to be set. See AvailabilitySetSkuTypes for possible set of values. Use &apos;Aligned&apos; for virtual machines with managed disks and &apos;Classic&apos; for virtual machines with unmanaged disks. Default value is &apos;Classic&apos;. </summary>
        public Models.Sku Sku { get; set; }
        /// <summary> Update Domain count. </summary>
        public int? PlatformUpdateDomainCount { get; set; }
        /// <summary> Fault Domain count. </summary>
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary> A list of references to all virtual machines in the availability set. </summary>
        public IList<WritableSubResource> VirtualMachines { get; }
        /// <summary> Specifies information about the proximity placement group that the availability set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </summary>
        public WritableSubResource ProximityPlacementGroup { get; set; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
