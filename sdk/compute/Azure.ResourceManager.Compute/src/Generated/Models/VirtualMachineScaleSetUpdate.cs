// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine Scale Set. </summary>
    public partial class VirtualMachineScaleSetUpdate : UpdateResource
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetUpdate. </summary>
        public VirtualMachineScaleSetUpdate()
        {
        }

        /// <summary> The virtual machine scale set sku. </summary>
        public Sku Sku { get; set; }
        /// <summary> The purchase plan when deploying a virtual machine scale set from VM Marketplace images. </summary>
        public Plan Plan { get; set; }
        /// <summary> The identity of the virtual machine scale set, if configured. </summary>
        public ResourceIdentity Identity { get; set; }
        /// <summary> The upgrade policy. </summary>
        public UpgradePolicy UpgradePolicy { get; set; }
        /// <summary> Policy for automatic repairs. </summary>
        public AutomaticRepairsPolicy AutomaticRepairsPolicy { get; set; }
        /// <summary> The virtual machine profile. </summary>
        public VirtualMachineScaleSetUpdateVMProfile VirtualMachineProfile { get; set; }
        /// <summary> Specifies whether the Virtual Machine Scale Set should be overprovisioned. </summary>
        public bool? Overprovision { get; set; }
        /// <summary> When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs. </summary>
        public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }
        /// <summary> When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true. </summary>
        public bool? SinglePlacementGroup { get; set; }
        /// <summary> Specifies additional capabilities enabled or disabled on the Virtual Machines in the Virtual Machine Scale Set. For instance: whether the Virtual Machines have the capability to support attaching managed data disks with UltraSSD_LRS storage account type. </summary>
        public AdditionalCapabilities AdditionalCapabilities { get; set; }
        /// <summary> Specifies the scale-in policy that decides which virtual machines are chosen for removal when a Virtual Machine Scale Set is scaled-in. </summary>
        public ScaleInPolicy ScaleInPolicy { get; set; }
        /// <summary> Specifies information about the proximity placement group that the virtual machine scale set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </summary>
        public SubResource ProximityPlacementGroup { get; set; }
    }
}
