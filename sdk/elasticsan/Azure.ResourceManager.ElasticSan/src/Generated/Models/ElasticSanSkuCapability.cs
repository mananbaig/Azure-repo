// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> The capability information in the specified SKU. </summary>
    public partial class ElasticSanSkuCapability
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ElasticSanSkuCapability"/>. </summary>
        internal ElasticSanSkuCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ElasticSanSkuCapability"/>. </summary>
        /// <param name="name"> The name of capability. </param>
        /// <param name="value"> A string value to indicate states of given capability. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ElasticSanSkuCapability(string name, string value, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of capability. </summary>
        public string Name { get; }
        /// <summary> A string value to indicate states of given capability. </summary>
        public string Value { get; }
    }
}
