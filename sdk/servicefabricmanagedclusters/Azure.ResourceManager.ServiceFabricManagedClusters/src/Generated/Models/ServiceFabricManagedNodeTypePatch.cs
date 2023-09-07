// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Node type update request. </summary>
    public partial class ServiceFabricManagedNodeTypePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedNodeTypePatch"/>. </summary>
        public ServiceFabricManagedNodeTypePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedNodeTypePatch"/>. </summary>
        /// <param name="tags"> Node type update parameters. </param>
        /// <param name="sku"> The node type sku. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricManagedNodeTypePatch(IDictionary<string, string> tags, NodeTypeSku sku, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Sku = sku;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Node type update parameters. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The node type sku. </summary>
        public NodeTypeSku Sku { get; set; }
    }
}
