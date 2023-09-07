// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.SignalRService.ClientConnectionDisconnected event. </summary>
    public partial class SignalRServiceClientConnectionDisconnectedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SignalRServiceClientConnectionDisconnectedEventData"/>. </summary>
        internal SignalRServiceClientConnectionDisconnectedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRServiceClientConnectionDisconnectedEventData"/>. </summary>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="hubName"> The hub of connected client connection. </param>
        /// <param name="connectionId"> The connection Id of connected client connection. </param>
        /// <param name="userId"> The user Id of connected client connection. </param>
        /// <param name="errorMessage"> The message of error that cause the client connection disconnected. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRServiceClientConnectionDisconnectedEventData(DateTimeOffset? timestamp, string hubName, string connectionId, string userId, string errorMessage, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Timestamp = timestamp;
            HubName = hubName;
            ConnectionId = connectionId;
            UserId = userId;
            ErrorMessage = errorMessage;
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
        /// <summary> The message of error that cause the client connection disconnected. </summary>
        public string ErrorMessage { get; }
    }
}
