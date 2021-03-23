// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Azure SQL Managed Instance source. </summary>
    public partial class SqlMISource : TabularSource
    {
        /// <summary> Initializes a new instance of SqlMISource. </summary>
        public SqlMISource()
        {
            StoredProcedureParameters = new ChangeTrackingDictionary<string, StoredProcedureParameter>();
            Type = "SqlMISource";
        }

        /// <summary> Initializes a new instance of SqlMISource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sqlReaderQuery"> SQL reader query. Type: string (or Expression with resultType string). </param>
        /// <param name="sqlReaderStoredProcedureName"> Name of the stored procedure for a Azure SQL Managed Instance source. This cannot be used at the same time as SqlReaderQuery. Type: string (or Expression with resultType string). </param>
        /// <param name="storedProcedureParameters"> Value and type setting for stored procedure parameters. Example: &quot;{Parameter1: {value: &quot;1&quot;, type: &quot;int&quot;}}&quot;. </param>
        /// <param name="produceAdditionalTypes"> Which additional types to produce. </param>
        internal SqlMISource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, object sqlReaderQuery, object sqlReaderStoredProcedureName, IDictionary<string, StoredProcedureParameter> storedProcedureParameters, object produceAdditionalTypes) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout)
        {
            SqlReaderQuery = sqlReaderQuery;
            SqlReaderStoredProcedureName = sqlReaderStoredProcedureName;
            StoredProcedureParameters = storedProcedureParameters;
            ProduceAdditionalTypes = produceAdditionalTypes;
            Type = type ?? "SqlMISource";
        }

        /// <summary> SQL reader query. Type: string (or Expression with resultType string). </summary>
        public object SqlReaderQuery { get; set; }
        /// <summary> Name of the stored procedure for a Azure SQL Managed Instance source. This cannot be used at the same time as SqlReaderQuery. Type: string (or Expression with resultType string). </summary>
        public object SqlReaderStoredProcedureName { get; set; }
        /// <summary> Value and type setting for stored procedure parameters. Example: &quot;{Parameter1: {value: &quot;1&quot;, type: &quot;int&quot;}}&quot;. </summary>
        public IDictionary<string, StoredProcedureParameter> StoredProcedureParameters { get; }
        /// <summary> Which additional types to produce. </summary>
        public object ProduceAdditionalTypes { get; set; }
    }
}
