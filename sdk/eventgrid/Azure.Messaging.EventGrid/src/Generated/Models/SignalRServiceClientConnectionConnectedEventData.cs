// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.SignalRService.ClientConnectionConnected event. </summary>
    public partial class SignalRServiceClientConnectionConnectedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRServiceClientConnectionConnectedEventData"/>. </summary>
        internal SignalRServiceClientConnectionConnectedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRServiceClientConnectionConnectedEventData"/>. </summary>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="hubName"> The hub of connected client connection. </param>
        /// <param name="connectionId"> The connection Id of connected client connection. </param>
        /// <param name="userId"> The user Id of connected client connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRServiceClientConnectionConnectedEventData(DateTimeOffset? timestamp, string hubName, string connectionId, string userId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Timestamp = timestamp;
            HubName = hubName;
            ConnectionId = connectionId;
            UserId = userId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The time at which the event occurred. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The hub of connected client connection. </summary>
        public string HubName { get; }
        /// <summary> The connection Id of connected client connection. </summary>
        public string ConnectionId { get; }
        /// <summary> The user Id of connected client connection. </summary>
        public string UserId { get; }
    }
}
