// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The ListQueueServices. </summary>
    internal partial class ListQueueServices
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ListQueueServices"/>. </summary>
        internal ListQueueServices()
        {
            Value = new ChangeTrackingList<QueueServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListQueueServices"/>. </summary>
        /// <param name="value"> List of queue services returned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListQueueServices(IReadOnlyList<QueueServiceData> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of queue services returned. </summary>
        public IReadOnlyList<QueueServiceData> Value { get; }
    }
}
