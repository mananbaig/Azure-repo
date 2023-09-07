// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Authorization profile with details of AAD user Ids and group Ids authorized for data plane access. </summary>
    public partial class AuthorizationProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AuthorizationProfile"/>. </summary>
        public AuthorizationProfile()
        {
            UserIds = new ChangeTrackingList<string>();
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AuthorizationProfile"/>. </summary>
        /// <param name="userIds"> AAD user Ids authorized for data plane access. </param>
        /// <param name="groupIds"> AAD group Ids authorized for data plane access. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthorizationProfile(IList<string> userIds, IList<string> groupIds, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserIds = userIds;
            GroupIds = groupIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> AAD user Ids authorized for data plane access. </summary>
        public IList<string> UserIds { get; }
        /// <summary> AAD group Ids authorized for data plane access. </summary>
        public IList<string> GroupIds { get; }
    }
}
