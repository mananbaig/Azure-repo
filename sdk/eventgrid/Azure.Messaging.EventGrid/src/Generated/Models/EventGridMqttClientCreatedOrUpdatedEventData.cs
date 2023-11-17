// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Event data for Microsoft.EventGrid.MQTTClientCreatedOrUpdated event. </summary>
    public partial class EventGridMqttClientCreatedOrUpdatedEventData : EventGridMqttClientEventData
    {
        /// <summary> Initializes a new instance of <see cref="EventGridMqttClientCreatedOrUpdatedEventData"/>. </summary>
        internal EventGridMqttClientCreatedOrUpdatedEventData()
        {
            Attributes = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="EventGridMqttClientCreatedOrUpdatedEventData"/>. </summary>
        /// <param name="clientAuthenticationName"> Unique identifier for the MQTT client that the client presents to the service for authentication. This case-sensitive string can be up to 128 characters long, and supports UTF-8 characters. </param>
        /// <param name="clientName"> Name of the client resource in the Event Grid namespace. </param>
        /// <param name="namespaceName"> Name of the Event Grid namespace where the MQTT client was created or updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="state"> Configured state of the client. The value could be Enabled or Disabled. </param>
        /// <param name="createdOn"> Time the client resource is created based on the provider's UTC time. </param>
        /// <param name="updatedOn"> Time the client resource is last updated based on the provider's UTC time. If the client resource was never updated, this value is identical to the value of the 'createdOn' property. </param>
        /// <param name="attributes"> The key-value attributes that are assigned to the client resource. </param>
        internal EventGridMqttClientCreatedOrUpdatedEventData(string clientAuthenticationName, string clientName, string namespaceName, IDictionary<string, BinaryData> serializedAdditionalRawData, EventGridMqttClientState? state, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, IReadOnlyDictionary<string, string> attributes) : base(clientAuthenticationName, clientName, namespaceName, serializedAdditionalRawData)
        {
            State = state;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            Attributes = attributes;
        }

        /// <summary> Configured state of the client. The value could be Enabled or Disabled. </summary>
        public EventGridMqttClientState? State { get; }
        /// <summary> Time the client resource is created based on the provider's UTC time. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Time the client resource is last updated based on the provider's UTC time. If the client resource was never updated, this value is identical to the value of the 'createdOn' property. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> The key-value attributes that are assigned to the client resource. </summary>
        public IReadOnlyDictionary<string, string> Attributes { get; }
    }
}
