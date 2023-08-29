// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the DSC Meta Configuration. </summary>
    public partial class DscMetaConfiguration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DscMetaConfiguration"/>. </summary>
        internal DscMetaConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DscMetaConfiguration"/>. </summary>
        /// <param name="configurationModeFrequencyMins"> Gets or sets the ConfigurationModeFrequencyMins value of the meta configuration. </param>
        /// <param name="rebootNodeIfNeeded"> Gets or sets the RebootNodeIfNeeded value of the meta configuration. </param>
        /// <param name="configurationMode"> Gets or sets the ConfigurationMode value of the meta configuration. </param>
        /// <param name="actionAfterReboot"> Gets or sets the ActionAfterReboot value of the meta configuration. </param>
        /// <param name="certificateId"> Gets or sets the CertificateId value of the meta configuration. </param>
        /// <param name="refreshFrequencyMins"> Gets or sets the RefreshFrequencyMins value of the meta configuration. </param>
        /// <param name="allowModuleOverwrite"> Gets or sets the AllowModuleOverwrite value of the meta configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DscMetaConfiguration(int? configurationModeFrequencyMins, bool? rebootNodeIfNeeded, string configurationMode, string actionAfterReboot, string certificateId, int? refreshFrequencyMins, bool? allowModuleOverwrite, Dictionary<string, BinaryData> rawData)
        {
            ConfigurationModeFrequencyMins = configurationModeFrequencyMins;
            RebootNodeIfNeeded = rebootNodeIfNeeded;
            ConfigurationMode = configurationMode;
            ActionAfterReboot = actionAfterReboot;
            CertificateId = certificateId;
            RefreshFrequencyMins = refreshFrequencyMins;
            AllowModuleOverwrite = allowModuleOverwrite;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the ConfigurationModeFrequencyMins value of the meta configuration. </summary>
        public int? ConfigurationModeFrequencyMins { get; }
        /// <summary> Gets or sets the RebootNodeIfNeeded value of the meta configuration. </summary>
        public bool? RebootNodeIfNeeded { get; }
        /// <summary> Gets or sets the ConfigurationMode value of the meta configuration. </summary>
        public string ConfigurationMode { get; }
        /// <summary> Gets or sets the ActionAfterReboot value of the meta configuration. </summary>
        public string ActionAfterReboot { get; }
        /// <summary> Gets or sets the CertificateId value of the meta configuration. </summary>
        public string CertificateId { get; }
        /// <summary> Gets or sets the RefreshFrequencyMins value of the meta configuration. </summary>
        public int? RefreshFrequencyMins { get; }
        /// <summary> Gets or sets the AllowModuleOverwrite value of the meta configuration. </summary>
        public bool? AllowModuleOverwrite { get; }
    }
}
