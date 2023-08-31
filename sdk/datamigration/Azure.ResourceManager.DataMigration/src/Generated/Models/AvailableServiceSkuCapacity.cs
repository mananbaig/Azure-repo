// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> A description of the scaling capacities of the SKU. </summary>
    public partial class AvailableServiceSkuCapacity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AvailableServiceSkuCapacity"/>. </summary>
        internal AvailableServiceSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AvailableServiceSkuCapacity"/>. </summary>
        /// <param name="minimum"> The minimum capacity, usually 0 or 1. </param>
        /// <param name="maximum"> The maximum capacity. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="scaleType"> The scalability approach. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AvailableServiceSkuCapacity(int? minimum, int? maximum, int? @default, ServiceScalability? scaleType, Dictionary<string, BinaryData> rawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
            _rawData = rawData;
        }

        /// <summary> The minimum capacity, usually 0 or 1. </summary>
        public int? Minimum { get; }
        /// <summary> The maximum capacity. </summary>
        public int? Maximum { get; }
        /// <summary> The default capacity. </summary>
        public int? Default { get; }
        /// <summary> The scalability approach. </summary>
        public ServiceScalability? ScaleType { get; }
    }
}
