// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing the Geographic hierarchy used with the Geographic
    /// traffic routing method.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class TrafficManagerGeographicHierarchy : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the TrafficManagerGeographicHierarchy
        /// class.
        /// </summary>
        public TrafficManagerGeographicHierarchy()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficManagerGeographicHierarchy
        /// class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Network/trafficmanagerProfiles.</param>
        /// <param name="geographicHierarchy">The region at the root of the
        /// hierarchy from all the regions in the hierarchy can be
        /// retrieved.</param>
        public TrafficManagerGeographicHierarchy(string id = default(string), string name = default(string), string type = default(string), Region geographicHierarchy = default(Region))
            : base(id, name, type)
        {
            GeographicHierarchy = geographicHierarchy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the region at the root of the hierarchy from all the
        /// regions in the hierarchy can be retrieved.
        /// </summary>
        [JsonProperty(PropertyName = "properties.geographicHierarchy")]
        public Region GeographicHierarchy { get; set; }

    }
}
