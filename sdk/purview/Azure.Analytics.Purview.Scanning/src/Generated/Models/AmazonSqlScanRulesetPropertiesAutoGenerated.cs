// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AmazonSqlScanRulesetPropertiesAutoGenerated. </summary>
    public partial class AmazonSqlScanRulesetPropertiesAutoGenerated : AmazonSqlScanRulesetProperties
    {
        /// <summary> Initializes a new instance of AmazonSqlScanRulesetPropertiesAutoGenerated. </summary>
        public AmazonSqlScanRulesetPropertiesAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of AmazonSqlScanRulesetPropertiesAutoGenerated. </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="excludedSystemClassifications"></param>
        /// <param name="includedCustomClassificationRuleNames"></param>
        /// <param name="lastModifiedAt"></param>
        internal AmazonSqlScanRulesetPropertiesAutoGenerated(DateTimeOffset? createdAt, string description, IList<string> excludedSystemClassifications, IList<string> includedCustomClassificationRuleNames, DateTimeOffset? lastModifiedAt) : base(createdAt, description, excludedSystemClassifications, includedCustomClassificationRuleNames, lastModifiedAt)
        {
        }
    }
}
