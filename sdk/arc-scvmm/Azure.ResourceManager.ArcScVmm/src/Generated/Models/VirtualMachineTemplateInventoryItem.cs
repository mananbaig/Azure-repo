// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> The Virtual machine template inventory item. </summary>
    internal partial class VirtualMachineTemplateInventoryItem : InventoryItemProperties
    {
        /// <summary> Initializes a new instance of VirtualMachineTemplateInventoryItem. </summary>
        internal VirtualMachineTemplateInventoryItem()
        {
            InventoryType = InventoryType.VirtualMachineTemplate;
        }

        /// <summary> Gets or sets the desired number of vCPUs for the vm. </summary>
        public int? CpuCount { get; }
        /// <summary> MemoryMB is the desired size of a virtual machine&apos;s memory, in MB. </summary>
        public int? MemoryMB { get; }
        /// <summary> Gets or sets the type of the os. </summary>
        public OSType? OSType { get; }
        /// <summary> Gets or sets os name. </summary>
        public string OSName { get; }
    }
}
