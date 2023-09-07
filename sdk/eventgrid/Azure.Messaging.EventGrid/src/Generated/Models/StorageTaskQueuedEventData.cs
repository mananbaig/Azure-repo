// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Storage.StorageTaskQueued event. </summary>
    public partial class StorageTaskQueuedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageTaskQueuedEventData"/>. </summary>
        internal StorageTaskQueuedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageTaskQueuedEventData"/>. </summary>
        /// <param name="queuedDateTime"> The time at which a storage task was queued. </param>
        /// <param name="taskExecutionId"> The execution id for a storage task. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageTaskQueuedEventData(DateTimeOffset? queuedDateTime, string taskExecutionId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QueuedDateTime = queuedDateTime;
            TaskExecutionId = taskExecutionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time at which a storage task was queued. </summary>
        public DateTimeOffset? QueuedDateTime { get; }
        /// <summary> The execution id for a storage task. </summary>
        public string TaskExecutionId { get; }
    }
}
