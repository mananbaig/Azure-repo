// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> NumberGreaterThanOrEquals Advanced Filter. </summary>
    public partial class NumberGreaterThanOrEqualsAdvancedFilter : AdvancedFilter
    {
        /// <summary> Initializes a new instance of <see cref="NumberGreaterThanOrEqualsAdvancedFilter"/>. </summary>
        public NumberGreaterThanOrEqualsAdvancedFilter()
        {
            OperatorType = AdvancedFilterOperatorType.NumberGreaterThanOrEquals;
        }

        /// <summary> Initializes a new instance of <see cref="NumberGreaterThanOrEqualsAdvancedFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="value"> The filter value. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NumberGreaterThanOrEqualsAdvancedFilter(AdvancedFilterOperatorType operatorType, string key, double? value, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(operatorType, key, serializedAdditionalRawData)
        {
            Value = value;
            OperatorType = operatorType;
        }

        /// <summary> The filter value. </summary>
        public double? Value { get; set; }
    }
}
