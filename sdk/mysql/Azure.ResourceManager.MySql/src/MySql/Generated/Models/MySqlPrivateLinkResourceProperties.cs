// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Properties of a private link resource. </summary>
    public partial class MySqlPrivateLinkResourceProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlPrivateLinkResourceProperties"/>. </summary>
        internal MySqlPrivateLinkResourceProperties()
        {
            RequiredMembers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlPrivateLinkResourceProperties"/>. </summary>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlPrivateLinkResourceProperties(string groupId, IReadOnlyList<string> requiredMembers, Dictionary<string, BinaryData> rawData)
        {
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            _rawData = rawData;
        }

        /// <summary> The private link resource group id. </summary>
        public string GroupId { get; }
        /// <summary> The private link resource required member names. </summary>
        public IReadOnlyList<string> RequiredMembers { get; }
    }
}
