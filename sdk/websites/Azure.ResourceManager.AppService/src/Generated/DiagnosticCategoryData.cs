// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the DiagnosticCategory data model. </summary>
    public partial class DiagnosticCategoryData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="DiagnosticCategoryData"/>. </summary>
        public DiagnosticCategoryData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticCategoryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="description"> Description of the diagnostic category. </param>
        internal DiagnosticCategoryData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string description) : base(id, name, resourceType, systemData, kind)
        {
            Description = description;
        }

        /// <summary> Description of the diagnostic category. </summary>
        public string Description { get; }
    }
}
