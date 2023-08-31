// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> List of volume resources. </summary>
    internal partial class VolumeList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VolumeList"/>. </summary>
        internal VolumeList()
        {
            Value = new ChangeTrackingList<NetAppVolumeData>();
        }

        /// <summary> Initializes a new instance of <see cref="VolumeList"/>. </summary>
        /// <param name="value"> List of volumes. </param>
        /// <param name="nextLink"> URL to get the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VolumeList(IReadOnlyList<NetAppVolumeData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of volumes. </summary>
        public IReadOnlyList<NetAppVolumeData> Value { get; }
        /// <summary> URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
