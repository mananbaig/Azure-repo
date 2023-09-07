// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Dynatrace Environment Information. </summary>
    public partial class DynatraceEnvironmentInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DynatraceEnvironmentInfo"/>. </summary>
        public DynatraceEnvironmentInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceEnvironmentInfo"/>. </summary>
        /// <param name="environmentId"> Id of the environment created. </param>
        /// <param name="ingestionKey"> Ingestion key of the environment. </param>
        /// <param name="logsIngestionEndpoint"> Ingestion endpoint used for sending logs. </param>
        /// <param name="landingUri"> Landing URL for Dynatrace environment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceEnvironmentInfo(string environmentId, string ingestionKey, Uri logsIngestionEndpoint, Uri landingUri, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EnvironmentId = environmentId;
            IngestionKey = ingestionKey;
            LogsIngestionEndpoint = logsIngestionEndpoint;
            LandingUri = landingUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Id of the environment created. </summary>
        public string EnvironmentId { get; set; }
        /// <summary> Ingestion key of the environment. </summary>
        public string IngestionKey { get; set; }
        /// <summary> Ingestion endpoint used for sending logs. </summary>
        public Uri LogsIngestionEndpoint { get; set; }
        /// <summary> Landing URL for Dynatrace environment. </summary>
        public Uri LandingUri { get; set; }
    }
}
