// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RouterJobClassified event. </summary>
    public partial class AcsRouterJobClassifiedEventData : AcsRouterJobEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterJobClassifiedEventData"/>. </summary>
        internal AcsRouterJobClassifiedEventData()
        {
            AttachedWorkerSelectors = new ChangeTrackingList<AcsRouterWorkerSelector>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobClassifiedEventData"/>. </summary>
        /// <param name="jobId"> Router Event Job ID. </param>
        /// <param name="channelReference"> Router Event Channel Reference. </param>
        /// <param name="channelId"> Router Event Channel ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="queueId"> Router Job events Queue Id. </param>
        /// <param name="labels"> Router Job events Labels. </param>
        /// <param name="tags"> Router Jobs events Tags. </param>
        /// <param name="queueDetails"> Router Job Queue Info. </param>
        /// <param name="classificationPolicyId"> Router Job Classification Policy Id. </param>
        /// <param name="priority"> Router Job Priority. </param>
        /// <param name="attachedWorkerSelectors"> Router Job Attached Worker Selector. </param>
        internal AcsRouterJobClassifiedEventData(string jobId, string channelReference, string channelId, IDictionary<string, BinaryData> serializedAdditionalRawData, string queueId, IReadOnlyDictionary<string, string> labels, IReadOnlyDictionary<string, string> tags, AcsRouterQueueDetails queueDetails, string classificationPolicyId, int? priority, IReadOnlyList<AcsRouterWorkerSelector> attachedWorkerSelectors) : base(jobId, channelReference, channelId, serializedAdditionalRawData, queueId, labels, tags)
        {
            QueueDetails = queueDetails;
            ClassificationPolicyId = classificationPolicyId;
            Priority = priority;
            AttachedWorkerSelectors = attachedWorkerSelectors;
        }

        /// <summary> Router Job Queue Info. </summary>
        public AcsRouterQueueDetails QueueDetails { get; }
        /// <summary> Router Job Classification Policy Id. </summary>
        public string ClassificationPolicyId { get; }
        /// <summary> Router Job Priority. </summary>
        public int? Priority { get; }
        /// <summary> Router Job Attached Worker Selector. </summary>
        public IReadOnlyList<AcsRouterWorkerSelector> AttachedWorkerSelectors { get; }
    }
}
