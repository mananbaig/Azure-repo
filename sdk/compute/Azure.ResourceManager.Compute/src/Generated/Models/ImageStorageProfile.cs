// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a storage profile. </summary>
    public partial class ImageStorageProfile
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ImageStorageProfile"/>. </summary>
        public ImageStorageProfile()
        {
            DataDisks = new ChangeTrackingList<ImageDataDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="ImageStorageProfile"/>. </summary>
        /// <param name="osDisk"> Specifies information about the operating system disk used by the virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </param>
        /// <param name="dataDisks"> Specifies the parameters that are used to add a data disk to a virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </param>
        /// <param name="zoneResilient"> Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage (ZRS). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageStorageProfile(ImageOSDisk osDisk, IList<ImageDataDisk> dataDisks, bool? zoneResilient, Dictionary<string, BinaryData> rawData)
        {
            OSDisk = osDisk;
            DataDisks = dataDisks;
            ZoneResilient = zoneResilient;
            _rawData = rawData;
        }

        /// <summary> Specifies information about the operating system disk used by the virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </summary>
        public ImageOSDisk OSDisk { get; set; }
        /// <summary> Specifies the parameters that are used to add a data disk to a virtual machine. &lt;br&gt;&lt;br&gt; For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview). </summary>
        public IList<ImageDataDisk> DataDisks { get; }
        /// <summary> Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage (ZRS). </summary>
        public bool? ZoneResilient { get; set; }
    }
}
