// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Properties of a call connection. </summary>
    internal partial class CallConnectionPropertiesInternal
    {
        /// <summary> Initializes a new instance of <see cref="CallConnectionPropertiesInternal"/>. </summary>
        internal CallConnectionPropertiesInternal()
        {
            Targets = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of <see cref="CallConnectionPropertiesInternal"/>. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="serverCallId"> The server call id. </param>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="sourceCallerIdNumber">
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Only populated in outbound PSTN calls.
        /// </param>
        /// <param name="sourceDisplayName"> Display name of the call if dialing out to a pstn number. </param>
        /// <param name="source"> Source identity. </param>
        /// <param name="correlationId"> The correlation ID. </param>
        /// <param name="answeredBy"> Identity of the answering entity. Only populated when identity is provided in the request and an inbound call. </param>
        /// <param name="answeredFor"> Identity of the original PSTN target of an incoming Call. Only populated when the original target is a PSTN number and an inbound call. </param>
        internal CallConnectionPropertiesInternal(string callConnectionId, string serverCallId, IReadOnlyList<CommunicationIdentifierModel> targets, CallConnectionState? callConnectionState, string callbackUri, PhoneNumberIdentifierModel sourceCallerIdNumber, string sourceDisplayName, CommunicationIdentifierModel source, string correlationId, CommunicationUserIdentifierModel answeredBy, PhoneNumberIdentifierModel answeredFor)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            Targets = targets;
            CallConnectionState = callConnectionState;
            CallbackUri = callbackUri;
            SourceCallerIdNumber = sourceCallerIdNumber;
            SourceDisplayName = sourceDisplayName;
            Source = source;
            CorrelationId = correlationId;
            AnsweredBy = answeredBy;
            AnsweredFor = answeredFor;
        }

        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
        /// <summary> The server call id. </summary>
        public string ServerCallId { get; }
        /// <summary> The targets of the call. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Targets { get; }
        /// <summary> The state of the call connection. </summary>
        public CallConnectionState? CallConnectionState { get; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary>
        /// The source caller Id, a phone number, that's shown to the PSTN participant being invited.
        /// Only populated in outbound PSTN calls.
        /// </summary>
        public PhoneNumberIdentifierModel SourceCallerIdNumber { get; }
        /// <summary> Display name of the call if dialing out to a pstn number. </summary>
        public string SourceDisplayName { get; }
        /// <summary> Source identity. </summary>
        public CommunicationIdentifierModel Source { get; }
        /// <summary> The correlation ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Identity of the answering entity. Only populated when identity is provided in the request and an inbound call. </summary>
        public CommunicationUserIdentifierModel AnsweredBy { get; }
        /// <summary> Identity of the original PSTN target of an incoming Call. Only populated when the original target is a PSTN number and an inbound call. </summary>
        public PhoneNumberIdentifierModel AnsweredFor { get; }
    }
}
