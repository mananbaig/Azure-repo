// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The PowerBIDelegatedScan. </summary>
    public partial class PowerBIDelegatedScan : Scan
    {
        /// <summary> Initializes a new instance of PowerBIDelegatedScan. </summary>
        public PowerBIDelegatedScan()
        {
            Kind = ScanAuthorizationType.PowerBIDelegated;
        }

        /// <summary> Initializes a new instance of PowerBIDelegatedScan. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="scanResults"></param>
        /// <param name="properties"></param>
        internal PowerBIDelegatedScan(string id, string name, ScanAuthorizationType kind, IReadOnlyList<ScanResult> scanResults, PowerBIDelegatedScanPropertiesAutoGenerated properties) : base(id, name, kind, scanResults)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public PowerBIDelegatedScanPropertiesAutoGenerated Properties { get; set; }
    }
}
