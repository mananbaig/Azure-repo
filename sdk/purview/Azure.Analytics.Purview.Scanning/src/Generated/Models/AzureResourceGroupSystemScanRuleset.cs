// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureResourceGroupSystemScanRuleset. </summary>
    public partial class AzureResourceGroupSystemScanRuleset : SystemScanRuleset
    {
        /// <summary> Initializes a new instance of AzureResourceGroupSystemScanRuleset. </summary>
        public AzureResourceGroupSystemScanRuleset()
        {
            Kind = DataSourceType.None;
        }

        /// <summary> Initializes a new instance of AzureResourceGroupSystemScanRuleset. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
        /// <param name="kind"></param>
        /// <param name="properties"></param>
        internal AzureResourceGroupSystemScanRuleset(string id, string name, ScanRulesetType? scanRulesetType, ScanRulesetStatus? status, int? version, DataSourceType kind, AzureResourceGroupSystemScanRulesetProperties properties) : base(id, name, scanRulesetType, status, version, kind)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AzureResourceGroupSystemScanRulesetProperties Properties { get; set; }
    }
}
