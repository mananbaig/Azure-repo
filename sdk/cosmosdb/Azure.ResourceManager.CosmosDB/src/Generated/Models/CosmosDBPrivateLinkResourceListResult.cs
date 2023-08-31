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
    /// <summary> A list of private link resources. </summary>
    internal partial class CosmosDBPrivateLinkResourceListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBPrivateLinkResourceListResult"/>. </summary>
        internal CosmosDBPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<CosmosDBPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBPrivateLinkResourceListResult"/>. </summary>
        /// <param name="value"> Array of private link resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBPrivateLinkResourceListResult(IReadOnlyList<CosmosDBPrivateLinkResourceData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<CosmosDBPrivateLinkResourceData> Value { get; }
    }
}
