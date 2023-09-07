// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> SKU parameters supplied to the create Redis operation. </summary>
    public partial class RedisSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisSku"/>. </summary>
        /// <param name="name"> The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium). </param>
        /// <param name="family"> The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium). </param>
        /// <param name="capacity"> The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P (Premium) family (1, 2, 3, 4). </param>
        public RedisSku(RedisSkuName name, RedisSkuFamily family, int capacity)
        {
            Name = name;
            Family = family;
            Capacity = capacity;
        }

        /// <summary> Initializes a new instance of <see cref="RedisSku"/>. </summary>
        /// <param name="name"> The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium). </param>
        /// <param name="family"> The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium). </param>
        /// <param name="capacity"> The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P (Premium) family (1, 2, 3, 4). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisSku(RedisSkuName name, RedisSkuFamily family, int capacity, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Family = family;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisSku"/> for deserialization. </summary>
        internal RedisSku()
        {
        }

        /// <summary> The type of Redis cache to deploy. Valid values: (Basic, Standard, Premium). </summary>
        public RedisSkuName Name { get; set; }
        /// <summary> The SKU family to use. Valid values: (C, P). (C = Basic/Standard, P = Premium). </summary>
        public RedisSkuFamily Family { get; set; }
        /// <summary> The size of the Redis cache to deploy. Valid values: for C (Basic/Standard) family (0, 1, 2, 3, 4, 5, 6), for P (Premium) family (1, 2, 3, 4). </summary>
        public int Capacity { get; set; }
    }
}
