// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Resource provider information. </summary>
    public partial class TenantResourceProvider
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TenantResourceProvider"/>. </summary>
        internal TenantResourceProvider()
        {
            ResourceTypes = new ChangeTrackingList<ProviderResourceType>();
        }

        /// <summary> Initializes a new instance of <see cref="TenantResourceProvider"/>. </summary>
        /// <param name="namespace"> The namespace of the resource provider. </param>
        /// <param name="resourceTypes"> The collection of provider resource types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TenantResourceProvider(string @namespace, IReadOnlyList<ProviderResourceType> resourceTypes, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Namespace = @namespace;
            ResourceTypes = resourceTypes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The namespace of the resource provider. </summary>
        public string Namespace { get; }
        /// <summary> The collection of provider resource types. </summary>
        public IReadOnlyList<ProviderResourceType> ResourceTypes { get; }
    }
}
