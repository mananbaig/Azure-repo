// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the delivery configuration information of the event subscription. </summary>
    public partial class DeliveryConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeliveryConfiguration"/>. </summary>
        public DeliveryConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryConfiguration"/>. </summary>
        /// <param name="deliveryMode"> Delivery mode of the event subscription. </param>
        /// <param name="queue"> This property should be populated when deliveryMode is queue and represents information about the queue subscription. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeliveryConfiguration(DeliveryMode? deliveryMode, QueueInfo queue, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeliveryMode = deliveryMode;
            Queue = queue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Delivery mode of the event subscription. </summary>
        public DeliveryMode? DeliveryMode { get; set; }
        /// <summary> This property should be populated when deliveryMode is queue and represents information about the queue subscription. </summary>
        public QueueInfo Queue { get; set; }
    }
}
