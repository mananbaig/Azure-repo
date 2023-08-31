// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Result of listing dimensions. It contains a list of available dimensions. </summary>
    internal partial class CostManagementDimensionsListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CostManagementDimensionsListResult"/>. </summary>
        internal CostManagementDimensionsListResult()
        {
            Value = new ChangeTrackingList<CostManagementDimension>();
        }

        /// <summary> Initializes a new instance of <see cref="CostManagementDimensionsListResult"/>. </summary>
        /// <param name="value"> The list of dimensions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CostManagementDimensionsListResult(IReadOnlyList<CostManagementDimension> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The list of dimensions. </summary>
        public IReadOnlyList<CostManagementDimension> Value { get; }
    }
}
