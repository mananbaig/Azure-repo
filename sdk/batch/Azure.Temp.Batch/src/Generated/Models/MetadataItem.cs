// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    /// <summary> The Batch service does not assign any meaning to this metadata; it is solely for the use of user code. </summary>
    public partial class MetadataItem
    {
        /// <summary> Initializes a new instance of MetadataItem. </summary>
        /// <param name="name"> The name of the metadata item. </param>
        /// <param name="value"> The value of the metadata item. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="value"/> is null. </exception>
        public MetadataItem(string name, string value)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(value, nameof(value));

            Name = name;
            Value = value;
        }

        /// <summary> The name of the metadata item. </summary>
        public string Name { get; set; }
        /// <summary> The value of the metadata item. </summary>
        public string Value { get; set; }
    }
}
