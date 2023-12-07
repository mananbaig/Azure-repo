// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of all Router Job events. </summary>
    public partial class AcsRouterJobEventData : AcsRouterEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterJobEventData"/>. </summary>
        internal AcsRouterJobEventData()
        {
            Labels = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterJobEventData"/>. </summary>
        /// <param name="jobId"> Router Event Job ID. </param>
        /// <param name="channelReference"> Router Event Channel Reference. </param>
        /// <param name="channelId"> Router Event Channel ID. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="queueId"> Router Job events Queue Id. </param>
        /// <param name="labels"> Router Job events Labels. </param>
        /// <param name="tags"> Router Jobs events Tags. </param>
        internal AcsRouterJobEventData(string jobId, string channelReference, string channelId, IDictionary<string, BinaryData> serializedAdditionalRawData, string queueId, IReadOnlyDictionary<string, string> labels, IReadOnlyDictionary<string, string> tags) : base(jobId, channelReference, channelId, serializedAdditionalRawData)
        {
            QueueId = queueId;
            Labels = labels;
            Tags = tags;
        }

        /// <summary> Router Job events Queue Id. </summary>
        public string QueueId { get; }
        /// <summary> Router Job events Labels. </summary>
        public IReadOnlyDictionary<string, string> Labels { get; }
        /// <summary> Router Jobs events Tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
