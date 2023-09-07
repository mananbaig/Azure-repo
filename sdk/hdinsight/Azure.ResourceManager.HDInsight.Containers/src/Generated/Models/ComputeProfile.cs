// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The compute profile. </summary>
    internal partial class ComputeProfile
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ComputeProfile"/>. </summary>
        /// <param name="nodes"> The nodes definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nodes"/> is null. </exception>
        public ComputeProfile(IEnumerable<ClusterComputeNodeProfile> nodes)
        {
            Argument.AssertNotNull(nodes, nameof(nodes));

            Nodes = nodes.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ComputeProfile"/>. </summary>
        /// <param name="nodes"> The nodes definitions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ComputeProfile(IList<ClusterComputeNodeProfile> nodes, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Nodes = nodes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ComputeProfile"/> for deserialization. </summary>
        internal ComputeProfile()
        {
        }

        /// <summary> The nodes definitions. </summary>
        public IList<ClusterComputeNodeProfile> Nodes { get; }
    }
}
