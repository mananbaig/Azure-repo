// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Response of payload to be passed while installing VM agent. </summary>
    public partial class NewRelicObservabilityVmExtensionPayload
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityVmExtensionPayload"/>. </summary>
        internal NewRelicObservabilityVmExtensionPayload()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityVmExtensionPayload"/>. </summary>
        /// <param name="ingestionKey"> Ingestion key of the account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityVmExtensionPayload(string ingestionKey, Dictionary<string, BinaryData> rawData)
        {
            IngestionKey = ingestionKey;
            _rawData = rawData;
        }

        /// <summary> Ingestion key of the account. </summary>
        public string IngestionKey { get; }
    }
}
