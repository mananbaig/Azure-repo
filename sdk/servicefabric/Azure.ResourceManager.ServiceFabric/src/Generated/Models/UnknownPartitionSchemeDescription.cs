// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The UnknownPartitionSchemeDescription. </summary>
    internal partial class UnknownPartitionSchemeDescription : PartitionSchemeDescription
    {
        /// <summary> Initializes a new instance of <see cref="UnknownPartitionSchemeDescription"/>. </summary>
        /// <param name="partitionScheme"> Specifies how the service is partitioned. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownPartitionSchemeDescription(ApplicationPartitionScheme partitionScheme, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(partitionScheme, serializedAdditionalRawData)
        {
            PartitionScheme = partitionScheme;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownPartitionSchemeDescription"/> for deserialization. </summary>
        internal UnknownPartitionSchemeDescription()
        {
        }
    }
}
