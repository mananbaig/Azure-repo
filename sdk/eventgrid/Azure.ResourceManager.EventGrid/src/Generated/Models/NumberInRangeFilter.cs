// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> NumberInRange Filter. </summary>
    public partial class NumberInRangeFilter : EventGridFilter
    {
        /// <summary> Initializes a new instance of NumberInRangeFilter. </summary>
        public NumberInRangeFilter()
        {
            Values = new Core.ChangeTrackingList<IList<double>>();
            OperatorType = FilterOperatorType.NumberInRange;
        }

        /// <summary> Initializes a new instance of NumberInRangeFilter. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="values"> The set of filter values. </param>
        internal NumberInRangeFilter(FilterOperatorType operatorType, string key, IList<IList<double>> values) : base(operatorType, key)
        {
            Values = values;
            OperatorType = operatorType;
        }

        /// <summary> The set of filter values. </summary>
        public IList<IList<double>> Values { get; }
    }
}
