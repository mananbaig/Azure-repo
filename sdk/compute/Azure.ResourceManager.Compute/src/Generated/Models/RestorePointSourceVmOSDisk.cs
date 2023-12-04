// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes an Operating System disk. </summary>
    public partial class RestorePointSourceVmOSDisk
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RestorePointSourceVmOSDisk"/>. </summary>
        public RestorePointSourceVmOSDisk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestorePointSourceVmOSDisk"/>. </summary>
        /// <param name="osType"> Gets the Operating System type. </param>
        /// <param name="encryptionSettings"> Gets the disk encryption settings. </param>
        /// <param name="name"> Gets the disk name. </param>
        /// <param name="caching"> Gets the caching type. </param>
        /// <param name="diskSizeGB"> Gets the disk size in GB. </param>
        /// <param name="managedDisk"> Gets the managed disk details. </param>
        /// <param name="diskRestorePoint"> Contains Disk Restore Point properties. </param>
        /// <param name="writeAcceleratorEnabled"> Shows true if the disk is write-accelerator enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorePointSourceVmOSDisk(OperatingSystemType? osType, DiskEncryptionSettings encryptionSettings, string name, CachingType? caching, int? diskSizeGB, VirtualMachineManagedDisk managedDisk, DiskRestorePointAttributes diskRestorePoint, bool? writeAcceleratorEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OSType = osType;
            EncryptionSettings = encryptionSettings;
            Name = name;
            Caching = caching;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            DiskRestorePoint = diskRestorePoint;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the Operating System type. </summary>
        public OperatingSystemType? OSType { get; }
        /// <summary> Gets the disk encryption settings. </summary>
        public DiskEncryptionSettings EncryptionSettings { get; }
        /// <summary> Gets the disk name. </summary>
        public string Name { get; }
        /// <summary> Gets the caching type. </summary>
        public CachingType? Caching { get; }
        /// <summary> Gets the disk size in GB. </summary>
        public int? DiskSizeGB { get; }
        /// <summary> Gets the managed disk details. </summary>
        public VirtualMachineManagedDisk ManagedDisk { get; set; }
        /// <summary> Contains Disk Restore Point properties. </summary>
        public DiskRestorePointAttributes DiskRestorePoint { get; set; }
        /// <summary> Shows true if the disk is write-accelerator enabled. </summary>
        public bool? WriteAcceleratorEnabled { get; }
    }
}
