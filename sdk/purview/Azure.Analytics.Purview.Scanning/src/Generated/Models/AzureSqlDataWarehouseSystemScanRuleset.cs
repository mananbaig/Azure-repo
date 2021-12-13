// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSqlDataWarehouseSystemScanRuleset. </summary>
    public partial class AzureSqlDataWarehouseSystemScanRuleset : SystemScanRuleset
    {
        /// <summary> Initializes a new instance of AzureSqlDataWarehouseSystemScanRuleset. </summary>
        public AzureSqlDataWarehouseSystemScanRuleset()
        {
            Kind = DataSourceType.None;
        }

        /// <summary> Initializes a new instance of AzureSqlDataWarehouseSystemScanRuleset. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
        /// <param name="kind"></param>
        /// <param name="properties"></param>
        internal AzureSqlDataWarehouseSystemScanRuleset(string id, string name, ScanRulesetType? scanRulesetType, ScanRulesetStatus? status, int? version, DataSourceType kind, AzureSqlDataWarehouseSystemScanRulesetProperties properties) : base(id, name, scanRulesetType, status, version, kind)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AzureSqlDataWarehouseSystemScanRulesetProperties Properties { get; set; }
    }
}
