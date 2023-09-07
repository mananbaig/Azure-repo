// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> NumberInRange Filter. </summary>
    public partial class NumberInRangeFilter : EventGridFilter
    {
        /// <summary> Initializes a new instance of <see cref="NumberInRangeFilter"/>. </summary>
        public NumberInRangeFilter()
        {
            Values = new ChangeTrackingList<IList<double>>();
            OperatorType = FilterOperatorType.NumberInRange;
        }

        /// <summary> Initializes a new instance of <see cref="NumberInRangeFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="values"> The set of filter values. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NumberInRangeFilter(FilterOperatorType operatorType, string key, IList<IList<double>> values, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(operatorType, key, serializedAdditionalRawData)
        {
            Values = values;
            OperatorType = operatorType;
        }

        /// <summary> The set of filter values. </summary>
        public IList<IList<double>> Values { get; }
    }
}
