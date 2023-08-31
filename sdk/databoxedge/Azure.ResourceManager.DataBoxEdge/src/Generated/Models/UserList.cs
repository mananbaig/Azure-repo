// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Collection of users. </summary>
    internal partial class UserList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UserList"/>. </summary>
        internal UserList()
        {
            Value = new ChangeTrackingList<DataBoxEdgeUserData>();
        }

        /// <summary> Initializes a new instance of <see cref="UserList"/>. </summary>
        /// <param name="value"> The list of users. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UserList(IReadOnlyList<DataBoxEdgeUserData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of users. </summary>
        public IReadOnlyList<DataBoxEdgeUserData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
