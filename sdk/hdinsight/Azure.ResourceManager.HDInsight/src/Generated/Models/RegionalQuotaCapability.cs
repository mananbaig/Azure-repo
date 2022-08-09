// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The regional quota capacity. </summary>
    public partial class RegionalQuotaCapability
    {
        /// <summary> Initializes a new instance of RegionalQuotaCapability. </summary>
        internal RegionalQuotaCapability()
        {
        }

        /// <summary> Initializes a new instance of RegionalQuotaCapability. </summary>
        /// <param name="regionName"> The region name. </param>
        /// <param name="coresUsed"> The number of cores used in the region. </param>
        /// <param name="coresAvailable"> The number of cores available in the region. </param>
        internal RegionalQuotaCapability(string regionName, long? coresUsed, long? coresAvailable)
        {
            RegionName = regionName;
            CoresUsed = coresUsed;
            CoresAvailable = coresAvailable;
        }

        /// <summary> The region name. </summary>
        public string RegionName { get; }
        /// <summary> The number of cores used in the region. </summary>
        public long? CoresUsed { get; }
        /// <summary> The number of cores available in the region. </summary>
        public long? CoresAvailable { get; }
    }
}
