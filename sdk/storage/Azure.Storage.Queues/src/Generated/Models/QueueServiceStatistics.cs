// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Queues.Models
{
    /// <summary> Stats for the storage service. </summary>
    public partial class QueueServiceStatistics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QueueServiceStatistics"/>. </summary>
        internal QueueServiceStatistics()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QueueServiceStatistics"/>. </summary>
        /// <param name="geoReplication"> Geo-Replication information for the Secondary Storage Service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueueServiceStatistics(QueueGeoReplication geoReplication, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GeoReplication = geoReplication;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }
    }
}
