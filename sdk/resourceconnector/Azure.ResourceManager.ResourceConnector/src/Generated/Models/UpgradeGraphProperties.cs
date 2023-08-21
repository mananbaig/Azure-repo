// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceConnector.Models
{
    /// <summary> The Upgrade Graph Properties for appliance. </summary>
    public partial class UpgradeGraphProperties
    {
        /// <summary> Initializes a new instance of UpgradeGraphProperties. </summary>
        internal UpgradeGraphProperties()
        {
            SupportedVersions = new ChangeTrackingList<SupportedVersion>();
        }

        /// <summary> Initializes a new instance of UpgradeGraphProperties. </summary>
        /// <param name="applianceVersion"> The current appliance version. </param>
        /// <param name="supportedVersions"> This contains the current version and supported upgrade versions. </param>
        internal UpgradeGraphProperties(string applianceVersion, IReadOnlyList<SupportedVersion> supportedVersions)
        {
            ApplianceVersion = applianceVersion;
            SupportedVersions = supportedVersions;
        }

        /// <summary> The current appliance version. </summary>
        public string ApplianceVersion { get; }
        /// <summary> This contains the current version and supported upgrade versions. </summary>
        public IReadOnlyList<SupportedVersion> SupportedVersions { get; }
    }
}
