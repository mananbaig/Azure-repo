// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Storage.LifecyclePolicyCompleted event. </summary>
    public partial class StorageLifecyclePolicyCompletedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageLifecyclePolicyCompletedEventData"/>. </summary>
        internal StorageLifecyclePolicyCompletedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageLifecyclePolicyCompletedEventData"/>. </summary>
        /// <param name="scheduleTime"> The time the policy task was scheduled. </param>
        /// <param name="deleteSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <param name="tierToCoolSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <param name="tierToArchiveSummary"> Execution statistics of a specific policy action in a Blob Management cycle. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageLifecyclePolicyCompletedEventData(string scheduleTime, StorageLifecyclePolicyActionSummaryDetail deleteSummary, StorageLifecyclePolicyActionSummaryDetail tierToCoolSummary, StorageLifecyclePolicyActionSummaryDetail tierToArchiveSummary, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScheduleTime = scheduleTime;
            DeleteSummary = deleteSummary;
            TierToCoolSummary = tierToCoolSummary;
            TierToArchiveSummary = tierToArchiveSummary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time the policy task was scheduled. </summary>
        public string ScheduleTime { get; }
        /// <summary> Execution statistics of a specific policy action in a Blob Management cycle. </summary>
        public StorageLifecyclePolicyActionSummaryDetail DeleteSummary { get; }
        /// <summary> Execution statistics of a specific policy action in a Blob Management cycle. </summary>
        public StorageLifecyclePolicyActionSummaryDetail TierToCoolSummary { get; }
        /// <summary> Execution statistics of a specific policy action in a Blob Management cycle. </summary>
        public StorageLifecyclePolicyActionSummaryDetail TierToArchiveSummary { get; }
    }
}
