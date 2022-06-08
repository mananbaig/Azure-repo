// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the CsmPublishingCredentialsPoliciesEntity data model. </summary>
    public partial class CsmPublishingCredentialsPoliciesEntityData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of <see cref="CsmPublishingCredentialsPoliciesEntityData"/>. </summary>
        public CsmPublishingCredentialsPoliciesEntityData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CsmPublishingCredentialsPoliciesEntityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="allow"> &lt;code&gt;true&lt;/code&gt; to allow access to a publishing method; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        internal CsmPublishingCredentialsPoliciesEntityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, bool? allow) : base(id, name, resourceType, systemData, kind)
        {
            Allow = allow;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; to allow access to a publishing method; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? Allow { get; set; }
    }
}
