// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagementGroups.Models
{
    /// <summary> Management group creation parameters. </summary>
    public partial class ManagementGroupCreateOrUpdateContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagementGroupCreateOrUpdateContent"/>. </summary>
        public ManagementGroupCreateOrUpdateContent()
        {
            Children = new ChangeTrackingList<ManagementGroupChildOptions>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagementGroupCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The fully qualified ID for the management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </param>
        /// <param name="resourceType"> The type of the resource.  For example, Microsoft.Management/managementGroups. </param>
        /// <param name="name"> The name of the management group. For example, 00000000-0000-0000-0000-000000000000. </param>
        /// <param name="tenantId"> The AAD Tenant ID associated with the management group. For example, 00000000-0000-0000-0000-000000000000. </param>
        /// <param name="displayName"> The friendly name of the management group. If no value is passed then this  field will be set to the groupId. </param>
        /// <param name="details"> The details of a management group used during creation. </param>
        /// <param name="children"> The list of children. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagementGroupCreateOrUpdateContent(string id, ResourceType? resourceType, string name, Guid? tenantId, string displayName, CreateManagementGroupDetails details, IReadOnlyList<ManagementGroupChildOptions> children, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ResourceType = resourceType;
            Name = name;
            TenantId = tenantId;
            DisplayName = displayName;
            Details = details;
            Children = children;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The fully qualified ID for the management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </summary>
        public string Id { get; }
        /// <summary> The type of the resource.  For example, Microsoft.Management/managementGroups. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The name of the management group. For example, 00000000-0000-0000-0000-000000000000. </summary>
        public string Name { get; set; }
        /// <summary> The AAD Tenant ID associated with the management group. For example, 00000000-0000-0000-0000-000000000000. </summary>
        public Guid? TenantId { get; }
        /// <summary> The friendly name of the management group. If no value is passed then this  field will be set to the groupId. </summary>
        public string DisplayName { get; set; }
        /// <summary> The details of a management group used during creation. </summary>
        public CreateManagementGroupDetails Details { get; set; }
        /// <summary> The list of children. </summary>
        public IReadOnlyList<ManagementGroupChildOptions> Children { get; }
    }
}
