// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    /// <summary> EnabledResourceType definition. </summary>
    public partial class CustomLocationEnabledResourceType : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomLocationEnabledResourceType"/>. </summary>
        public CustomLocationEnabledResourceType()
        {
            TypesMetadata = new ChangeTrackingList<CustomLocationEnabledResourceTypeMetadata>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomLocationEnabledResourceType"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="clusterExtensionId"> Cluster Extension ID. </param>
        /// <param name="extensionType"> Cluster Extension Type. </param>
        /// <param name="typesMetadata"> Metadata of the Resource Type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomLocationEnabledResourceType(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier clusterExtensionId, string extensionType, IList<CustomLocationEnabledResourceTypeMetadata> typesMetadata, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ClusterExtensionId = clusterExtensionId;
            ExtensionType = extensionType;
            TypesMetadata = typesMetadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Cluster Extension ID. </summary>
        public ResourceIdentifier ClusterExtensionId { get; set; }
        /// <summary> Cluster Extension Type. </summary>
        public string ExtensionType { get; set; }
        /// <summary> Metadata of the Resource Type. </summary>
        public IList<CustomLocationEnabledResourceTypeMetadata> TypesMetadata { get; }
    }
}
