// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.ChatThreadPropertiesUpdated event. </summary>
    public partial class AcsChatThreadPropertiesUpdatedEventData : AcsChatThreadEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of AcsChatThreadPropertiesUpdatedEventData. </summary>
        internal AcsChatThreadPropertiesUpdatedEventData()
        {
            Properties = new Core.ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of AcsChatThreadPropertiesUpdatedEventData. </summary>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        /// <param name="editedByCommunicationIdentifier"> The communication identifier of the user who updated the thread properties. </param>
        /// <param name="editTime"> The time at which the properties of the thread were updated. </param>
        /// <param name="properties"> The updated thread properties. </param>
        internal AcsChatThreadPropertiesUpdatedEventData(string transactionId, string threadId, DateTimeOffset? createTime, long? version, CommunicationIdentifierModel editedByCommunicationIdentifier, DateTimeOffset? editTime, IReadOnlyDictionary<string, object> properties) : base(transactionId, threadId, createTime, version)
        {
            EditedByCommunicationIdentifier = editedByCommunicationIdentifier;
            EditTime = editTime;
            Properties = properties;
        }

        /// <summary> The communication identifier of the user who updated the thread properties. </summary>
        public CommunicationIdentifierModel EditedByCommunicationIdentifier { get; }
        /// <summary> The time at which the properties of the thread were updated. </summary>
        public DateTimeOffset? EditTime { get; }
        /// <summary> The updated thread properties. </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
    }
}
