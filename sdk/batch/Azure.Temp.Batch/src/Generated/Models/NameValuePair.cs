// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Temp.Batch.Models
{
    /// <summary> Represents a name-value pair. </summary>
    public partial class NameValuePair
    {
        /// <summary> Initializes a new instance of NameValuePair. </summary>
        internal NameValuePair()
        {
        }

        /// <summary> Initializes a new instance of NameValuePair. </summary>
        /// <param name="name"> The name in the name-value pair. </param>
        /// <param name="value"> The value in the name-value pair. </param>
        internal NameValuePair(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary> The name in the name-value pair. </summary>
        public string Name { get; }
        /// <summary> The value in the name-value pair. </summary>
        public string Value { get; }
    }
}
