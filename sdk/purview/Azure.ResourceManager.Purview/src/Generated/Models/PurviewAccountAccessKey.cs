// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Purview.Models
{
    /// <summary> The Account access keys. </summary>
    public partial class PurviewAccountAccessKey
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PurviewAccountAccessKey"/>. </summary>
        internal PurviewAccountAccessKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PurviewAccountAccessKey"/>. </summary>
        /// <param name="atlasKafkaPrimaryEndpoint"> Gets or sets the primary connection string. </param>
        /// <param name="atlasKafkaSecondaryEndpoint"> Gets or sets the secondary connection string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PurviewAccountAccessKey(string atlasKafkaPrimaryEndpoint, string atlasKafkaSecondaryEndpoint, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AtlasKafkaPrimaryEndpoint = atlasKafkaPrimaryEndpoint;
            AtlasKafkaSecondaryEndpoint = atlasKafkaSecondaryEndpoint;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the primary connection string. </summary>
        public string AtlasKafkaPrimaryEndpoint { get; }
        /// <summary> Gets or sets the secondary connection string. </summary>
        public string AtlasKafkaSecondaryEndpoint { get; }
    }
}
