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
    /// <summary> List of Snapshots. </summary>
    internal partial class SnapshotsList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SnapshotsList"/>. </summary>
        internal SnapshotsList()
        {
            Value = new ChangeTrackingList<NetAppVolumeSnapshotData>();
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotsList"/>. </summary>
        /// <param name="value"> A list of Snapshots. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SnapshotsList(IReadOnlyList<NetAppVolumeSnapshotData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> A list of Snapshots. </summary>
        public IReadOnlyList<NetAppVolumeSnapshotData> Value { get; }
    }
}
