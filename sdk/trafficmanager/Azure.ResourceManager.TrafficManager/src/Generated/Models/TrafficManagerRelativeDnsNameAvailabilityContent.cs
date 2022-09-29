// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Parameters supplied to check Traffic Manager name operation. </summary>
    public partial class TrafficManagerRelativeDnsNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of TrafficManagerRelativeDnsNameAvailabilityContent. </summary>
        public TrafficManagerRelativeDnsNameAvailabilityContent()
        {
        }

        /// <summary> The name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> The type of the resource. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
