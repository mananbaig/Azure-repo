// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Oracle source. </summary>
    public partial class OracleSource : CopySource
    {
        /// <summary> Initializes a new instance of OracleSource. </summary>
        public OracleSource()
        {
            Type = "OracleSource";
        }

        /// <summary> Initializes a new instance of OracleSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="oracleReaderQuery"> Oracle reader query. Type: string (or Expression with resultType string). </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for Oracle read in parallel. </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for Oracle source partitioning. </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal OracleSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object oracleReaderQuery, object queryTimeout, OraclePartitionOption? partitionOption, OraclePartitionSettings partitionSettings, object additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            OracleReaderQuery = oracleReaderQuery;
            QueryTimeout = queryTimeout;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            AdditionalColumns = additionalColumns;
            Type = type ?? "OracleSource";
        }

        /// <summary> Oracle reader query. Type: string (or Expression with resultType string). </summary>
        public object OracleReaderQuery { get; set; }
        /// <summary> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public object QueryTimeout { get; set; }
        /// <summary> The partition mechanism that will be used for Oracle read in parallel. </summary>
        public OraclePartitionOption? PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for Oracle source partitioning. </summary>
        public OraclePartitionSettings PartitionSettings { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public object AdditionalColumns { get; set; }
    }
}
