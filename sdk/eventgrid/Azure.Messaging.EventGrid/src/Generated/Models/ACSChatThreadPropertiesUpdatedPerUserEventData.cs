// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Communication.ChatThreadPropertiesUpdatedPerUser event. </summary>
    public partial class ACSChatThreadPropertiesUpdatedPerUserEventData : ACSChatThreadEventBaseProperties
    {
        /// <summary> Initializes a new instance of ACSChatThreadPropertiesUpdatedPerUserEventData. </summary>
        internal ACSChatThreadPropertiesUpdatedPerUserEventData()
        {
            Properties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ACSChatThreadPropertiesUpdatedPerUserEventData. </summary>
        /// <param name="recipientId"> The MRI of the target user. </param>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        /// <param name="editedBy"> The MRI of the user who updated the thread properties. </param>
        /// <param name="editTime"> The time at which the properties of the thread were updated. </param>
        /// <param name="properties"> The updated thread properties. </param>
        internal ACSChatThreadPropertiesUpdatedPerUserEventData(string recipientId, string transactionId, string threadId, DateTimeOffset? createTime, long? version, string editedBy, DateTimeOffset? editTime, IReadOnlyDictionary<string, object> properties) : base(recipientId, transactionId, threadId, createTime, version)
        {
            EditedBy = editedBy;
            EditTime = editTime;
            Properties = properties;
        }

        /// <summary> The MRI of the user who updated the thread properties. </summary>
        public string EditedBy { get; }
        /// <summary> The time at which the properties of the thread were updated. </summary>
        public DateTimeOffset? EditTime { get; }
        /// <summary> The updated thread properties. </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
    }
}
