// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration service environment sku capacity. </summary>
    public partial class IntegrationServiceEnvironmentSkuCapacity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentSkuCapacity"/>. </summary>
        internal IntegrationServiceEnvironmentSkuCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationServiceEnvironmentSkuCapacity"/>. </summary>
        /// <param name="minimum"> The minimum capacity. </param>
        /// <param name="maximum"> The maximum capacity. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="scaleType"> The sku scale type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationServiceEnvironmentSkuCapacity(int? minimum, int? maximum, int? @default, IntegrationServiceEnvironmentSkuScaleType? scaleType, Dictionary<string, BinaryData> rawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
            _rawData = rawData;
        }

        /// <summary> The minimum capacity. </summary>
        public int? Minimum { get; }
        /// <summary> The maximum capacity. </summary>
        public int? Maximum { get; }
        /// <summary> The default capacity. </summary>
        public int? Default { get; }
        /// <summary> The sku scale type. </summary>
        public IntegrationServiceEnvironmentSkuScaleType? ScaleType { get; }
    }
}
