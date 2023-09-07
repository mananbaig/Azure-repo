// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.TrafficManager.Models;

namespace Azure.ResourceManager.TrafficManager
{
    /// <summary>
    /// A class representing the TrafficManagerUserMetric data model.
    /// Class representing Traffic Manager User Metrics.
    /// </summary>
    public partial class TrafficManagerUserMetricData : TrafficManagerProxyResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TrafficManagerUserMetricData"/>. </summary>
        public TrafficManagerUserMetricData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrafficManagerUserMetricData"/>. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="resourceType"> The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles. </param>
        /// <param name="key"> The key returned by the User Metrics operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrafficManagerUserMetricData(ResourceIdentifier id, string name, ResourceType? resourceType, string key, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            Key = key;
        }

        /// <summary> The key returned by the User Metrics operation. </summary>
        public string Key { get; set; }
    }
}
