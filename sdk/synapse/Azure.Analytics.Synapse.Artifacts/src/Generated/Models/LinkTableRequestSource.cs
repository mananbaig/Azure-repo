// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkTableRequestSource. </summary>
    public partial class LinkTableRequestSource
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="LinkTableRequestSource"/>. </summary>
        public LinkTableRequestSource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkTableRequestSource"/>. </summary>
        /// <param name="tableName"> Source table table name. </param>
        /// <param name="schemaName"> Source table schema name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkTableRequestSource(string tableName, string schemaName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TableName = tableName;
            SchemaName = schemaName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Source table table name. </summary>
        public string TableName { get; set; }
        /// <summary> Source table schema name. </summary>
        public string SchemaName { get; set; }
    }
}
