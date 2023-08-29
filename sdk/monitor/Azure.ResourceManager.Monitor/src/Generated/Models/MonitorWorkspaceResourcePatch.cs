// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of ARM tracked top level resource properties for update operation. </summary>
    public partial class MonitorWorkspaceResourcePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceResourcePatch"/>. </summary>
        public MonitorWorkspaceResourcePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorWorkspaceResourcePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorWorkspaceResourcePatch(IDictionary<string, string> tags, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
