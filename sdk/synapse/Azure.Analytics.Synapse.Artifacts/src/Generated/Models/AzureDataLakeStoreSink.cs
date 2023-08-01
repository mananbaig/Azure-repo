// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity Azure Data Lake Store sink. </summary>
    public partial class AzureDataLakeStoreSink : CopySink
    {
        /// <summary> Initializes a new instance of AzureDataLakeStoreSink. </summary>
        public AzureDataLakeStoreSink()
        {
            Type = "AzureDataLakeStoreSink";
        }

        /// <summary> Initializes a new instance of AzureDataLakeStoreSink. </summary>
        /// <param name="type"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. Type: string (or Expression with resultType string). </param>
        /// <param name="enableAdlsSingleFileParallel"> Single File Parallel. </param>
        internal AzureDataLakeStoreSink(string type, object writeBatchSize, object writeBatchTimeout, object sinkRetryCount, object sinkRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object copyBehavior, object enableAdlsSingleFileParallel) : base(type, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, additionalProperties)
        {
            CopyBehavior = copyBehavior;
            EnableAdlsSingleFileParallel = enableAdlsSingleFileParallel;
            Type = type ?? "AzureDataLakeStoreSink";
        }

        /// <summary> The type of copy behavior for copy sink. Type: string (or Expression with resultType string). </summary>
        public object CopyBehavior { get; set; }
        /// <summary> Single File Parallel. </summary>
        public object EnableAdlsSingleFileParallel { get; set; }
    }
}
