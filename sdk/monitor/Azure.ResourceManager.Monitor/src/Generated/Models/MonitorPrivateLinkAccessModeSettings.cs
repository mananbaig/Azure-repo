// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Properties that define the scope private link mode settings. </summary>
    public partial class MonitorPrivateLinkAccessModeSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitorPrivateLinkAccessModeSettings"/>. </summary>
        /// <param name="queryAccessMode"> Specifies the default access mode of queries through associated private endpoints in scope. If not specified default value is 'Open'. You can override this default setting for a specific private endpoint connection by adding an exclusion in the 'exclusions' array. </param>
        /// <param name="ingestionAccessMode"> Specifies the default access mode of ingestion through associated private endpoints in scope. If not specified default value is 'Open'. You can override this default setting for a specific private endpoint connection by adding an exclusion in the 'exclusions' array. </param>
        public MonitorPrivateLinkAccessModeSettings(MonitorPrivateLinkAccessMode queryAccessMode, MonitorPrivateLinkAccessMode ingestionAccessMode)
        {
            QueryAccessMode = queryAccessMode;
            IngestionAccessMode = ingestionAccessMode;
            Exclusions = new ChangeTrackingList<MonitorPrivateLinkAccessModeSettingsExclusion>();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorPrivateLinkAccessModeSettings"/>. </summary>
        /// <param name="queryAccessMode"> Specifies the default access mode of queries through associated private endpoints in scope. If not specified default value is 'Open'. You can override this default setting for a specific private endpoint connection by adding an exclusion in the 'exclusions' array. </param>
        /// <param name="ingestionAccessMode"> Specifies the default access mode of ingestion through associated private endpoints in scope. If not specified default value is 'Open'. You can override this default setting for a specific private endpoint connection by adding an exclusion in the 'exclusions' array. </param>
        /// <param name="exclusions"> List of exclusions that override the default access mode settings for specific private endpoint connections. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitorPrivateLinkAccessModeSettings(MonitorPrivateLinkAccessMode queryAccessMode, MonitorPrivateLinkAccessMode ingestionAccessMode, IList<MonitorPrivateLinkAccessModeSettingsExclusion> exclusions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            QueryAccessMode = queryAccessMode;
            IngestionAccessMode = ingestionAccessMode;
            Exclusions = exclusions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorPrivateLinkAccessModeSettings"/> for deserialization. </summary>
        internal MonitorPrivateLinkAccessModeSettings()
        {
        }

        /// <summary> Specifies the default access mode of queries through associated private endpoints in scope. If not specified default value is 'Open'. You can override this default setting for a specific private endpoint connection by adding an exclusion in the 'exclusions' array. </summary>
        public MonitorPrivateLinkAccessMode QueryAccessMode { get; set; }
        /// <summary> Specifies the default access mode of ingestion through associated private endpoints in scope. If not specified default value is 'Open'. You can override this default setting for a specific private endpoint connection by adding an exclusion in the 'exclusions' array. </summary>
        public MonitorPrivateLinkAccessMode IngestionAccessMode { get; set; }
        /// <summary> List of exclusions that override the default access mode settings for specific private endpoint connections. </summary>
        public IList<MonitorPrivateLinkAccessModeSettingsExclusion> Exclusions { get; }
    }
}
