// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A list of servers. </summary>
    internal partial class PostgreSqlFlexibleServerListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerListResult"/>. </summary>
        internal PostgreSqlFlexibleServerListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlFlexibleServerData>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerListResult"/>. </summary>
        /// <param name="value"> The list of flexible servers. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlFlexibleServerListResult(IReadOnlyList<PostgreSqlFlexibleServerData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> The list of flexible servers. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
