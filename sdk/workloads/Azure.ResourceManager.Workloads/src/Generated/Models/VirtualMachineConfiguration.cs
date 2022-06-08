// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the virtual machine configuration. </summary>
    public partial class VirtualMachineConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineConfiguration"/>. </summary>
        /// <param name="vmSize"> The virtual machine size. </param>
        /// <param name="imageReference"> The image reference. </param>
        /// <param name="osProfile"> The OS profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmSize"/>, <paramref name="imageReference"/> or <paramref name="osProfile"/> is null. </exception>
        public VirtualMachineConfiguration(string vmSize, ImageReference imageReference, OSProfile osProfile)
        {
            if (vmSize == null)
            {
                throw new ArgumentNullException(nameof(vmSize));
            }
            if (imageReference == null)
            {
                throw new ArgumentNullException(nameof(imageReference));
            }
            if (osProfile == null)
            {
                throw new ArgumentNullException(nameof(osProfile));
            }

            VmSize = vmSize;
            ImageReference = imageReference;
            OSProfile = osProfile;
        }

        /// <summary> The virtual machine size. </summary>
        public string VmSize { get; set; }
        /// <summary> The image reference. </summary>
        public ImageReference ImageReference { get; set; }
        /// <summary> The OS profile. </summary>
        public OSProfile OSProfile { get; set; }
    }
}
