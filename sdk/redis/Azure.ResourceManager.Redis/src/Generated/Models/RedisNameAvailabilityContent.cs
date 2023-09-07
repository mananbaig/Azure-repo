// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    /// <summary> Parameters body to pass for resource name availability check. </summary>
    public partial class RedisNameAvailabilityContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. The only legal value of this property for checking redis cache name availability is 'Microsoft.Cache/redis'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RedisNameAvailabilityContent(string name, ResourceType resourceType)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Initializes a new instance of <see cref="RedisNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. The only legal value of this property for checking redis cache name availability is 'Microsoft.Cache/redis'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisNameAvailabilityContent(string name, ResourceType resourceType, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceType = resourceType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RedisNameAvailabilityContent"/> for deserialization. </summary>
        internal RedisNameAvailabilityContent()
        {
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. The only legal value of this property for checking redis cache name availability is 'Microsoft.Cache/redis'. </summary>
        public ResourceType ResourceType { get; }
    }
}
