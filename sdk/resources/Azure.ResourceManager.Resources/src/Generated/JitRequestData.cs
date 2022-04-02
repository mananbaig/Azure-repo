// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the JitRequest data model. </summary>
    public partial class JitRequestData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of JitRequestData. </summary>
        /// <param name="location"> The location. </param>
        public JitRequestData(AzureLocation location) : base(location)
        {
            JitAuthorizationPolicies = new ChangeTrackingList<JitAuthorizationPolicies>();
        }

        /// <summary> Initializes a new instance of JitRequestData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="applicationResourceId"> The parent application id. </param>
        /// <param name="publisherTenantId"> The publisher tenant id. </param>
        /// <param name="jitAuthorizationPolicies"> The JIT authorization policies. </param>
        /// <param name="jitSchedulingPolicy"> The JIT request properties. </param>
        /// <param name="provisioningState"> The JIT request provisioning state. </param>
        /// <param name="jitRequestState"> The JIT request state. </param>
        /// <param name="createdBy"> The client entity that created the JIT request. </param>
        /// <param name="updatedBy"> The client entity that last updated the JIT request. </param>
        internal JitRequestData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string applicationResourceId, string publisherTenantId, IList<JitAuthorizationPolicies> jitAuthorizationPolicies, JitSchedulingPolicy jitSchedulingPolicy, ResourcesProvisioningState? provisioningState, JitRequestState? jitRequestState, ArmApplicationDetails createdBy, ArmApplicationDetails updatedBy) : base(id, name, resourceType, systemData, tags, location)
        {
            ApplicationResourceId = applicationResourceId;
            PublisherTenantId = publisherTenantId;
            JitAuthorizationPolicies = jitAuthorizationPolicies;
            JitSchedulingPolicy = jitSchedulingPolicy;
            ProvisioningState = provisioningState;
            JitRequestState = jitRequestState;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
        }

        /// <summary> The parent application id. </summary>
        public string ApplicationResourceId { get; set; }
        /// <summary> The publisher tenant id. </summary>
        public string PublisherTenantId { get; }
        /// <summary> The JIT authorization policies. </summary>
        public IList<JitAuthorizationPolicies> JitAuthorizationPolicies { get; }
        /// <summary> The JIT request properties. </summary>
        public JitSchedulingPolicy JitSchedulingPolicy { get; set; }
        /// <summary> The JIT request provisioning state. </summary>
        public ResourcesProvisioningState? ProvisioningState { get; }
        /// <summary> The JIT request state. </summary>
        public JitRequestState? JitRequestState { get; }
        /// <summary> The client entity that created the JIT request. </summary>
        public ArmApplicationDetails CreatedBy { get; }
        /// <summary> The client entity that last updated the JIT request. </summary>
        public ArmApplicationDetails UpdatedBy { get; }
    }
}
