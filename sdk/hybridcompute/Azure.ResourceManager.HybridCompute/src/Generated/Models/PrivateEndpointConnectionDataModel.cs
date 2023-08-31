// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> The Data Model for a Private Endpoint Connection associated with a Private Link Scope. </summary>
    public partial class PrivateEndpointConnectionDataModel : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionDataModel"/>. </summary>
        internal PrivateEndpointConnectionDataModel()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PrivateEndpointConnectionDataModel"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The Private Endpoint Connection properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateEndpointConnectionDataModel(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, PrivateEndpointConnectionProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The Private Endpoint Connection properties. </summary>
        public PrivateEndpointConnectionProperties Properties { get; }
    }
}
