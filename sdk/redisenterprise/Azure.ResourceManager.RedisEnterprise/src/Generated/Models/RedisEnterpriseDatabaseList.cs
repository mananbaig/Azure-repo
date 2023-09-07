// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RedisEnterprise;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> The response of a list-all operation. </summary>
    internal partial class RedisEnterpriseDatabaseList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseDatabaseList"/>. </summary>
        internal RedisEnterpriseDatabaseList()
        {
            Value = new ChangeTrackingList<RedisEnterpriseDatabaseData>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseDatabaseList"/>. </summary>
        /// <param name="value"> List of databases. </param>
        /// <param name="nextLink"> The URI to fetch the next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterpriseDatabaseList(IReadOnlyList<RedisEnterpriseDatabaseData> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of databases. </summary>
        public IReadOnlyList<RedisEnterpriseDatabaseData> Value { get; }
        /// <summary> The URI to fetch the next page of results. </summary>
        public string NextLink { get; }
    }
}
