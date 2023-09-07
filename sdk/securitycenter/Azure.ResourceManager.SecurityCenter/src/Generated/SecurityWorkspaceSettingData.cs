// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the SecurityWorkspaceSetting data model.
    /// Configures where to store the OMS agent data for workspaces under a scope
    /// </summary>
    public partial class SecurityWorkspaceSettingData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityWorkspaceSettingData"/>. </summary>
        public SecurityWorkspaceSettingData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityWorkspaceSettingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="workspaceId"> The full Azure ID of the workspace to save the data in. </param>
        /// <param name="scope"> All the VMs in this scope will send their security data to the mentioned workspace unless overridden by a setting with more specific scope. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityWorkspaceSettingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier workspaceId, string scope, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            WorkspaceId = workspaceId;
            Scope = scope;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The full Azure ID of the workspace to save the data in. </summary>
        public ResourceIdentifier WorkspaceId { get; set; }
        /// <summary> All the VMs in this scope will send their security data to the mentioned workspace unless overridden by a setting with more specific scope. </summary>
        public string Scope { get; set; }
    }
}
