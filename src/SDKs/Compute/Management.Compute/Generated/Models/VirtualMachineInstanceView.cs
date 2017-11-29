// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The instance view of a virtual machine.
    /// </summary>
    public partial class VirtualMachineInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineInstanceView class.
        /// </summary>
        public VirtualMachineInstanceView()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineInstanceView class.
        /// </summary>
        /// <param name="platformUpdateDomain">Specifies the update domain of
        /// the virtual machine.</param>
        /// <param name="platformFaultDomain">Specifies the fault domain of the
        /// virtual machine.</param>
        /// <param name="rdpThumbPrint">The Remote desktop certificate
        /// thumbprint.</param>
        /// <param name="vmAgent">The VM Agent running on the virtual
        /// machine.</param>
        /// <param name="maintenanceRedeployStatus">The Maintenance Operation
        /// status on the virtual machine.</param>
        /// <param name="disks">The virtual machine disk information.</param>
        /// <param name="extensions">The extensions information.</param>
        /// <param name="bootDiagnostics">Boot Diagnostics is a debugging
        /// feature which allows you to view Console Output and Screenshot to
        /// diagnose VM status. &lt;br&gt;&lt;br&gt; For Linux Virtual
        /// Machines, you can easily view the output of your console log.
        /// &lt;br&gt;&lt;br&gt; For both Windows and Linux virtual machines,
        /// Azure also enables you to see a screenshot of the VM from the
        /// hypervisor.</param>
        /// <param name="statuses">The resource status information.</param>
        public VirtualMachineInstanceView(int? platformUpdateDomain = default(int?), int? platformFaultDomain = default(int?), string rdpThumbPrint = default(string), VirtualMachineAgentInstanceView vmAgent = default(VirtualMachineAgentInstanceView), MaintenanceRedeployStatus maintenanceRedeployStatus = default(MaintenanceRedeployStatus), IList<DiskInstanceView> disks = default(IList<DiskInstanceView>), IList<VirtualMachineExtensionInstanceView> extensions = default(IList<VirtualMachineExtensionInstanceView>), BootDiagnosticsInstanceView bootDiagnostics = default(BootDiagnosticsInstanceView), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>))
        {
            PlatformUpdateDomain = platformUpdateDomain;
            PlatformFaultDomain = platformFaultDomain;
            RdpThumbPrint = rdpThumbPrint;
            VmAgent = vmAgent;
            MaintenanceRedeployStatus = maintenanceRedeployStatus;
            Disks = disks;
            Extensions = extensions;
            BootDiagnostics = bootDiagnostics;
            Statuses = statuses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the update domain of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "platformUpdateDomain")]
        public int? PlatformUpdateDomain { get; set; }

        /// <summary>
        /// Gets or sets specifies the fault domain of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "platformFaultDomain")]
        public int? PlatformFaultDomain { get; set; }

        /// <summary>
        /// Gets or sets the Remote desktop certificate thumbprint.
        /// </summary>
        [JsonProperty(PropertyName = "rdpThumbPrint")]
        public string RdpThumbPrint { get; set; }

        /// <summary>
        /// Gets or sets the VM Agent running on the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "vmAgent")]
        public VirtualMachineAgentInstanceView VmAgent { get; set; }

        /// <summary>
        /// Gets or sets the Maintenance Operation status on the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "maintenanceRedeployStatus")]
        public MaintenanceRedeployStatus MaintenanceRedeployStatus { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine disk information.
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public IList<DiskInstanceView> Disks { get; set; }

        /// <summary>
        /// Gets or sets the extensions information.
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<VirtualMachineExtensionInstanceView> Extensions { get; set; }

        /// <summary>
        /// Gets or sets boot Diagnostics is a debugging feature which allows
        /// you to view Console Output and Screenshot to diagnose VM status.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For Linux Virtual Machines,
        /// you can easily view the output of your console log.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; For both Windows and Linux
        /// virtual machines, Azure also enables you to see a screenshot of the
        /// VM from the hypervisor.
        /// </summary>
        [JsonProperty(PropertyName = "bootDiagnostics")]
        public BootDiagnosticsInstanceView BootDiagnostics { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

    }
}
