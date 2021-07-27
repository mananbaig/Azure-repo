// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> Managed HSM resource. </summary>
    public partial class ManagedHsmResource : TrackedResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of ManagedHsmResource. </summary>
        /// <param name="location"> The location. </param>
        public ManagedHsmResource(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ManagedHsmResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="sku"> SKU details. </param>
        /// <param name="systemData"> Metadata pertaining to creation and last modification of the key vault resource. </param>
        internal ManagedHsmResource(ResourceGroupResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, ManagedHsmSku sku, SystemData systemData) : base(id, name, type, location, tags)
        {
            Sku = sku;
            SystemData = systemData;
        }

        /// <summary> SKU details. </summary>
        public ManagedHsmSku Sku { get; set; }
        /// <summary> Metadata pertaining to creation and last modification of the key vault resource. </summary>
        public SystemData SystemData { get; }
    }
}
