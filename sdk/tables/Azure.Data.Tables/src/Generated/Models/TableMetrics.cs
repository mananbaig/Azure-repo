// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Data.Tables;

namespace Azure.Data.Tables.Models
{
    /// <summary> The Metrics. </summary>
    public partial class TableMetrics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TableMetrics"/>. </summary>
        /// <param name="enabled"> Indicates whether metrics are enabled for the Table service. </param>
        public TableMetrics(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of <see cref="TableMetrics"/>. </summary>
        /// <param name="version"> The version of Analytics to configure. </param>
        /// <param name="enabled"> Indicates whether metrics are enabled for the Table service. </param>
        /// <param name="includeApis"> Indicates whether metrics should generate summary statistics for called API operations. </param>
        /// <param name="retentionPolicy"> The retention policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TableMetrics(string version, bool enabled, bool? includeApis, TableRetentionPolicy retentionPolicy, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Version = version;
            Enabled = enabled;
            IncludeApis = includeApis;
            RetentionPolicy = retentionPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TableMetrics"/> for deserialization. </summary>
        internal TableMetrics()
        {
        }

        /// <summary> The version of Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether metrics are enabled for the Table service. </summary>
        public bool Enabled { get; set; }
        /// <summary> The retention policy. </summary>
        public TableRetentionPolicy RetentionPolicy { get; set; }
    }
}
