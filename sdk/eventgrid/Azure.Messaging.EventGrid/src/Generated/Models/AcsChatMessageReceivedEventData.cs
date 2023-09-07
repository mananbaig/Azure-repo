// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.ChatMessageReceived event. </summary>
    public partial class AcsChatMessageReceivedEventData : AcsChatMessageEventBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatMessageReceivedEventData"/>. </summary>
        internal AcsChatMessageReceivedEventData()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatMessageReceivedEventData"/>. </summary>
        /// <param name="recipientCommunicationIdentifier"> The communication identifier of the target user. </param>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="messageId"> The chat message id. </param>
        /// <param name="senderCommunicationIdentifier"> The communication identifier of the sender. </param>
        /// <param name="senderDisplayName"> The display name of the sender. </param>
        /// <param name="composeTime"> The original compose time of the message. </param>
        /// <param name="type"> The type of the message. </param>
        /// <param name="version"> The version of the message. </param>
        /// <param name="messageBody"> The body of the chat message. </param>
        /// <param name="metadata"> The chat message metadata. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AcsChatMessageReceivedEventData(CommunicationIdentifierModel recipientCommunicationIdentifier, string transactionId, string threadId, string messageId, CommunicationIdentifierModel senderCommunicationIdentifier, string senderDisplayName, DateTimeOffset? composeTime, string type, long? version, string messageBody, IReadOnlyDictionary<string, string> metadata, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(recipientCommunicationIdentifier, transactionId, threadId, messageId, senderCommunicationIdentifier, senderDisplayName, composeTime, type, version, serializedAdditionalRawData)
        {
            MessageBody = messageBody;
            Metadata = metadata;
        }

        /// <summary> The body of the chat message. </summary>
        public string MessageBody { get; }
        /// <summary> The chat message metadata. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
