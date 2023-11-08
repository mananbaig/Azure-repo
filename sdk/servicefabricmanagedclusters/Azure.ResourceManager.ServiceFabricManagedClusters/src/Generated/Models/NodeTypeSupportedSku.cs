// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes a node type supported sku. </summary>
    public partial class NodeTypeSupportedSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NodeTypeSupportedSku"/>. </summary>
        internal NodeTypeSupportedSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NodeTypeSupportedSku"/>. </summary>
        /// <param name="name"> The sku name. </param>
        /// <param name="tier"> Specifies the tier of the node type. &lt;br /&gt;&lt;br /&gt; Possible Values:&lt;br /&gt; **Standard**. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NodeTypeSupportedSku(string name, string tier, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The sku name. </summary>
        public string Name { get; }
        /// <summary> Specifies the tier of the node type. &lt;br /&gt;&lt;br /&gt; Possible Values:&lt;br /&gt; **Standard**. </summary>
        public string Tier { get; }
    }
}
