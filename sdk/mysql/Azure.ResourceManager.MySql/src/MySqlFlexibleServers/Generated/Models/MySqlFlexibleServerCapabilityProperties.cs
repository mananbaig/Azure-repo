// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Location capabilities. </summary>
    public partial class MySqlFlexibleServerCapabilityProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerCapabilityProperties"/>. </summary>
        internal MySqlFlexibleServerCapabilityProperties()
        {
            SupportedHAMode = new ChangeTrackingList<string>();
            SupportedGeoBackupRegions = new ChangeTrackingList<string>();
            SupportedFlexibleServerEditions = new ChangeTrackingList<MySqlFlexibleServerEditionCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerCapabilityProperties"/>. </summary>
        /// <param name="zone"> zone name. </param>
        /// <param name="supportedHAMode"> Supported high availability mode. </param>
        /// <param name="supportedGeoBackupRegions"> supported geo backup regions. </param>
        /// <param name="supportedFlexibleServerEditions"> A list of supported flexible server editions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlFlexibleServerCapabilityProperties(string zone, IReadOnlyList<string> supportedHAMode, IReadOnlyList<string> supportedGeoBackupRegions, IReadOnlyList<MySqlFlexibleServerEditionCapability> supportedFlexibleServerEditions, Dictionary<string, BinaryData> rawData)
        {
            Zone = zone;
            SupportedHAMode = supportedHAMode;
            SupportedGeoBackupRegions = supportedGeoBackupRegions;
            SupportedFlexibleServerEditions = supportedFlexibleServerEditions;
            _rawData = rawData;
        }

        /// <summary> zone name. </summary>
        public string Zone { get; }
        /// <summary> Supported high availability mode. </summary>
        public IReadOnlyList<string> SupportedHAMode { get; }
        /// <summary> supported geo backup regions. </summary>
        public IReadOnlyList<string> SupportedGeoBackupRegions { get; }
        /// <summary> A list of supported flexible server editions. </summary>
        public IReadOnlyList<MySqlFlexibleServerEditionCapability> SupportedFlexibleServerEditions { get; }
    }
}
