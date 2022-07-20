// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    /// <summary> A class representing the ContentKeyPolicy data model. </summary>
    public partial class ContentKeyPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of ContentKeyPolicyData. </summary>
        public ContentKeyPolicyData()
        {
            Options = new ChangeTrackingList<ContentKeyPolicyOption>();
        }

        /// <summary> Initializes a new instance of ContentKeyPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="policyId"> The legacy Policy ID. </param>
        /// <param name="created"> The creation date of the Policy. </param>
        /// <param name="lastModified"> The last modified date of the Policy. </param>
        /// <param name="description"> A description for the Policy. </param>
        /// <param name="options"> The Key Policy options. </param>
        internal ContentKeyPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? policyId, DateTimeOffset? created, DateTimeOffset? lastModified, string description, IList<ContentKeyPolicyOption> options) : base(id, name, resourceType, systemData)
        {
            PolicyId = policyId;
            Created = created;
            LastModified = lastModified;
            Description = description;
            Options = options;
        }

        /// <summary> The legacy Policy ID. </summary>
        public Guid? PolicyId { get; }
        /// <summary> The creation date of the Policy. </summary>
        public DateTimeOffset? Created { get; }
        /// <summary> The last modified date of the Policy. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> A description for the Policy. </summary>
        public string Description { get; set; }
        /// <summary> The Key Policy options. </summary>
        public IList<ContentKeyPolicyOption> Options { get; }
    }
}
