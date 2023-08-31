// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the storage profile of a Gallery Image Version. </summary>
    public partial class SharedGalleryImageVersionStorageProfile
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SharedGalleryImageVersionStorageProfile"/>. </summary>
        internal SharedGalleryImageVersionStorageProfile()
        {
            DataDiskImages = new ChangeTrackingList<SharedGalleryDataDiskImage>();
        }

        /// <summary> Initializes a new instance of <see cref="SharedGalleryImageVersionStorageProfile"/>. </summary>
        /// <param name="osDiskImage"> This is the OS disk image. </param>
        /// <param name="dataDiskImages"> A list of data disk images. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedGalleryImageVersionStorageProfile(SharedGalleryOSDiskImage osDiskImage, IReadOnlyList<SharedGalleryDataDiskImage> dataDiskImages, Dictionary<string, BinaryData> rawData)
        {
            OSDiskImage = osDiskImage;
            DataDiskImages = dataDiskImages;
            _rawData = rawData;
        }

        /// <summary> This is the OS disk image. </summary>
        public SharedGalleryOSDiskImage OSDiskImage { get; }
        /// <summary> A list of data disk images. </summary>
        public IReadOnlyList<SharedGalleryDataDiskImage> DataDiskImages { get; }
    }
}
