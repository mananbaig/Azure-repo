// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The partition level usage data for a usage request. </summary>
    public partial class PartitionUsage : CosmosDBBaseUsage
    {
        /// <summary> Initializes a new instance of <see cref="PartitionUsage"/>. </summary>
        internal PartitionUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PartitionUsage"/>. </summary>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="name"> The name information for the metric. </param>
        /// <param name="quotaPeriod"> The quota period used to summarize the usage values. </param>
        /// <param name="limit"> Maximum value for this metric. </param>
        /// <param name="currentValue"> Current value for this metric. </param>
        /// <param name="partitionId"> The partition id (GUID identifier) of the usages. </param>
        /// <param name="partitionKeyRangeId"> The partition key range id (integer identifier) of the usages. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PartitionUsage(CosmosDBMetricUnitType? unit, CosmosDBMetricName name, string quotaPeriod, long? limit, long? currentValue, Guid? partitionId, string partitionKeyRangeId, Dictionary<string, BinaryData> rawData) : base(unit, name, quotaPeriod, limit, currentValue, rawData)
        {
            PartitionId = partitionId;
            PartitionKeyRangeId = partitionKeyRangeId;
        }

        /// <summary> The partition id (GUID identifier) of the usages. </summary>
        public Guid? PartitionId { get; }
        /// <summary> The partition key range id (integer identifier) of the usages. </summary>
        public string PartitionKeyRangeId { get; }
    }
}
