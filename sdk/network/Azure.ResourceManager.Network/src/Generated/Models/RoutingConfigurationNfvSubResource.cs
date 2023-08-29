// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Reference to RouteTableV3 associated with the connection. </summary>
    public partial class RoutingConfigurationNfvSubResource
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RoutingConfigurationNfvSubResource"/>. </summary>
        public RoutingConfigurationNfvSubResource()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RoutingConfigurationNfvSubResource"/>. </summary>
        /// <param name="resourceUri"> Resource ID. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingConfigurationNfvSubResource(Uri resourceUri, Dictionary<string, BinaryData> rawData)
        {
            ResourceUri = resourceUri;
            _rawData = rawData;
        }

        /// <summary> Resource ID. </summary>
        public Uri ResourceUri { get; set; }
    }
}
