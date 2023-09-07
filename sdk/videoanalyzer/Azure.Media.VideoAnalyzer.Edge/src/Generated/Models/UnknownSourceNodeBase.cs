// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The UnknownSourceNodeBase. </summary>
    internal partial class UnknownSourceNodeBase : SourceNodeBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSourceNodeBase"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSourceNodeBase(string type, string name, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(type, name, serializedAdditionalRawData)
        {
            Type = type ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSourceNodeBase"/> for deserialization. </summary>
        internal UnknownSourceNodeBase()
        {
        }
    }
}
