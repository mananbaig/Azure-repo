// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Subvolume Patch Request properties. </summary>
    public partial class NetAppSubvolumeInfoPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetAppSubvolumeInfoPatch"/>. </summary>
        public NetAppSubvolumeInfoPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppSubvolumeInfoPatch"/>. </summary>
        /// <param name="size"> Truncate subvolume to the provided size in bytes. </param>
        /// <param name="path"> path to the subvolume. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppSubvolumeInfoPatch(long? size, string path, Dictionary<string, BinaryData> rawData)
        {
            Size = size;
            Path = path;
            _rawData = rawData;
        }

        /// <summary> Truncate subvolume to the provided size in bytes. </summary>
        public long? Size { get; set; }
        /// <summary> path to the subvolume. </summary>
        public string Path { get; set; }
    }
}
