// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Represents a metric dimension value. </summary>
    public partial class DimensionValue
    {
        /// <summary> Initializes a new instance of DimensionValue. </summary>
        internal DimensionValue()
        {
        }

        /// <summary> Initializes a new instance of DimensionValue. </summary>
        /// <param name="name"> The name of the dimension. </param>
        /// <param name="value"> The value of the dimension. </param>
        internal DimensionValue(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name of the dimension. </summary>
        public string Name { get; }
        /// <summary> The value of the dimension. </summary>
        public string Value { get; }
    }
}
