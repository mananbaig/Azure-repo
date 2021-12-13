// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureStorageMsiScanProperties. </summary>
    public partial class AzureStorageMsiScanProperties : ScanProperties
    {
        /// <summary> Initializes a new instance of AzureStorageMsiScanProperties. </summary>
        public AzureStorageMsiScanProperties()
        {
        }

        /// <summary> Initializes a new instance of AzureStorageMsiScanProperties. </summary>
        /// <param name="scanRulesetName"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="collection"></param>
        /// <param name="workers"></param>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="connectedVia"></param>
        internal AzureStorageMsiScanProperties(string scanRulesetName, ScanRulesetType? scanRulesetType, ScanPropertiesCollection collection, int? workers, DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, ScanPropertiesConnectedVia connectedVia) : base(scanRulesetName, scanRulesetType, collection, workers, createdAt, lastModifiedAt, connectedVia)
        {
        }
    }
}
