// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Geo-Replication information for the Secondary Storage Service. </summary>
    public partial class BlobGeoReplication
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobGeoReplication"/>. </summary>
        /// <param name="status"> The status of the secondary location. </param>
        /// <param name="lastSyncedOn"> A GMT date/time value, to the second. All primary writes preceding this value are guaranteed to be available for read operations at the secondary. Primary writes after this point in time may or may not be available for reads. </param>
        internal BlobGeoReplication(BlobGeoReplicationStatus status, DateTimeOffset? lastSyncedOn)
        {
            Status = status;
            LastSyncedOn = lastSyncedOn;
        }

        /// <summary> Initializes a new instance of <see cref="BlobGeoReplication"/>. </summary>
        /// <param name="status"> The status of the secondary location. </param>
        /// <param name="lastSyncedOn"> A GMT date/time value, to the second. All primary writes preceding this value are guaranteed to be available for read operations at the secondary. Primary writes after this point in time may or may not be available for reads. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobGeoReplication(BlobGeoReplicationStatus status, DateTimeOffset? lastSyncedOn, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            LastSyncedOn = lastSyncedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BlobGeoReplication"/> for deserialization. </summary>
        internal BlobGeoReplication()
        {
        }

        /// <summary> The status of the secondary location. </summary>
        public BlobGeoReplicationStatus Status { get; }
    }
}
