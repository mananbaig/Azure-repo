// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Kusto SKU description of given resource type
    /// </summary>
    public partial class SkuDescription
    {
        /// <summary>
        /// Initializes a new instance of the SkuDescription class.
        /// </summary>
        public SkuDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SkuDescription class.
        /// </summary>
        /// <param name="resourceType">The resource type</param>
        /// <param name="name">The name of the SKU</param>
        /// <param name="size">The size of the SKU</param>
        /// <param name="locations">The set of locations that the SKU is
        /// available</param>
        /// <param name="locationInfo">Locations and zones</param>
        /// <param name="restrictions">The restrictions because of which SKU
        /// cannot be used</param>
        public SkuDescription(string resourceType = default(string), string name = default(string), string size = default(string), IList<string> locations = default(IList<string>), IList<SkuLocationInfoItem> locationInfo = default(IList<SkuLocationInfoItem>), IList<object> restrictions = default(IList<object>))
        {
            ResourceType = resourceType;
            Name = name;
            Size = size;
            Locations = locations;
            LocationInfo = locationInfo;
            Restrictions = restrictions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource type
        /// </summary>
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets the name of the SKU
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the size of the SKU
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; private set; }

        /// <summary>
        /// Gets the set of locations that the SKU is available
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<string> Locations { get; private set; }

        /// <summary>
        /// Gets locations and zones
        /// </summary>
        [JsonProperty(PropertyName = "locationInfo")]
        public IList<SkuLocationInfoItem> LocationInfo { get; private set; }

        /// <summary>
        /// Gets the restrictions because of which SKU cannot be used
        /// </summary>
        [JsonProperty(PropertyName = "restrictions")]
        public IList<object> Restrictions { get; private set; }

    }
}
