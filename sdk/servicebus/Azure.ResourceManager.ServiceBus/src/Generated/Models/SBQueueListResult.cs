// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> The response to the List Queues operation. </summary>
    internal partial class SBQueueListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SBQueueListResult"/>. </summary>
        internal SBQueueListResult()
        {
            Value = new ChangeTrackingList<ServiceBusQueueData>();
        }

        /// <summary> Initializes a new instance of <see cref="SBQueueListResult"/>. </summary>
        /// <param name="value"> Result of the List Queues operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of queues. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SBQueueListResult(IReadOnlyList<ServiceBusQueueData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Result of the List Queues operation. </summary>
        public IReadOnlyList<ServiceBusQueueData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of queues. </summary>
        public string NextLink { get; }
    }
}
