// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The SqlServerDatabaseScanRuleset. </summary>
    public partial class SqlServerDatabaseScanRuleset : ScanRuleset
    {
        /// <summary> Initializes a new instance of SqlServerDatabaseScanRuleset. </summary>
        public SqlServerDatabaseScanRuleset()
        {
            Kind = DataSourceType.SqlServerDatabase;
        }

        /// <summary> Initializes a new instance of SqlServerDatabaseScanRuleset. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
        /// <param name="kind"></param>
        /// <param name="properties"></param>
        internal SqlServerDatabaseScanRuleset(string id, string name, ScanRulesetType? scanRulesetType, ScanRulesetStatus? status, int? version, DataSourceType kind, SqlServerDatabaseScanRulesetPropertiesAutoGenerated properties) : base(id, name, scanRulesetType, status, version, kind)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public SqlServerDatabaseScanRulesetPropertiesAutoGenerated Properties { get; set; }
    }
}
