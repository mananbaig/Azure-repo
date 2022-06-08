// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Preview for the Static Site Workflow to be generated. </summary>
    public partial class StaticSitesWorkflowPreview : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="StaticSitesWorkflowPreview"/>. </summary>
        public StaticSitesWorkflowPreview()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StaticSitesWorkflowPreview"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="path"> The path for the workflow file to be generated. </param>
        /// <param name="contents"> The contents for the workflow file to be generated. </param>
        internal StaticSitesWorkflowPreview(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, string path, string contents) : base(id, name, resourceType, systemData, kind)
        {
            Path = path;
            Contents = contents;
        }

        /// <summary> The path for the workflow file to be generated. </summary>
        public string Path { get; }
        /// <summary> The contents for the workflow file to be generated. </summary>
        public string Contents { get; }
    }
}
