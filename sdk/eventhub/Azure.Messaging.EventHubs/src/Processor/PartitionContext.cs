﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Messaging.EventHubs.Processor
{
    /// <summary>
    ///   TODO.
    /// </summary>
    ///
    public sealed class PartitionContext
    {
        /// <summary>
        ///   TODO.
        /// </summary>
        ///
        public string PartitionId { get; }

        /// <summary>
        ///   TODO. (EventHubPath?)
        /// </summary>
        ///
        public string EventHubName { get; }

        /// <summary>
        ///   TODO. (ConsumerGroup?)
        /// </summary>
        ///
        public string ConsumerGroupName { get; }

        /// <summary>
        ///   TODO.
        /// </summary>
        ///
        internal PartitionContext(string partitionId,
                                  string eventHubName,
                                  string consumerGroupName)
        {
            PartitionId = partitionId;
            EventHubName = eventHubName;
            ConsumerGroupName = consumerGroupName;
        }
    }
}
