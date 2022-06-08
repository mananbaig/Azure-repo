// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Azure resource. This resource is tracked in Azure Resource Manager. </summary>
    public partial class AppServiceResource : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceResource"/>. </summary>
        /// <param name="location"> The location. </param>
        public AppServiceResource(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal AppServiceResource(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string kind) : base(id, name, resourceType, systemData, tags, location)
        {
            Kind = kind;
        }

        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
