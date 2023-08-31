// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Disk Restore Point details. </summary>
    public partial class DiskRestorePointAttributes : ComputeSubResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DiskRestorePointAttributes"/>. </summary>
        public DiskRestorePointAttributes()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiskRestorePointAttributes"/>. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="encryption"> Encryption at rest settings for disk restore point. It is an optional property that can be specified in the input while creating a restore point. </param>
        /// <param name="sourceDiskRestorePoint"> Resource Id of the source disk restore point. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskRestorePointAttributes(ResourceIdentifier id, RestorePointEncryption encryption, WritableSubResource sourceDiskRestorePoint, Dictionary<string, BinaryData> rawData) : base(id, rawData)
        {
            Encryption = encryption;
            SourceDiskRestorePoint = sourceDiskRestorePoint;
        }

        /// <summary> Encryption at rest settings for disk restore point. It is an optional property that can be specified in the input while creating a restore point. </summary>
        public RestorePointEncryption Encryption { get; set; }
        /// <summary> Resource Id of the source disk restore point. </summary>
        internal WritableSubResource SourceDiskRestorePoint { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SourceDiskRestorePointId
        {
            get => SourceDiskRestorePoint is null ? default : SourceDiskRestorePoint.Id;
            set
            {
                if (SourceDiskRestorePoint is null)
                    SourceDiskRestorePoint = new WritableSubResource();
                SourceDiskRestorePoint.Id = value;
            }
        }
    }
}
