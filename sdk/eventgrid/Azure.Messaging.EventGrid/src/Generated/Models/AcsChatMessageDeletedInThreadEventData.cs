// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.ChatMessageDeletedInThread event. </summary>
    public partial class AcsChatMessageDeletedInThreadEventData : AcsChatMessageEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatMessageDeletedInThreadEventData"/>. </summary>
        internal AcsChatMessageDeletedInThreadEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatMessageDeletedInThreadEventData"/>. </summary>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="messageId"> The chat message id. </param>
        /// <param name="senderCommunicationIdentifier"> The communication identifier of the sender. </param>
        /// <param name="senderDisplayName"> The display name of the sender. </param>
        /// <param name="composeTime"> The original compose time of the message. </param>
        /// <param name="type"> The type of the message. </param>
        /// <param name="version"> The version of the message. </param>
        /// <param name="deleteTime"> The time at which the message was deleted. </param>
        internal AcsChatMessageDeletedInThreadEventData(string transactionId, string threadId, IDictionary<string, BinaryData> serializedAdditionalRawData, string messageId, CommunicationIdentifierModel senderCommunicationIdentifier, string senderDisplayName, DateTimeOffset? composeTime, string type, long? version, DateTimeOffset? deleteTime) : base(transactionId, threadId, serializedAdditionalRawData, messageId, senderCommunicationIdentifier, senderDisplayName, composeTime, type, version)
        {
            DeleteTime = deleteTime;
        }

        /// <summary> The time at which the message was deleted. </summary>
        public DateTimeOffset? DeleteTime { get; }
    }
}
