// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the database accounts and their properties. </summary>
    internal partial class DatabaseAccountsListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseAccountsListResult"/>. </summary>
        internal DatabaseAccountsListResult()
        {
            Value = new ChangeTrackingList<CosmosDBAccountData>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseAccountsListResult"/>. </summary>
        /// <param name="value"> List of database account and their properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseAccountsListResult(IReadOnlyList<CosmosDBAccountData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> List of database account and their properties. </summary>
        public IReadOnlyList<CosmosDBAccountData> Value { get; }
    }
}
