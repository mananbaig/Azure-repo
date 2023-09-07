// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the named partition scheme of the service. </summary>
    public partial class NamedPartitionSchemeDescription : PartitionSchemeDescription
    {
        /// <summary> Initializes a new instance of <see cref="NamedPartitionSchemeDescription"/>. </summary>
        /// <param name="count"> The number of partitions. </param>
        /// <param name="names"> Array of size specified by the ‘count’ parameter, for the names of the partitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="names"/> is null. </exception>
        public NamedPartitionSchemeDescription(int count, IEnumerable<string> names)
        {
            Argument.AssertNotNull(names, nameof(names));

            Count = count;
            Names = names.ToList();
            PartitionScheme = ApplicationPartitionScheme.Named;
        }

        /// <summary> Initializes a new instance of <see cref="NamedPartitionSchemeDescription"/>. </summary>
        /// <param name="partitionScheme"> Specifies how the service is partitioned. </param>
        /// <param name="count"> The number of partitions. </param>
        /// <param name="names"> Array of size specified by the ‘count’ parameter, for the names of the partitions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NamedPartitionSchemeDescription(ApplicationPartitionScheme partitionScheme, int count, IList<string> names, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(partitionScheme, serializedAdditionalRawData)
        {
            Count = count;
            Names = names;
            PartitionScheme = partitionScheme;
        }

        /// <summary> Initializes a new instance of <see cref="NamedPartitionSchemeDescription"/> for deserialization. </summary>
        internal NamedPartitionSchemeDescription()
        {
        }

        /// <summary> The number of partitions. </summary>
        public int Count { get; set; }
        /// <summary> Array of size specified by the ‘count’ parameter, for the names of the partitions. </summary>
        public IList<string> Names { get; }
    }
}
