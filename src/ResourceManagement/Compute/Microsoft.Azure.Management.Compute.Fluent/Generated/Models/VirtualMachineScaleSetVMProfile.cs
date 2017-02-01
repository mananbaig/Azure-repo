// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    public partial class VirtualMachineScaleSetVMProfile
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMProfile
        /// class.
        /// </summary>
        public VirtualMachineScaleSetVMProfile() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetVMProfile
        /// class.
        /// </summary>
        /// <param name="osProfile">The virtual machine scale set OS
        /// profile.</param>
        /// <param name="storageProfile">The virtual machine scale set storage
        /// profile.</param>
        /// <param name="networkProfile">The virtual machine scale set network
        /// profile.</param>
        /// <param name="extensionProfile">The virtual machine scale set
        /// extension profile.</param>
        public VirtualMachineScaleSetVMProfile(VirtualMachineScaleSetOSProfile osProfile = default(VirtualMachineScaleSetOSProfile), VirtualMachineScaleSetStorageProfile storageProfile = default(VirtualMachineScaleSetStorageProfile), VirtualMachineScaleSetNetworkProfile networkProfile = default(VirtualMachineScaleSetNetworkProfile), VirtualMachineScaleSetExtensionProfile extensionProfile = default(VirtualMachineScaleSetExtensionProfile))
        {
            OsProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            ExtensionProfile = extensionProfile;
        }

        /// <summary>
        /// Gets or sets the virtual machine scale set OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "osProfile")]
        public VirtualMachineScaleSetOSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set network profile.
        /// </summary>
        [JsonProperty(PropertyName = "networkProfile")]
        public VirtualMachineScaleSetNetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set extension profile.
        /// </summary>
        [JsonProperty(PropertyName = "extensionProfile")]
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageProfile != null)
            {
                StorageProfile.Validate();
            }
        }
    }
}

