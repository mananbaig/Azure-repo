// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ARM Resource.
    /// </summary>
    public partial class Resource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        public Resource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        /// <param name="id">Resource Id represents the complete path to the
        /// resource.</param>
        /// <param name="name">Resource name associated with the
        /// resource.</param>
        /// <param name="type">Resource type represents the complete path of
        /// the form Namespace/ResourceType/ResourceType/...</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="eTag">Optional ETag.</param>
        public Resource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string eTag = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id represents the complete path to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name associated with the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type represents the complete path of the form
        /// Namespace/ResourceType/ResourceType/...
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets optional ETag.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

    }
}
