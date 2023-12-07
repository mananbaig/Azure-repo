// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RouterJobSchedulingFailed event. </summary>
    public partial class AcsRouterJobSchedulingFailedEventData : AcsRouterJobEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterJobSchedulingFailedEventData"/>. </summary>
        internal AcsRouterJobSchedulingFailedEventData()
        {
            ExpiredAttachedWorkerSelectors = new ChangeTrackingList<AcsRouterWorkerSelector>();
            ExpiredRequestedWorkerSelectors = new ChangeTrackingList<AcsRouterWorkerSelector>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobSchedulingFailedEventData"/>. </summary>
        /// <param name="jobId"> Router Event Job ID. </param>
        /// <param name="channelReference"> Router Event Channel Reference. </param>
        /// <param name="channelId"> Router Event Channel ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="queueId"> Router Job events Queue Id. </param>
        /// <param name="labels"> Router Job events Labels. </param>
        /// <param name="tags"> Router Jobs events Tags. </param>
        /// <param name="priority"> Router Job Priority. </param>
        /// <param name="expiredAttachedWorkerSelectors"> Router Job Scheduling Failed Attached Worker Selector Expired. </param>
        /// <param name="expiredRequestedWorkerSelectors"> Router Job Scheduling Failed Requested Worker Selector Expired. </param>
        /// <param name="scheduledOn"> Router Job Scheduling Failed Scheduled Time in UTC. </param>
        /// <param name="failureReason"> Router Job Scheduling Failed Reason. </param>
        internal AcsRouterJobSchedulingFailedEventData(string jobId, string channelReference, string channelId, IDictionary<string, BinaryData> serializedAdditionalRawData, string queueId, IReadOnlyDictionary<string, string> labels, IReadOnlyDictionary<string, string> tags, int? priority, IReadOnlyList<AcsRouterWorkerSelector> expiredAttachedWorkerSelectors, IReadOnlyList<AcsRouterWorkerSelector> expiredRequestedWorkerSelectors, DateTimeOffset? scheduledOn, string failureReason) : base(jobId, channelReference, channelId, serializedAdditionalRawData, queueId, labels, tags)
        {
            Priority = priority;
            ExpiredAttachedWorkerSelectors = expiredAttachedWorkerSelectors;
            ExpiredRequestedWorkerSelectors = expiredRequestedWorkerSelectors;
            ScheduledOn = scheduledOn;
            FailureReason = failureReason;
        }

        /// <summary> Router Job Priority. </summary>
        public int? Priority { get; }
        /// <summary> Router Job Scheduling Failed Attached Worker Selector Expired. </summary>
        public IReadOnlyList<AcsRouterWorkerSelector> ExpiredAttachedWorkerSelectors { get; }
        /// <summary> Router Job Scheduling Failed Requested Worker Selector Expired. </summary>
        public IReadOnlyList<AcsRouterWorkerSelector> ExpiredRequestedWorkerSelectors { get; }
        /// <summary> Router Job Scheduling Failed Scheduled Time in UTC. </summary>
        public DateTimeOffset? ScheduledOn { get; }
        /// <summary> Router Job Scheduling Failed Reason. </summary>
        public string FailureReason { get; }
    }
}
