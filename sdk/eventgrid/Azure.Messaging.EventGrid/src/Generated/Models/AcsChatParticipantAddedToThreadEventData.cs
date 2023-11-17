// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.ChatThreadParticipantAdded event. </summary>
    public partial class AcsChatParticipantAddedToThreadEventData : AcsChatEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatParticipantAddedToThreadEventData"/>. </summary>
        internal AcsChatParticipantAddedToThreadEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatParticipantAddedToThreadEventData"/>. </summary>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="time"> The time at which the user was added to the thread. </param>
        /// <param name="addedByCommunicationIdentifier"> The communication identifier of the user who added the user. </param>
        /// <param name="participantAdded"> The details of the user who was added. </param>
        /// <param name="version"> The version of the thread. </param>
        internal AcsChatParticipantAddedToThreadEventData(string transactionId, string threadId, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset? time, CommunicationIdentifierModel addedByCommunicationIdentifier, AcsChatThreadParticipantProperties participantAdded, long? version) : base(transactionId, threadId, serializedAdditionalRawData)
        {
            Time = time;
            AddedByCommunicationIdentifier = addedByCommunicationIdentifier;
            ParticipantAdded = participantAdded;
            Version = version;
        }

        /// <summary> The time at which the user was added to the thread. </summary>
        public DateTimeOffset? Time { get; }
        /// <summary> The communication identifier of the user who added the user. </summary>
        public CommunicationIdentifierModel AddedByCommunicationIdentifier { get; }
        /// <summary> The details of the user who was added. </summary>
        public AcsChatThreadParticipantProperties ParticipantAdded { get; }
        /// <summary> The version of the thread. </summary>
        public long? Version { get; }
    }
}
