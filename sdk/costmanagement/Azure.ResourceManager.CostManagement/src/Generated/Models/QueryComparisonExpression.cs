// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The comparison expression to be used in the query. </summary>
    public partial class QueryComparisonExpression
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueryComparisonExpression"/>. </summary>
        /// <param name="name"> The name of the column to use in comparison. </param>
        /// <param name="operator"> The operator to use for comparison. </param>
        /// <param name="values"> Array of values to use for comparison. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="values"/> is null. </exception>
        public QueryComparisonExpression(string name, QueryOperatorType @operator, IEnumerable<string> values)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(values, nameof(values));

            Name = name;
            Operator = @operator;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="QueryComparisonExpression"/>. </summary>
        /// <param name="name"> The name of the column to use in comparison. </param>
        /// <param name="operator"> The operator to use for comparison. </param>
        /// <param name="values"> Array of values to use for comparison. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryComparisonExpression(string name, QueryOperatorType @operator, IList<string> values, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Operator = @operator;
            Values = values;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryComparisonExpression"/> for deserialization. </summary>
        internal QueryComparisonExpression()
        {
        }

        /// <summary> The name of the column to use in comparison. </summary>
        public string Name { get; }
        /// <summary> The operator to use for comparison. </summary>
        public QueryOperatorType Operator { get; }
        /// <summary> Array of values to use for comparison. </summary>
        public IList<string> Values { get; }
    }
}
