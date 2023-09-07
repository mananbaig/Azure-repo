// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> List of SKU Information objects. </summary>
    internal partial class ElasticSanSkuInformationList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ElasticSanSkuInformationList"/>. </summary>
        internal ElasticSanSkuInformationList()
        {
            Value = new ChangeTrackingList<ElasticSanSkuInformation>();
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanSkuInformationList"/>. </summary>
        /// <param name="value"> List of ResourceType Sku. </param>
        /// <param name="nextLink"> URI to fetch the next section of the paginated response. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticSanSkuInformationList(IReadOnlyList<ElasticSanSkuInformation> value, string nextLink, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of ResourceType Sku. </summary>
        public IReadOnlyList<ElasticSanSkuInformation> Value { get; }
        /// <summary> URI to fetch the next section of the paginated response. </summary>
        public string NextLink { get; }
    }
}
