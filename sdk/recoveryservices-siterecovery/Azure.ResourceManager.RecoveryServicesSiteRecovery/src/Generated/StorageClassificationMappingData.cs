// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the StorageClassificationMapping data model.
    /// Storage mapping object.
    /// </summary>
    public partial class StorageClassificationMappingData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageClassificationMappingData"/>. </summary>
        internal StorageClassificationMappingData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageClassificationMappingData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Properties of the storage mapping object. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageClassificationMappingData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, StorageClassificationMappingProperties properties, AzureLocation? location, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Properties of the storage mapping object. </summary>
        internal StorageClassificationMappingProperties Properties { get; }
        /// <summary> Target storage object Id. </summary>
        public ResourceIdentifier TargetStorageClassificationId
        {
            get => Properties?.TargetStorageClassificationId;
        }

        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
