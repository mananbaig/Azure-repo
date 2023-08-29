// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Hub Item. </summary>
    public partial class ConnectivityHub
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivityHub"/>. </summary>
        public ConnectivityHub()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityHub"/>. </summary>
        /// <param name="resourceId"> Resource Id. </param>
        /// <param name="resourceType"> Resource Type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityHub(ResourceIdentifier resourceId, ResourceType? resourceType, Dictionary<string, BinaryData> rawData)
        {
            ResourceId = resourceId;
            ResourceType = resourceType;
            _rawData = rawData;
        }

        /// <summary> Resource Id. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Resource Type. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
