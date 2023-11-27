// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity source for SAP HANA source. </summary>
    public partial class SapHanaSource : TabularSource
    {
        /// <summary> Initializes a new instance of SapHanaSource. </summary>
        public SapHanaSource()
        {
            Type = "SapHanaSource";
        }

        /// <summary> Initializes a new instance of SapHanaSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="query"> SAP HANA Sql query. Type: string (or Expression with resultType string). </param>
        /// <param name="packetSize"> The packet size of data read from SAP HANA. Type: integer(or Expression with resultType integer). </param>
        /// <param name="partitionOption"> The partition mechanism that will be used for SAP HANA read in parallel. Possible values include: "None", "PhysicalPartitionsOfTable", "SapHanaDynamicRange". </param>
        /// <param name="partitionSettings"> The settings that will be leveraged for SAP HANA source partitioning. </param>
        internal SapHanaSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, object additionalColumns, object query, object packetSize, object partitionOption, SapHanaPartitionSettings partitionSettings) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            Query = query;
            PacketSize = packetSize;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            Type = type ?? "SapHanaSource";
        }

        /// <summary> SAP HANA Sql query. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> The packet size of data read from SAP HANA. Type: integer(or Expression with resultType integer). </summary>
        public object PacketSize { get; set; }
        /// <summary> The partition mechanism that will be used for SAP HANA read in parallel. Possible values include: "None", "PhysicalPartitionsOfTable", "SapHanaDynamicRange". </summary>
        public object PartitionOption { get; set; }
        /// <summary> The settings that will be leveraged for SAP HANA source partitioning. </summary>
        public SapHanaPartitionSettings PartitionSettings { get; set; }
    }
}
