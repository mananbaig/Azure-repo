// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Describes the json payload for a notified recipient for new requests. </summary>
    public partial class NotificationRecipient
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NotificationRecipient"/>. </summary>
        public NotificationRecipient()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NotificationRecipient"/>. </summary>
        /// <param name="principalId"> Principal ID. </param>
        /// <param name="emailAddress"> Email Address. </param>
        /// <param name="displayName"> Display Name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationRecipient(Guid? principalId, string emailAddress, string displayName, Dictionary<string, BinaryData> rawData)
        {
            PrincipalId = principalId;
            EmailAddress = emailAddress;
            DisplayName = displayName;
            _rawData = rawData;
        }

        /// <summary> Principal ID. </summary>
        public Guid? PrincipalId { get; set; }
        /// <summary> Email Address. </summary>
        public string EmailAddress { get; }
        /// <summary> Display Name. </summary>
        public string DisplayName { get; }
    }
}
