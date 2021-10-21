// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity source for Amazon Redshift Source. </summary>
    public partial class AmazonRedshiftSource : TabularSource
    {
        /// <summary> Initializes a new instance of AmazonRedshiftSource. </summary>
        public AmazonRedshiftSource()
        {
            Type = "AmazonRedshiftSource";
        }

        /// <summary> Initializes a new instance of AmazonRedshiftSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        /// <param name="query"> Database query. Type: string (or Expression with resultType string). </param>
        /// <param name="redshiftUnloadSettings"> The Amazon S3 settings needed for the interim Amazon S3 when copying from Amazon Redshift with unload. With this, data from Amazon Redshift source will be unloaded into S3 first and then copied into the targeted sink from the interim S3. </param>
        internal AmazonRedshiftSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, object additionalColumns, object query, RedshiftUnloadSettings redshiftUnloadSettings) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            Query = query;
            RedshiftUnloadSettings = redshiftUnloadSettings;
            Type = type ?? "AmazonRedshiftSource";
        }

        /// <summary> Database query. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
        /// <summary> The Amazon S3 settings needed for the interim Amazon S3 when copying from Amazon Redshift with unload. With this, data from Amazon Redshift source will be unloaded into S3 first and then copied into the targeted sink from the interim S3. </summary>
        public RedshiftUnloadSettings RedshiftUnloadSettings { get; set; }
    }
}
