// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary>
    /// The type used for update operations of the Catalog.
    /// Serialized Name: CatalogUpdate
    /// </summary>
    public partial class SphereCatalogPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SphereCatalogPatch"/>. </summary>
        public SphereCatalogPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SphereCatalogPatch"/>. </summary>
        /// <param name="tags">
        /// Resource tags.
        /// Serialized Name: CatalogUpdate.tags
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SphereCatalogPatch(IDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Resource tags.
        /// Serialized Name: CatalogUpdate.tags
        /// </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
