// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Describes the body of a purge request for an App Insights component. </summary>
    public partial class ComponentPurgeBody
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeBody"/>. </summary>
        /// <param name="table"> Table from which to purge data. </param>
        /// <param name="filters"> The set of columns and filters (queries) to run over them to purge the resulting data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="table"/> or <paramref name="filters"/> is null. </exception>
        public ComponentPurgeBody(string table, IEnumerable<ComponentPurgeBodyFilters> filters)
        {
            Argument.AssertNotNull(table, nameof(table));
            Argument.AssertNotNull(filters, nameof(filters));

            Table = table;
            Filters = filters.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeBody"/>. </summary>
        /// <param name="table"> Table from which to purge data. </param>
        /// <param name="filters"> The set of columns and filters (queries) to run over them to purge the resulting data. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ComponentPurgeBody(string table, IList<ComponentPurgeBodyFilters> filters, Dictionary<string, BinaryData> rawData)
        {
            Table = table;
            Filters = filters;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComponentPurgeBody"/> for deserialization. </summary>
        internal ComponentPurgeBody()
        {
        }

        /// <summary> Table from which to purge data. </summary>
        public string Table { get; }
        /// <summary> The set of columns and filters (queries) to run over them to purge the resulting data. </summary>
        public IList<ComponentPurgeBodyFilters> Filters { get; }
    }
}
