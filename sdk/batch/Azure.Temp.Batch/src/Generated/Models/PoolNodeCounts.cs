// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    /// <summary> The number of Compute Nodes in each state for a Pool. </summary>
    public partial class PoolNodeCounts
    {
        /// <summary> Initializes a new instance of PoolNodeCounts. </summary>
        /// <param name="poolId"> The ID of the Pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="poolId"/> is null. </exception>
        internal PoolNodeCounts(string poolId)
        {
            Argument.AssertNotNull(poolId, nameof(poolId));

            PoolId = poolId;
        }

        /// <summary> Initializes a new instance of PoolNodeCounts. </summary>
        /// <param name="poolId"> The ID of the Pool. </param>
        /// <param name="dedicated"> The number of Compute Nodes in each Compute Node state. </param>
        /// <param name="lowPriority"> The number of Compute Nodes in each Compute Node state. </param>
        internal PoolNodeCounts(string poolId, NodeCounts dedicated, NodeCounts lowPriority)
        {
            PoolId = poolId;
            Dedicated = dedicated;
            LowPriority = lowPriority;
        }

        /// <summary> The ID of the Pool. </summary>
        public string PoolId { get; }
        /// <summary> The number of Compute Nodes in each Compute Node state. </summary>
        public NodeCounts Dedicated { get; }
        /// <summary> The number of Compute Nodes in each Compute Node state. </summary>
        public NodeCounts LowPriority { get; }
    }
}
