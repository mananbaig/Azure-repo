// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The group by expression to be used in the query. </summary>
    public partial class QueryGrouping
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueryGrouping"/>. </summary>
        /// <param name="columnType"> Has type of the column to group. </param>
        /// <param name="name"> The name of the column to group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public QueryGrouping(QueryColumnType columnType, string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ColumnType = columnType;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="QueryGrouping"/>. </summary>
        /// <param name="columnType"> Has type of the column to group. </param>
        /// <param name="name"> The name of the column to group. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryGrouping(QueryColumnType columnType, string name, Dictionary<string, BinaryData> rawData)
        {
            ColumnType = columnType;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryGrouping"/> for deserialization. </summary>
        internal QueryGrouping()
        {
        }

        /// <summary> Has type of the column to group. </summary>
        public QueryColumnType ColumnType { get; }
        /// <summary> The name of the column to group. </summary>
        public string Name { get; }
    }
}
