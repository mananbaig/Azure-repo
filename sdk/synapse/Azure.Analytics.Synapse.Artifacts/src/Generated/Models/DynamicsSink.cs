// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Dynamics sink. </summary>
    public partial class DynamicsSink : CopySink
    {
        /// <summary> Initializes a new instance of DynamicsSink. </summary>
        /// <param name="writeBehavior"> The write behavior for the operation. </param>
        public DynamicsSink(DynamicsSinkWriteBehavior writeBehavior)
        {
            WriteBehavior = writeBehavior;
            Type = "DynamicsSink";
        }

        /// <summary> Initializes a new instance of DynamicsSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="writeBehavior"> The write behavior for the operation. </param>
        /// <param name="ignoreNullValues"> The flag indicating whether ignore null values from input dataset (except key fields) during write operation. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="alternateKeyName"> The logical name of the alternate key which will be used when upserting records. Type: string (or Expression with resultType string). </param>
        internal DynamicsSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, DynamicsSinkWriteBehavior writeBehavior, object ignoreNullValues, object alternateKeyName) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            WriteBehavior = writeBehavior;
            IgnoreNullValues = ignoreNullValues;
            AlternateKeyName = alternateKeyName;
            Type = type ?? "DynamicsSink";
        }

        /// <summary> The write behavior for the operation. </summary>
        public DynamicsSinkWriteBehavior WriteBehavior { get; set; }
        /// <summary> The flag indicating whether ignore null values from input dataset (except key fields) during write operation. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public object IgnoreNullValues { get; set; }
        /// <summary> The logical name of the alternate key which will be used when upserting records. Type: string (or Expression with resultType string). </summary>
        public object AlternateKeyName { get; set; }
    }
}
