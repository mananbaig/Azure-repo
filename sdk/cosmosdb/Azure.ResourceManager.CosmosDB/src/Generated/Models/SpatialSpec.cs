// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The SpatialSpec. </summary>
    public partial class SpatialSpec
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SpatialSpec"/>. </summary>
        public SpatialSpec()
        {
            Types = new ChangeTrackingList<CosmosDBSpatialType>();
        }

        /// <summary> Initializes a new instance of <see cref="SpatialSpec"/>. </summary>
        /// <param name="path"> The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard (/path/*). </param>
        /// <param name="types"> List of path's spatial type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SpatialSpec(string path, IList<CosmosDBSpatialType> types, Dictionary<string, BinaryData> rawData)
        {
            Path = path;
            Types = types;
            _rawData = rawData;
        }

        /// <summary> The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard (/path/*). </summary>
        public string Path { get; set; }
        /// <summary> List of path's spatial type. </summary>
        public IList<CosmosDBSpatialType> Types { get; }
    }
}
