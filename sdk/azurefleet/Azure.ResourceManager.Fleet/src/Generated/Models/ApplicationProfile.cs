// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Fleet.Models
{
    /// <summary> Contains the list of gallery applications that should be made available to the VM/VMSS. </summary>
    internal partial class ApplicationProfile
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationProfile"/>. </summary>
        public ApplicationProfile()
        {
            GalleryApplications = new ChangeTrackingList<VmGalleryApplication>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationProfile"/>. </summary>
        /// <param name="galleryApplications"> Specifies the gallery applications that should be made available to the VM/VMSS. </param>
        internal ApplicationProfile(IList<VmGalleryApplication> galleryApplications)
        {
            GalleryApplications = galleryApplications;
        }

        /// <summary> Specifies the gallery applications that should be made available to the VM/VMSS. </summary>
        public IList<VmGalleryApplication> GalleryApplications { get; }
    }
}
