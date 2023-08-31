// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The Dimensions or Tags to filter a budget by. </summary>
    public partial class BudgetFilterProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BudgetFilterProperties"/>. </summary>
        public BudgetFilterProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BudgetFilterProperties"/>. </summary>
        /// <param name="dimensions"> Has comparison expression for a dimension. </param>
        /// <param name="tags"> Has comparison expression for a tag. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BudgetFilterProperties(BudgetComparisonExpression dimensions, BudgetComparisonExpression tags, Dictionary<string, BinaryData> rawData)
        {
            Dimensions = dimensions;
            Tags = tags;
            _rawData = rawData;
        }

        /// <summary> Has comparison expression for a dimension. </summary>
        public BudgetComparisonExpression Dimensions { get; set; }
        /// <summary> Has comparison expression for a tag. </summary>
        public BudgetComparisonExpression Tags { get; set; }
    }
}
