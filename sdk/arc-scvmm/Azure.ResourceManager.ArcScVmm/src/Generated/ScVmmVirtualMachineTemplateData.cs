// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A class representing the ScVmmVirtualMachineTemplate data model.
    /// The VirtualMachineTemplates resource definition.
    /// </summary>
    public partial class ScVmmVirtualMachineTemplateData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineTemplateData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> is null. </exception>
        public ScVmmVirtualMachineTemplateData(AzureLocation location, ExtendedLocation extendedLocation) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));

            ExtendedLocation = extendedLocation;
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaces>();
            Disks = new ChangeTrackingList<VirtualDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineTemplateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource. </param>
        /// <param name="uuid"> Unique ID of the virtual machine template. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="osType"> Gets or sets the type of the os. </param>
        /// <param name="osName"> Gets or sets os name. </param>
        /// <param name="computerName"> Gets or sets computer name. </param>
        /// <param name="memoryMB"> MemoryMB is the desired size of a virtual machine's memory, in MB. </param>
        /// <param name="cpuCount"> Gets or sets the desired number of vCPUs for the vm. </param>
        /// <param name="limitCpuForMigration"> Gets or sets a value indicating whether to enable processor compatibility mode for live migration of VMs. </param>
        /// <param name="dynamicMemoryEnabled"> Gets or sets a value indicating whether to enable dynamic memory or not. </param>
        /// <param name="isCustomizable"> Gets or sets a value indicating whether the vm template is customizable or not. </param>
        /// <param name="dynamicMemoryMaxMB"> Gets or sets the max dynamic memory for the vm. </param>
        /// <param name="dynamicMemoryMinMB"> Gets or sets the min dynamic memory for the vm. </param>
        /// <param name="isHighlyAvailable"> Gets highly available property. </param>
        /// <param name="generation"> Gets or sets the generation for the vm. </param>
        /// <param name="networkInterfaces"> Gets or sets the network interfaces of the template. </param>
        /// <param name="disks"> Gets or sets the disks of the template. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ScVmmVirtualMachineTemplateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string inventoryItemId, string uuid, string vmmServerId, OSType? osType, string osName, string computerName, int? memoryMB, int? cpuCount, LimitCpuForMigration? limitCpuForMigration, DynamicMemoryEnabled? dynamicMemoryEnabled, IsCustomizable? isCustomizable, int? dynamicMemoryMaxMB, int? dynamicMemoryMinMB, string isHighlyAvailable, int? generation, IReadOnlyList<NetworkInterfaces> networkInterfaces, IReadOnlyList<VirtualDisk> disks, string provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            InventoryItemId = inventoryItemId;
            Uuid = uuid;
            VmmServerId = vmmServerId;
            OSType = osType;
            OSName = osName;
            ComputerName = computerName;
            MemoryMB = memoryMB;
            CpuCount = cpuCount;
            LimitCpuForMigration = limitCpuForMigration;
            DynamicMemoryEnabled = dynamicMemoryEnabled;
            IsCustomizable = isCustomizable;
            DynamicMemoryMaxMB = dynamicMemoryMaxMB;
            DynamicMemoryMinMB = dynamicMemoryMinMB;
            IsHighlyAvailable = isHighlyAvailable;
            Generation = generation;
            NetworkInterfaces = networkInterfaces;
            Disks = disks;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScVmmVirtualMachineTemplateData"/> for deserialization. </summary>
        internal ScVmmVirtualMachineTemplateData()
        {
        }

        /// <summary> The extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the resource. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Unique ID of the virtual machine template. </summary>
        public string Uuid { get; set; }
        /// <summary> ARM Id of the vmmServer resource in which this resource resides. </summary>
        public string VmmServerId { get; set; }
        /// <summary> Gets or sets the type of the os. </summary>
        public OSType? OSType { get; }
        /// <summary> Gets or sets os name. </summary>
        public string OSName { get; }
        /// <summary> Gets or sets computer name. </summary>
        public string ComputerName { get; }
        /// <summary> MemoryMB is the desired size of a virtual machine's memory, in MB. </summary>
        public int? MemoryMB { get; }
        /// <summary> Gets or sets the desired number of vCPUs for the vm. </summary>
        public int? CpuCount { get; }
        /// <summary> Gets or sets a value indicating whether to enable processor compatibility mode for live migration of VMs. </summary>
        public LimitCpuForMigration? LimitCpuForMigration { get; }
        /// <summary> Gets or sets a value indicating whether to enable dynamic memory or not. </summary>
        public DynamicMemoryEnabled? DynamicMemoryEnabled { get; }
        /// <summary> Gets or sets a value indicating whether the vm template is customizable or not. </summary>
        public IsCustomizable? IsCustomizable { get; }
        /// <summary> Gets or sets the max dynamic memory for the vm. </summary>
        public int? DynamicMemoryMaxMB { get; }
        /// <summary> Gets or sets the min dynamic memory for the vm. </summary>
        public int? DynamicMemoryMinMB { get; }
        /// <summary> Gets highly available property. </summary>
        public string IsHighlyAvailable { get; }
        /// <summary> Gets or sets the generation for the vm. </summary>
        public int? Generation { get; }
        /// <summary> Gets or sets the network interfaces of the template. </summary>
        public IReadOnlyList<NetworkInterfaces> NetworkInterfaces { get; }
        /// <summary> Gets or sets the disks of the template. </summary>
        public IReadOnlyList<VirtualDisk> Disks { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
