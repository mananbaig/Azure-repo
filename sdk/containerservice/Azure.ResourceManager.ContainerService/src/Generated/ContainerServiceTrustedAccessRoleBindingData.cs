// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ContainerService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerService
{
    /// <summary>
    /// A class representing the ContainerServiceTrustedAccessRoleBinding data model.
    /// Defines binding between a resource and role
    /// </summary>
    public partial class ContainerServiceTrustedAccessRoleBindingData : ResourceData
    {
        /// <summary> Initializes a new instance of ContainerServiceTrustedAccessRoleBindingData. </summary>
        /// <param name="sourceResourceId"> The ARM resource ID of source resource that trusted access is configured for. </param>
        /// <param name="roles"> A list of roles to bind, each item is a resource type qualified role name. For example: 'Microsoft.MachineLearningServices/workspaces/reader'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceResourceId"/> or <paramref name="roles"/> is null. </exception>
        public ContainerServiceTrustedAccessRoleBindingData(ResourceIdentifier sourceResourceId, IEnumerable<string> roles)
        {
            Argument.AssertNotNull(sourceResourceId, nameof(sourceResourceId));
            Argument.AssertNotNull(roles, nameof(roles));

            SourceResourceId = sourceResourceId;
            Roles = roles.ToList();
        }

        /// <summary> Initializes a new instance of ContainerServiceTrustedAccessRoleBindingData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The current provisioning state of trusted access role binding. </param>
        /// <param name="sourceResourceId"> The ARM resource ID of source resource that trusted access is configured for. </param>
        /// <param name="roles"> A list of roles to bind, each item is a resource type qualified role name. For example: 'Microsoft.MachineLearningServices/workspaces/reader'. </param>
        internal ContainerServiceTrustedAccessRoleBindingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ContainerServiceTrustedAccessRoleBindingProvisioningState? provisioningState, ResourceIdentifier sourceResourceId, IList<string> roles) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            SourceResourceId = sourceResourceId;
            Roles = roles;
        }

        /// <summary> The current provisioning state of trusted access role binding. </summary>
        public ContainerServiceTrustedAccessRoleBindingProvisioningState? ProvisioningState { get; }
        /// <summary> The ARM resource ID of source resource that trusted access is configured for. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary> A list of roles to bind, each item is a resource type qualified role name. For example: 'Microsoft.MachineLearningServices/workspaces/reader'. </summary>
        public IList<string> Roles { get; }
    }
}
