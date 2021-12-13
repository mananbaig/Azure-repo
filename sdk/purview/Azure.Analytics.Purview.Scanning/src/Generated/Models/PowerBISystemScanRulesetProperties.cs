// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The PowerBISystemScanRulesetProperties. </summary>
    public partial class PowerBISystemScanRulesetProperties : PowerBIScanRulesetProperties
    {
        /// <summary> Initializes a new instance of PowerBISystemScanRulesetProperties. </summary>
        public PowerBISystemScanRulesetProperties()
        {
        }

        /// <summary> Initializes a new instance of PowerBISystemScanRulesetProperties. </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="excludedSystemClassifications"></param>
        /// <param name="includedCustomClassificationRuleNames"></param>
        /// <param name="lastModifiedAt"></param>
        internal PowerBISystemScanRulesetProperties(DateTimeOffset? createdAt, string description, IList<string> excludedSystemClassifications, IList<string> includedCustomClassificationRuleNames, DateTimeOffset? lastModifiedAt) : base(createdAt, description, excludedSystemClassifications, includedCustomClassificationRuleNames, lastModifiedAt)
        {
        }
    }
}
