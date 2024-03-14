// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Export command settings.
    /// Please note <see cref="ExportSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureDatabricksDeltaLakeExportCommand"/> and <see cref="SnowflakeExportCopyCommand"/>.
    /// </summary>
    public abstract partial class ExportSettings
    {
        /// <summary> Initializes a new instance of <see cref="ExportSettings"/>. </summary>
        protected ExportSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="ExportSettings"/>. </summary>
        /// <param name="type"> The export setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ExportSettings(string type, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The export setting type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
