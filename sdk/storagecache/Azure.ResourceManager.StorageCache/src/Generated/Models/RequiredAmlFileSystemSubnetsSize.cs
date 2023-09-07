// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Information about the number of available IP addresses that are required for the AML file system. </summary>
    public partial class RequiredAmlFileSystemSubnetsSize
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RequiredAmlFileSystemSubnetsSize"/>. </summary>
        internal RequiredAmlFileSystemSubnetsSize()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RequiredAmlFileSystemSubnetsSize"/>. </summary>
        /// <param name="filesystemSubnetSize"> The number of available IP addresses that are required for the AML file system. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RequiredAmlFileSystemSubnetsSize(int? filesystemSubnetSize, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FilesystemSubnetSize = filesystemSubnetSize;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The number of available IP addresses that are required for the AML file system. </summary>
        public int? FilesystemSubnetSize { get; }
    }
}
