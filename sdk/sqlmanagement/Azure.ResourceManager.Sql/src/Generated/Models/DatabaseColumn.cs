// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A database column resource. </summary>
    public partial class DatabaseColumn : ProxyResource
    {
        /// <summary> Initializes a new instance of DatabaseColumn. </summary>
        public DatabaseColumn()
        {
        }

        /// <summary> Initializes a new instance of DatabaseColumn. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="columnType"> The column data type. </param>
        /// <param name="temporalType"> The table temporal type. </param>
        /// <param name="memoryOptimized"> Whether or not the column belongs to a memory optimized table. </param>
        /// <param name="isComputed"> Whether or not the column is computed. </param>
        internal DatabaseColumn(string id, string name, string type, ColumnDataType? columnType, TableTemporalType? temporalType, bool? memoryOptimized, bool? isComputed) : base(id, name, type)
        {
            ColumnType = columnType;
            TemporalType = temporalType;
            MemoryOptimized = memoryOptimized;
            IsComputed = isComputed;
        }

        /// <summary> The column data type. </summary>
        public ColumnDataType? ColumnType { get; set; }
        /// <summary> The table temporal type. </summary>
        public TableTemporalType? TemporalType { get; set; }
        /// <summary> Whether or not the column belongs to a memory optimized table. </summary>
        public bool? MemoryOptimized { get; set; }
        /// <summary> Whether or not the column is computed. </summary>
        public bool? IsComputed { get; set; }
    }
}
