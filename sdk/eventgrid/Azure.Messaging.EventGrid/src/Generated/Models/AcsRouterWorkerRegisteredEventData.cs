// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.RouterWorkerRegistered event. </summary>
    public partial class AcsRouterWorkerRegisteredEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerRegisteredEventData"/>. </summary>
        internal AcsRouterWorkerRegisteredEventData()
        {
            QueueAssignments = new ChangeTrackingList<AcsRouterQueueDetails>();
            ChannelConfigurations = new ChangeTrackingList<AcsRouterChannelConfiguration>();
            Labels = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRouterWorkerRegisteredEventData"/>. </summary>
        /// <param name="workerId"> Router Worker Registered Worker Id. </param>
        /// <param name="queueAssignments"> Router Worker Registered Queue Info. </param>
        /// <param name="channelConfigurations"> Router Worker Registered Channel Configuration. </param>
        /// <param name="totalCapacity"> Router Worker Register Total Capacity. </param>
        /// <param name="labels"> Router Worker Registered Labels. </param>
        /// <param name="tags"> Router Worker Registered Tags. </param>
        internal AcsRouterWorkerRegisteredEventData(string workerId, IReadOnlyList<AcsRouterQueueDetails> queueAssignments, IReadOnlyList<AcsRouterChannelConfiguration> channelConfigurations, int? totalCapacity, IReadOnlyDictionary<string, string> labels, IReadOnlyDictionary<string, string> tags)
        {
            WorkerId = workerId;
            QueueAssignments = queueAssignments;
            ChannelConfigurations = channelConfigurations;
            TotalCapacity = totalCapacity;
            Labels = labels;
            Tags = tags;
        }

        /// <summary> Router Worker Registered Worker Id. </summary>
        public string WorkerId { get; }
        /// <summary> Router Worker Registered Queue Info. </summary>
        public IReadOnlyList<AcsRouterQueueDetails> QueueAssignments { get; }
        /// <summary> Router Worker Registered Channel Configuration. </summary>
        public IReadOnlyList<AcsRouterChannelConfiguration> ChannelConfigurations { get; }
        /// <summary> Router Worker Register Total Capacity. </summary>
        public int? TotalCapacity { get; }
        /// <summary> Router Worker Registered Labels. </summary>
        public IReadOnlyDictionary<string, string> Labels { get; }
        /// <summary> Router Worker Registered Tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}
