// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServices.Models;

namespace Azure.ResourceManager.RecoveryServices
{
    /// <summary>
    /// A class representing the RecoveryServicesVault data model.
    /// Resource information, as returned by the resource provider.
    /// </summary>
    public partial class RecoveryServicesVaultData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultData"/>. </summary>
        /// <param name="location"> The location. </param>
        public RecoveryServicesVaultData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="sku"> Identifies the unique system identifier for each Azure resource. </param>
        /// <param name="etag"> Optional ETag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryServicesVaultData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, RecoveryServicesVaultProperties properties, RecoveryServicesSku sku, ETag? etag, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Properties = properties;
            Sku = sku;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryServicesVaultData"/> for deserialization. </summary>
        internal RecoveryServicesVaultData()
        {
        }

        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Properties of the vault. </summary>
        public RecoveryServicesVaultProperties Properties { get; set; }
        /// <summary> Identifies the unique system identifier for each Azure resource. </summary>
        public RecoveryServicesSku Sku { get; set; }
        /// <summary> Optional ETag. </summary>
        public ETag? ETag { get; set; }
    }
}
