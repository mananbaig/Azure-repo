// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualMachine : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachine class.
        /// </summary>
        public VirtualMachine() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachine class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="plan">The purchase plan when deploying virtual
        /// machine from VM Marketplace images.</param>
        /// <param name="hardwareProfile">The hardware profile.</param>
        /// <param name="storageProfile">The storage profile.</param>
        /// <param name="osProfile">The OS profile.</param>
        /// <param name="networkProfile">The network profile.</param>
        /// <param name="diagnosticsProfile">The diagnostics profile.</param>
        /// <param name="availabilitySet">The reference Id of the availability
        /// set to which the virtual machine belongs.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="instanceView">The virtual machine instance
        /// view.</param>
        /// <param name="licenseType">Specifies that the image or disk that is
        /// being used was licensed on-premises. This element is only used
        /// for images that contain the Windows Server operating
        /// system.</param>
        /// <param name="vmId">Specifies the VM unique ID which is a 128-bits
        /// identifier that is encoded and stored in all Azure IaaS VMs
        /// SMBIOS and can be read using platform BIOS commands.</param>
        /// <param name="resources">The virtual machine child extension
        /// resources.</param>
        public VirtualMachine(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), Plan plan = default(Plan), HardwareProfile hardwareProfile = default(HardwareProfile), StorageProfile storageProfile = default(StorageProfile), OSProfile osProfile = default(OSProfile), NetworkProfile networkProfile = default(NetworkProfile), DiagnosticsProfile diagnosticsProfile = default(DiagnosticsProfile), SubResource availabilitySet = default(SubResource), string provisioningState = default(string), VirtualMachineInstanceView instanceView = default(VirtualMachineInstanceView), string licenseType = default(string), string vmId = default(string), System.Collections.Generic.IList<VirtualMachineExtension> resources = default(System.Collections.Generic.IList<VirtualMachineExtension>))
            : base(location, id, name, type, tags)
        {
            Plan = plan;
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            OsProfile = osProfile;
            NetworkProfile = networkProfile;
            DiagnosticsProfile = diagnosticsProfile;
            AvailabilitySet = availabilitySet;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            LicenseType = licenseType;
            VmId = vmId;
            Resources = resources;
        }

        /// <summary>
        /// Gets or sets the purchase plan when deploying virtual machine from
        /// VM Marketplace images.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the hardware profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hardwareProfile")]
        public HardwareProfile HardwareProfile { get; set; }

        /// <summary>
        /// Gets or sets the storage profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets the OS profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.osProfile")]
        public OSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets the network profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.networkProfile")]
        public NetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets the diagnostics profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets or sets the reference Id of the availability set to which the
        /// virtual machine belongs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.availabilitySet")]
        public SubResource AvailabilitySet { get; set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the virtual machine instance view.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.instanceView")]
        public VirtualMachineInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets or sets specifies that the image or disk that is being used
        /// was licensed on-premises. This element is only used for images
        /// that contain the Windows Server operating system.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets specifies the VM unique ID which is a 128-bits identifier
        /// that is encoded and stored in all Azure IaaS VMs SMBIOS and can
        /// be read using platform BIOS commands.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vmId")]
        public string VmId { get; private set; }

        /// <summary>
        /// Gets the virtual machine child extension resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resources")]
        public System.Collections.Generic.IList<VirtualMachineExtension> Resources { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.StorageProfile != null)
            {
                this.StorageProfile.Validate();
            }
            if (this.Resources != null)
            {
                foreach (var element in this.Resources)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
