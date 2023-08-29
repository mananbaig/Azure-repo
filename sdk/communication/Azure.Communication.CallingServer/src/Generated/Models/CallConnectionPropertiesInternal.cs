// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The CallConnectionProperties. </summary>
    internal partial class CallConnectionPropertiesInternal
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CallConnectionPropertiesInternal"/>. </summary>
        internal CallConnectionPropertiesInternal()
        {
            Targets = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of <see cref="CallConnectionPropertiesInternal"/>. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="serverCallId"> The server call id. </param>
        /// <param name="source"> The source of the call. </param>
        /// <param name="targets"> The targets of the call. </param>
        /// <param name="callConnectionState"> The state of the call connection. </param>
        /// <param name="subject"> The subject. </param>
        /// <param name="callbackUri"> The callback URI. </param>
        /// <param name="mediaSubscriptionId"> SubscriptionId for media streaming. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CallConnectionPropertiesInternal(string callConnectionId, string serverCallId, CallSourceInternal source, IReadOnlyList<CommunicationIdentifierModel> targets, CallConnectionState? callConnectionState, string subject, string callbackUri, string mediaSubscriptionId, Dictionary<string, BinaryData> rawData)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            Source = source;
            Targets = targets;
            CallConnectionState = callConnectionState;
            Subject = subject;
            CallbackUri = callbackUri;
            MediaSubscriptionId = mediaSubscriptionId;
            _rawData = rawData;
        }

        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
        /// <summary> The server call id. </summary>
        public string ServerCallId { get; }
        /// <summary> The source of the call. </summary>
        public CallSourceInternal Source { get; }
        /// <summary> The targets of the call. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Targets { get; }
        /// <summary> The state of the call connection. </summary>
        public CallConnectionState? CallConnectionState { get; }
        /// <summary> The subject. </summary>
        public string Subject { get; }
        /// <summary> The callback URI. </summary>
        public string CallbackUri { get; }
        /// <summary> SubscriptionId for media streaming. </summary>
        public string MediaSubscriptionId { get; }
    }
}
