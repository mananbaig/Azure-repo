// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Information about location (for example: features that it supports). </summary>
    public partial class RedisEnterpriseLocationInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseLocationInfo"/>. </summary>
        internal RedisEnterpriseLocationInfo()
        {
            Capabilities = new ChangeTrackingList<RedisEnterpriseCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseLocationInfo"/>. </summary>
        /// <param name="location"> Location name. </param>
        /// <param name="capabilities"> List of capabilities. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterpriseLocationInfo(AzureLocation? location, IReadOnlyList<RedisEnterpriseCapability> capabilities, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Capabilities = capabilities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Location name. </summary>
        public AzureLocation? Location { get; }
        /// <summary> List of capabilities. </summary>
        public IReadOnlyList<RedisEnterpriseCapability> Capabilities { get; }
    }
}
