// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.Namespaces
{
    /// <summary> Receive operation details per Cloud Event. </summary>
    public partial class ReceiveDetails
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

        /// <summary> Initializes a new instance of <see cref="ReceiveDetails"/>. </summary>
        /// <param name="brokerProperties"> The Event Broker details. </param>
        /// <param name="event"> Cloud Event details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="brokerProperties"/> or <paramref name="event"/> is null. </exception>
        internal ReceiveDetails(BrokerProperties brokerProperties, CloudEvent @event)
        {
            Argument.AssertNotNull(brokerProperties, nameof(brokerProperties));
            Argument.AssertNotNull(@event, nameof(@event));

            BrokerProperties = brokerProperties;
            Event = @event;
        }

        /// <summary> Initializes a new instance of <see cref="ReceiveDetails"/>. </summary>
        /// <param name="brokerProperties"> The Event Broker details. </param>
        /// <param name="event"> Cloud Event details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReceiveDetails(BrokerProperties brokerProperties, CloudEvent @event, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BrokerProperties = brokerProperties;
            Event = @event;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ReceiveDetails"/> for deserialization. </summary>
        internal ReceiveDetails()
        {
        }

        /// <summary> The Event Broker details. </summary>
        public BrokerProperties BrokerProperties { get; }
    }
}
