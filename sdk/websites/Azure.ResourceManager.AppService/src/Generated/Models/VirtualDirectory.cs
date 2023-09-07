// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Directory for virtual application. </summary>
    public partial class VirtualDirectory
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="VirtualDirectory"/>. </summary>
        public VirtualDirectory()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualDirectory"/>. </summary>
        /// <param name="virtualPath"> Path to virtual application. </param>
        /// <param name="physicalPath"> Physical path. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualDirectory(string virtualPath, string physicalPath, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualPath = virtualPath;
            PhysicalPath = physicalPath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Path to virtual application. </summary>
        public string VirtualPath { get; set; }
        /// <summary> Physical path. </summary>
        public string PhysicalPath { get; set; }
    }
}
