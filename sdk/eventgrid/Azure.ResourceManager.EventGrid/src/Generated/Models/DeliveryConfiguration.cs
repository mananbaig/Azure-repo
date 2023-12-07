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
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeliveryConfiguration"/>. </summary>
        public DeliveryConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryConfiguration"/>. </summary>
        /// <param name="deliveryMode"> Delivery mode of the event subscription. </param>
        /// <param name="queue"> This property should be populated when deliveryMode is queue and represents information about the queue subscription. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeliveryConfiguration(DeliveryMode? deliveryMode, QueueInfo queue, IDictionary<string, BinaryData> serializedAdditionalRawData)
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
