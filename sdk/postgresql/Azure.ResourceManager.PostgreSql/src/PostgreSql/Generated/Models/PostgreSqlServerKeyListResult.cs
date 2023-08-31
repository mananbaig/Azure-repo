// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> A list of PostgreSQL Server keys. </summary>
    internal partial class PostgreSqlServerKeyListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerKeyListResult"/>. </summary>
        internal PostgreSqlServerKeyListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlServerKeyData>();
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlServerKeyListResult"/>. </summary>
        /// <param name="value"> A list of PostgreSQL Server keys. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PostgreSqlServerKeyListResult(IReadOnlyList<PostgreSqlServerKeyData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> A list of PostgreSQL Server keys. </summary>
        public IReadOnlyList<PostgreSqlServerKeyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
