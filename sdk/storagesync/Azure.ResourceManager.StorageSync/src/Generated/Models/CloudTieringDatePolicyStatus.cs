// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Status of the date policy. </summary>
    public partial class CloudTieringDatePolicyStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudTieringDatePolicyStatus"/>. </summary>
        internal CloudTieringDatePolicyStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudTieringDatePolicyStatus"/>. </summary>
        /// <param name="lastUpdatedOn"> Last updated timestamp. </param>
        /// <param name="tieredFilesMostRecentAccessTimestamp"> Most recent access time of tiered files. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudTieringDatePolicyStatus(DateTimeOffset? lastUpdatedOn, DateTimeOffset? tieredFilesMostRecentAccessTimestamp, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            LastUpdatedOn = lastUpdatedOn;
            TieredFilesMostRecentAccessTimestamp = tieredFilesMostRecentAccessTimestamp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Last updated timestamp. </summary>
        public DateTimeOffset? LastUpdatedOn { get; }
        /// <summary> Most recent access time of tiered files. </summary>
        public DateTimeOffset? TieredFilesMostRecentAccessTimestamp { get; }
    }
}
