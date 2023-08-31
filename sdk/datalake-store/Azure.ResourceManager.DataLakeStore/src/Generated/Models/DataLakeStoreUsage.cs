// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    /// <summary> Describes the Resource Usage. </summary>
    public partial class DataLakeStoreUsage
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreUsage"/>. </summary>
        internal DataLakeStoreUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataLakeStoreUsage"/>. </summary>
        /// <param name="unit"> Gets the unit of measurement. </param>
        /// <param name="id"> Resource identifier. </param>
        /// <param name="currentValue"> Gets the current count of the allocated resources in the subscription. </param>
        /// <param name="limit"> Gets the maximum count of the resources that can be allocated in the subscription. </param>
        /// <param name="name"> Gets the name of the type of usage. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataLakeStoreUsage(DataLakeStoreUsageUnit? unit, ResourceIdentifier id, int? currentValue, int? limit, DataLakeStoreUsageName name, Dictionary<string, BinaryData> rawData)
        {
            Unit = unit;
            Id = id;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Gets the unit of measurement. </summary>
        public DataLakeStoreUsageUnit? Unit { get; }
        /// <summary> Resource identifier. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Gets the current count of the allocated resources in the subscription. </summary>
        public int? CurrentValue { get; }
        /// <summary> Gets the maximum count of the resources that can be allocated in the subscription. </summary>
        public int? Limit { get; }
        /// <summary> Gets the name of the type of usage. </summary>
        public DataLakeStoreUsageName Name { get; }
    }
}
