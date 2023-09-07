// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Cache.ExportRDBCompleted event. </summary>
    public partial class RedisExportRdbCompletedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisExportRdbCompletedEventData"/>. </summary>
        internal RedisExportRdbCompletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RedisExportRdbCompletedEventData"/>. </summary>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="name"> The name of this event. </param>
        /// <param name="status"> The status of this event. Failed or  succeeded. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisExportRdbCompletedEventData(DateTimeOffset? timestamp, string name, string status, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Timestamp = timestamp;
            Name = name;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time at which the event occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The name of this event. </summary>
        public string Name { get; }
        /// <summary> The status of this event. Failed or  succeeded. </summary>
        public string Status { get; }
    }
}
