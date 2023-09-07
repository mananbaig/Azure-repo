// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> a summary of request statistics grouped by API in hour or minute aggregates for blobs. </summary>
    public partial class BlobMetrics
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobMetrics"/>. </summary>
        /// <param name="version"> The version of Storage Analytics to configure. </param>
        /// <param name="enabled"> Indicates whether metrics are enabled for the Blob service. </param>
        /// <param name="includeApis"> Indicates whether metrics should generate summary statistics for called API operations. </param>
        /// <param name="retentionPolicy"> the retention policy which determines how long the associated data should persist. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobMetrics(string version, bool enabled, bool? includeApis, BlobRetentionPolicy retentionPolicy, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Version = version;
            Enabled = enabled;
            IncludeApis = includeApis;
            RetentionPolicy = retentionPolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The version of Storage Analytics to configure. </summary>
        public string Version { get; set; }
        /// <summary> Indicates whether metrics are enabled for the Blob service. </summary>
        public bool Enabled { get; set; }
        /// <summary> the retention policy which determines how long the associated data should persist. </summary>
        public BlobRetentionPolicy RetentionPolicy { get; set; }
    }
}
