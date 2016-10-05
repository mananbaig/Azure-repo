// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// The instance view of a virtual machine scale set VM.
    /// </summary>
    public partial class VirtualMachineScaleSetVMInstanceViewInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceViewInner class.
        /// </summary>
        public VirtualMachineScaleSetVMInstanceViewInner() { }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetVMInstanceViewInner class.
        /// </summary>
        /// <param name="platformUpdateDomain">the Update Domain count.</param>
        /// <param name="platformFaultDomain">the Fault Domain count.</param>
        /// <param name="rdpThumbPrint">the Remote desktop certificate
        /// thumbprint.</param>
        /// <param name="vmAgent">the VM Agent running on the virtual
        /// machine.</param>
        /// <param name="disks">the disks information.</param>
        /// <param name="extensions">the extensions information.</param>
        /// <param name="bootDiagnostics">the boot diagnostics.</param>
        /// <param name="statuses">the resource status information.</param>
        public VirtualMachineScaleSetVMInstanceViewInner(int? platformUpdateDomain = default(int?), int? platformFaultDomain = default(int?), string rdpThumbPrint = default(string), VirtualMachineAgentInstanceView vmAgent = default(VirtualMachineAgentInstanceView), System.Collections.Generic.IList<DiskInstanceView> disks = default(System.Collections.Generic.IList<DiskInstanceView>), System.Collections.Generic.IList<VirtualMachineExtensionInstanceView> extensions = default(System.Collections.Generic.IList<VirtualMachineExtensionInstanceView>), BootDiagnosticsInstanceView bootDiagnostics = default(BootDiagnosticsInstanceView), System.Collections.Generic.IList<InstanceViewStatus> statuses = default(System.Collections.Generic.IList<InstanceViewStatus>))
        {
            PlatformUpdateDomain = platformUpdateDomain;
            PlatformFaultDomain = platformFaultDomain;
            RdpThumbPrint = rdpThumbPrint;
            VmAgent = vmAgent;
            Disks = disks;
            Extensions = extensions;
            BootDiagnostics = bootDiagnostics;
            Statuses = statuses;
        }

        /// <summary>
        /// Gets or sets the Update Domain count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "platformUpdateDomain")]
        public int? PlatformUpdateDomain { get; set; }

        /// <summary>
        /// Gets or sets the Fault Domain count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "platformFaultDomain")]
        public int? PlatformFaultDomain { get; set; }

        /// <summary>
        /// Gets or sets the Remote desktop certificate thumbprint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rdpThumbPrint")]
        public string RdpThumbPrint { get; set; }

        /// <summary>
        /// Gets or sets the VM Agent running on the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmAgent")]
        public VirtualMachineAgentInstanceView VmAgent { get; set; }

        /// <summary>
        /// Gets or sets the disks information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "disks")]
        public System.Collections.Generic.IList<DiskInstanceView> Disks { get; set; }

        /// <summary>
        /// Gets or sets the extensions information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "extensions")]
        public System.Collections.Generic.IList<VirtualMachineExtensionInstanceView> Extensions { get; set; }

        /// <summary>
        /// Gets or sets the boot diagnostics.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "bootDiagnostics")]
        public BootDiagnosticsInstanceView BootDiagnostics { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "statuses")]
        public System.Collections.Generic.IList<InstanceViewStatus> Statuses { get; set; }

    }
}
