// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> List of details about all the available SKUs. </summary>
    internal partial class RegionSkuDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RegionSkuDetails"/>. </summary>
        internal RegionSkuDetails()
        {
            Value = new ChangeTrackingList<RedisEnterpriseRegionSkuDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="RegionSkuDetails"/>. </summary>
        /// <param name="value"> List of Sku Detail. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegionSkuDetails(IReadOnlyList<RedisEnterpriseRegionSkuDetail> value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of Sku Detail. </summary>
        public IReadOnlyList<RedisEnterpriseRegionSkuDetail> Value { get; }
    }
}
