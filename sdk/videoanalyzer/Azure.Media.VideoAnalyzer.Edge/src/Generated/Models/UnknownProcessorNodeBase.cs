// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The UnknownProcessorNodeBase. </summary>
    internal partial class UnknownProcessorNodeBase : ProcessorNodeBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownProcessorNodeBase"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownProcessorNodeBase(string type, string name, IList<NodeInput> inputs, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(type, name, inputs, serializedAdditionalRawData)
        {
            Type = type ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownProcessorNodeBase"/> for deserialization. </summary>
        internal UnknownProcessorNodeBase()
        {
        }
    }
}
