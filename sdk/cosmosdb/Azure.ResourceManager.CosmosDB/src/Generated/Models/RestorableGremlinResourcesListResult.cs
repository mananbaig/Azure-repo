// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The List operation response, that contains the restorable Gremlin resources. </summary>
    internal partial class RestorableGremlinResourcesListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RestorableGremlinResourcesListResult"/>. </summary>
        internal RestorableGremlinResourcesListResult()
        {
            Value = new ChangeTrackingList<RestorableGremlinResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="RestorableGremlinResourcesListResult"/>. </summary>
        /// <param name="value"> List of restorable Gremlin resources, including the gremlin database and graph names. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RestorableGremlinResourcesListResult(IReadOnlyList<RestorableGremlinResourceData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> List of restorable Gremlin resources, including the gremlin database and graph names. </summary>
        public IReadOnlyList<RestorableGremlinResourceData> Value { get; }
    }
}
