// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The request to invite a follower to a database. </summary>
    public partial class DatabaseInviteFollowerContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseInviteFollowerContent"/>. </summary>
        /// <param name="inviteeEmail"> The email of the invited user for which the follower invitation is generated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inviteeEmail"/> is null. </exception>
        public DatabaseInviteFollowerContent(string inviteeEmail)
        {
            Argument.AssertNotNull(inviteeEmail, nameof(inviteeEmail));

            InviteeEmail = inviteeEmail;
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseInviteFollowerContent"/>. </summary>
        /// <param name="inviteeEmail"> The email of the invited user for which the follower invitation is generated. </param>
        /// <param name="tableLevelSharingProperties"> Table level sharing specifications. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseInviteFollowerContent(string inviteeEmail, KustoDatabaseTableLevelSharingProperties tableLevelSharingProperties, Dictionary<string, BinaryData> rawData)
        {
            InviteeEmail = inviteeEmail;
            TableLevelSharingProperties = tableLevelSharingProperties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseInviteFollowerContent"/> for deserialization. </summary>
        internal DatabaseInviteFollowerContent()
        {
        }

        /// <summary> The email of the invited user for which the follower invitation is generated. </summary>
        public string InviteeEmail { get; }
        /// <summary> Table level sharing specifications. </summary>
        public KustoDatabaseTableLevelSharingProperties TableLevelSharingProperties { get; set; }
    }
}
