// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service resource
    /// </summary>
    public partial class ServiceResource : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceResource class.
        /// </summary>
        public ServiceResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceResource class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The GEO location of the resource.</param>
        /// <param name="tags">Tags of the service which is a list of key value
        /// pairs that describe the resource.</param>
        /// <param name="properties">Properties of the Service resource</param>
        /// <param name="sku">Sku of the Service resource</param>
        public ServiceResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ClusterResourceProperties properties = default(ClusterResourceProperties), Sku sku = default(Sku))
            : base(id, name, type, location, tags)
        {
            Properties = properties;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets properties of the Service resource
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ClusterResourceProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets sku of the Service resource
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
