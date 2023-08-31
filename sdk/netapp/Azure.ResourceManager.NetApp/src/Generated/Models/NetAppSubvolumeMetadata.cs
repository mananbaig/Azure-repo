// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Result of the post subvolume and action is to get metadata of the subvolume. </summary>
    public partial class NetAppSubvolumeMetadata : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetAppSubvolumeMetadata"/>. </summary>
        internal NetAppSubvolumeMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppSubvolumeMetadata"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="path"> Path to the subvolume. </param>
        /// <param name="parentPath"> Path to the parent subvolume. </param>
        /// <param name="size"> Size of subvolume. </param>
        /// <param name="bytesUsed"> Bytes used. </param>
        /// <param name="permissions"> Permissions of the subvolume. </param>
        /// <param name="createdOn"> Creation time and date. </param>
        /// <param name="accessedOn"> Most recent access time and date. </param>
        /// <param name="modifiedOn"> Most recent modification time and date. </param>
        /// <param name="changedOn"> Most recent change time and date. </param>
        /// <param name="provisioningState"> Azure lifecycle management. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppSubvolumeMetadata(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string path, string parentPath, long? size, long? bytesUsed, string permissions, DateTimeOffset? createdOn, DateTimeOffset? accessedOn, DateTimeOffset? modifiedOn, DateTimeOffset? changedOn, string provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Path = path;
            ParentPath = parentPath;
            Size = size;
            BytesUsed = bytesUsed;
            Permissions = permissions;
            CreatedOn = createdOn;
            AccessedOn = accessedOn;
            ModifiedOn = modifiedOn;
            ChangedOn = changedOn;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Path to the subvolume. </summary>
        public string Path { get; }
        /// <summary> Path to the parent subvolume. </summary>
        public string ParentPath { get; }
        /// <summary> Size of subvolume. </summary>
        public long? Size { get; }
        /// <summary> Bytes used. </summary>
        public long? BytesUsed { get; }
        /// <summary> Permissions of the subvolume. </summary>
        public string Permissions { get; }
        /// <summary> Creation time and date. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Most recent access time and date. </summary>
        public DateTimeOffset? AccessedOn { get; }
        /// <summary> Most recent modification time and date. </summary>
        public DateTimeOffset? ModifiedOn { get; }
        /// <summary> Most recent change time and date. </summary>
        public DateTimeOffset? ChangedOn { get; }
        /// <summary> Azure lifecycle management. </summary>
        public string ProvisioningState { get; }
    }
}
