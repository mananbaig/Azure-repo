// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ManagementGroups;
using Azure.ResourceManager.ManagementGroups.Models;

namespace Azure.ResourceManager.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ResourceManagerModelFactory
    {
        /// <summary> Initializes a new instance of ManagementGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tenantId"> The AAD Tenant ID associated with the management group. For example, 00000000-0000-0000-0000-000000000000. </param>
        /// <param name="displayName"> The friendly name of the management group. </param>
        /// <param name="details"> The details of a management group. </param>
        /// <param name="children"> The list of children. </param>
        /// <returns> A new <see cref="ManagementGroups.ManagementGroupData"/> instance for mocking. </returns>
        public static ManagementGroupData ManagementGroupData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Guid? tenantId = null, string displayName = null, ManagementGroupInfo details = null, IEnumerable<ManagementGroupChildInfo> children = null)
        {
            children ??= new List<ManagementGroupChildInfo>();

            return new ManagementGroupData(id, name, resourceType, systemData, tenantId, displayName, details, children?.ToList());
        }

        /// <summary> Initializes a new instance of ManagementGroupInfo. </summary>
        /// <param name="version"> The version number of the object. </param>
        /// <param name="updatedOn"> The date and time when this object was last updated. </param>
        /// <param name="updatedBy"> The identity of the principal or process that updated the object. </param>
        /// <param name="parent"> (Optional) The ID of the parent management group. </param>
        /// <param name="path"> The path from the root to the current group. </param>
        /// <param name="managementGroupAncestors"> The ancestors of the management group. </param>
        /// <param name="managementGroupAncestorChain"> The ancestors of the management group displayed in reversed order, from immediate parent to the root. </param>
        /// <returns> A new <see cref="ManagementGroups.Models.ManagementGroupInfo"/> instance for mocking. </returns>
        public static ManagementGroupInfo ManagementGroupInfo(int? version = null, DateTimeOffset? updatedOn = null, string updatedBy = null, ParentManagementGroupInfo parent = null, IEnumerable<ManagementGroupPathElement> path = null, IEnumerable<string> managementGroupAncestors = null, IEnumerable<ManagementGroupPathElement> managementGroupAncestorChain = null)
        {
            path ??= new List<ManagementGroupPathElement>();
            managementGroupAncestors ??= new List<string>();
            managementGroupAncestorChain ??= new List<ManagementGroupPathElement>();

            return new ManagementGroupInfo(version, updatedOn, updatedBy, parent, path?.ToList(), managementGroupAncestors?.ToList(), managementGroupAncestorChain?.ToList());
        }

        /// <summary> Initializes a new instance of ParentManagementGroupInfo. </summary>
        /// <param name="id"> The fully qualified ID for the parent management group.  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </param>
        /// <param name="name"> The name of the parent management group. </param>
        /// <param name="displayName"> The friendly name of the parent management group. </param>
        /// <returns> A new <see cref="ManagementGroups.Models.ParentManagementGroupInfo"/> instance for mocking. </returns>
        public static ParentManagementGroupInfo ParentManagementGroupInfo(string id = null, string name = null, string displayName = null)
        {
            return new ParentManagementGroupInfo(id, name, displayName);
        }

        /// <summary> Initializes a new instance of ManagementGroupPathElement. </summary>
        /// <param name="name"> The name of the group. </param>
        /// <param name="displayName"> The friendly name of the group. </param>
        /// <returns> A new <see cref="ManagementGroups.Models.ManagementGroupPathElement"/> instance for mocking. </returns>
        public static ManagementGroupPathElement ManagementGroupPathElement(string name = null, string displayName = null)
        {
            return new ManagementGroupPathElement(name, displayName);
        }

        /// <summary> Initializes a new instance of ManagementGroupChildInfo. </summary>
        /// <param name="childType"> The fully qualified resource type which includes provider namespace (e.g. Microsoft.Management/managementGroups). </param>
        /// <param name="id"> The fully qualified ID for the child resource (management group or subscription).  For example, /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000. </param>
        /// <param name="name"> The name of the child entity. </param>
        /// <param name="displayName"> The friendly name of the child resource. </param>
        /// <param name="children"> The list of children. </param>
        /// <returns> A new <see cref="ManagementGroups.Models.ManagementGroupChildInfo"/> instance for mocking. </returns>
        public static ManagementGroupChildInfo ManagementGroupChildInfo(ManagementGroupChildType? childType = null, string id = null, string name = null, string displayName = null, IEnumerable<ManagementGroupChildInfo> children = null)
        {
            children ??= new List<ManagementGroupChildInfo>();

            return new ManagementGroupChildInfo(childType, id, name, displayName, children?.ToList());
        }

        /// <summary> Initializes a new instance of DescendantData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="displayName"> The friendly name of the management group. </param>
        /// <param name="parentId"> The ID of the parent management group. </param>
        /// <returns> A new <see cref="ManagementGroups.Models.DescendantData"/> instance for mocking. </returns>
        public static DescendantData DescendantData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string displayName = null, ResourceIdentifier parentId = null)
        {
            return new DescendantData(id, name, resourceType, systemData, displayName, parentId != null ? new DescendantParentGroupInfo(parentId) : null);
        }

        /// <summary> Initializes a new instance of ManagementGroupNameAvailabilityResult. </summary>
        /// <param name="nameAvailable"> Required. True indicates name is valid and available. False indicates the name is invalid, unavailable, or both. </param>
        /// <param name="reason"> Required if nameAvailable == false. Invalid indicates the name provided does not match the resource provider's naming requirements (incorrect length, unsupported characters, etc.) AlreadyExists indicates that the name is already in use and is therefore unavailable. </param>
        /// <param name="message"> Required if nameAvailable == false. Localized. If reason == invalid, provide the user with the reason why the given name is invalid, and provide the resource naming requirements so that the user can select a valid name. If reason == AlreadyExists, explain that is already in use, and direct them to select a different name. </param>
        /// <returns> A new <see cref="ManagementGroups.Models.ManagementGroupNameAvailabilityResult"/> instance for mocking. </returns>
        public static ManagementGroupNameAvailabilityResult ManagementGroupNameAvailabilityResult(bool? nameAvailable = null, ManagementGroupNameUnavailableReason? reason = null, string message = null)
        {
            return new ManagementGroupNameAvailabilityResult(nameAvailable, reason, message);
        }
    }
}
