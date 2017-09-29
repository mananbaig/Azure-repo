// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Authorization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provider Operations metadata
    /// </summary>
    public partial class ProviderOperationsMetadata
    {
        /// <summary>
        /// Initializes a new instance of the ProviderOperationsMetadata class.
        /// </summary>
        public ProviderOperationsMetadata()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderOperationsMetadata class.
        /// </summary>
        /// <param name="id">The provider id.</param>
        /// <param name="name">The provider name.</param>
        /// <param name="type">The provider type.</param>
        /// <param name="displayName">The provider display name.</param>
        /// <param name="resourceTypes">The provider resource types</param>
        /// <param name="operations">The provider operations.</param>
        public ProviderOperationsMetadata(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), IList<ResourceType> resourceTypes = default(IList<ResourceType>), IList<ProviderOperation> operations = default(IList<ProviderOperation>))
        {
            Id = id;
            Name = name;
            Type = type;
            DisplayName = displayName;
            ResourceTypes = resourceTypes;
            Operations = operations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the provider id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the provider name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the provider type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the provider display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the provider resource types
        /// </summary>
        [JsonProperty(PropertyName = "resourceTypes")]
        public IList<ResourceType> ResourceTypes { get; set; }

        /// <summary>
        /// Gets or sets the provider operations.
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<ProviderOperation> Operations { get; set; }

    }
}
