// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the DatabaseColumn data model.
    /// A database column resource.
    /// </summary>
    public partial class DatabaseColumnData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseColumnData"/>. </summary>
        public DatabaseColumnData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseColumnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="columnType"> The column data type. </param>
        /// <param name="temporalType"> The table temporal type. </param>
        /// <param name="isMemoryOptimized"> Whether or not the column belongs to a memory optimized table. </param>
        /// <param name="isComputed"> Whether or not the column is computed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseColumnData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SqlColumnDataType? columnType, TableTemporalType? temporalType, bool? isMemoryOptimized, bool? isComputed, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ColumnType = columnType;
            TemporalType = temporalType;
            IsMemoryOptimized = isMemoryOptimized;
            IsComputed = isComputed;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The column data type. </summary>
        public SqlColumnDataType? ColumnType { get; set; }
        /// <summary> The table temporal type. </summary>
        public TableTemporalType? TemporalType { get; set; }
        /// <summary> Whether or not the column belongs to a memory optimized table. </summary>
        public bool? IsMemoryOptimized { get; set; }
        /// <summary> Whether or not the column is computed. </summary>
        public bool? IsComputed { get; set; }
    }
}
