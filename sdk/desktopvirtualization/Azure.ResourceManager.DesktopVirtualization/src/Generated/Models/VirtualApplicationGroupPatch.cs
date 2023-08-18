// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> ApplicationGroup properties that can be patched. </summary>
    public partial class VirtualApplicationGroupPatch : ResourceData
    {
        /// <summary> Initializes a new instance of VirtualApplicationGroupPatch. </summary>
        public VirtualApplicationGroupPatch()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of VirtualApplicationGroupPatch. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> tags to be updated. </param>
        /// <param name="description"> Description of ApplicationGroup. </param>
        /// <param name="friendlyName"> Friendly name of ApplicationGroup. </param>
        internal VirtualApplicationGroupPatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, string description, string friendlyName) : base(id, name, resourceType, systemData)
        {
            Tags = tags;
            Description = description;
            FriendlyName = friendlyName;
        }

        /// <summary> tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Description of ApplicationGroup. </summary>
        public string Description { get; set; }
        /// <summary> Friendly name of ApplicationGroup. </summary>
        public string FriendlyName { get; set; }
    }
}
