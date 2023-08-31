// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Describes the body of a purge request for an App Insights Workspace. </summary>
    public partial class OperationalInsightsWorkspacePurgeContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspacePurgeContent"/>. </summary>
        /// <param name="table"> Table from which to purge data. </param>
        /// <param name="filters"> The set of columns and filters (queries) to run over them to purge the resulting data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="table"/> or <paramref name="filters"/> is null. </exception>
        public OperationalInsightsWorkspacePurgeContent(string table, IEnumerable<OperationalInsightsWorkspacePurgeFilter> filters)
        {
            Argument.AssertNotNull(table, nameof(table));
            Argument.AssertNotNull(filters, nameof(filters));

            Table = table;
            Filters = filters.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspacePurgeContent"/>. </summary>
        /// <param name="table"> Table from which to purge data. </param>
        /// <param name="filters"> The set of columns and filters (queries) to run over them to purge the resulting data. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OperationalInsightsWorkspacePurgeContent(string table, IList<OperationalInsightsWorkspacePurgeFilter> filters, Dictionary<string, BinaryData> rawData)
        {
            Table = table;
            Filters = filters;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsWorkspacePurgeContent"/> for deserialization. </summary>
        internal OperationalInsightsWorkspacePurgeContent()
        {
        }

        /// <summary> Table from which to purge data. </summary>
        public string Table { get; }
        /// <summary> The set of columns and filters (queries) to run over them to purge the resulting data. </summary>
        public IList<OperationalInsightsWorkspacePurgeFilter> Filters { get; }
    }
}
