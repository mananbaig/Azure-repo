// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Grafana.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Grafana
{
    /// <summary>
    /// A class representing the ManagedGrafana data model.
    /// The grafana resource type.
    /// </summary>
    public partial class ManagedGrafanaData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedGrafanaData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ManagedGrafanaData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedGrafanaData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The Sku of the grafana resource. </param>
        /// <param name="properties"> Properties specific to the grafana resource. </param>
        /// <param name="identity"> The managed identity of the grafana resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedGrafanaData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedGrafanaSku sku, ManagedGrafanaProperties properties, ManagedServiceIdentity identity, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Properties = properties;
            Identity = identity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedGrafanaData"/> for deserialization. </summary>
        internal ManagedGrafanaData()
        {
        }

        /// <summary> The Sku of the grafana resource. </summary>
        internal ManagedGrafanaSku Sku { get; set; }
        /// <summary> Gets or sets the sku name. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new ManagedGrafanaSku(value);
        }

        /// <summary> Properties specific to the grafana resource. </summary>
        public ManagedGrafanaProperties Properties { get; set; }
        /// <summary> The managed identity of the grafana resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
