// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary>
    /// Information about the destination for an event subscription.
    /// Please note <see cref="EventSubscriptionDestination"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureFunctionEventSubscriptionDestination"/>, <see cref="EventHubEventSubscriptionDestination"/>, <see cref="HybridConnectionEventSubscriptionDestination"/>, <see cref="PartnerEventSubscriptionDestination"/>, <see cref="ServiceBusQueueEventSubscriptionDestination"/>, <see cref="ServiceBusTopicEventSubscriptionDestination"/>, <see cref="StorageQueueEventSubscriptionDestination"/> and <see cref="WebHookEventSubscriptionDestination"/>.
    /// </summary>
    public abstract partial class EventSubscriptionDestination
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionDestination"/>. </summary>
        protected EventSubscriptionDestination()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionDestination"/>. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventSubscriptionDestination(EndpointType endpointType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EndpointType = endpointType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of the endpoint for the event subscription destination. </summary>
        internal EndpointType EndpointType { get; set; }
    }
}
