// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Azure Table source. </summary>
    public partial class AzureTableSource : TabularSource
    {
        /// <summary> Initializes a new instance of AzureTableSource. </summary>
        public AzureTableSource()
        {
            Type = "AzureTableSource";
        }

        /// <summary> Initializes a new instance of AzureTableSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="azureTableSourceQuery"> Azure Table source query. Type: string (or Expression with resultType string). </param>
        /// <param name="azureTableSourceIgnoreTableNotFound"> Azure Table source ignore table not found. Type: boolean (or Expression with resultType boolean). </param>
        internal AzureTableSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, object azureTableSourceQuery, object azureTableSourceIgnoreTableNotFound) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout)
        {
            AzureTableSourceQuery = azureTableSourceQuery;
            AzureTableSourceIgnoreTableNotFound = azureTableSourceIgnoreTableNotFound;
            Type = type ?? "AzureTableSource";
        }

        /// <summary> Azure Table source query. Type: string (or Expression with resultType string). </summary>
        public object AzureTableSourceQuery { get; set; }
        /// <summary> Azure Table source ignore table not found. Type: boolean (or Expression with resultType boolean). </summary>
        public object AzureTableSourceIgnoreTableNotFound { get; set; }
    }
}
