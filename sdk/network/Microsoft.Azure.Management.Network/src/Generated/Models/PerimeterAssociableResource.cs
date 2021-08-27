// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource that is onboarded to use network security perimeter. Also
    /// referred as perimeter associable resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PerimeterAssociableResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PerimeterAssociableResource
        /// class.
        /// </summary>
        public PerimeterAssociableResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PerimeterAssociableResource
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="displayName">A friendly name for the properties of
        /// perimeter associable resources.</param>
        /// <param name="resourceType">Resource type/provider name.</param>
        /// <param name="publicDnsZones">Public DNS zone names of the
        /// resources.</param>
        public PerimeterAssociableResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string displayName = default(string), string resourceType = default(string), IList<string> publicDnsZones = default(IList<string>))
            : base(id, name, type, location, tags)
        {
            DisplayName = displayName;
            ResourceType = resourceType;
            PublicDnsZones = publicDnsZones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a friendly name for the properties of perimeter associable
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets resource type/provider name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceType")]
        public string ResourceType { get; private set; }

        /// <summary>
        /// Gets public DNS zone names of the resources.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicDnsZones")]
        public IList<string> PublicDnsZones { get; private set; }

    }
}
