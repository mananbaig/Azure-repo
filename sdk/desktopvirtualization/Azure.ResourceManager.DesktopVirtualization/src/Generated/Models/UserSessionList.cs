// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> List of UserSession definitions. </summary>
    internal partial class UserSessionList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UserSessionList"/>. </summary>
        internal UserSessionList()
        {
            Value = new ChangeTrackingList<UserSessionData>();
        }

        /// <summary> Initializes a new instance of <see cref="UserSessionList"/>. </summary>
        /// <param name="value"> List of UserSession definitions. </param>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UserSessionList(IReadOnlyList<UserSessionData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of UserSession definitions. </summary>
        public IReadOnlyList<UserSessionData> Value { get; }
        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
    }
}
