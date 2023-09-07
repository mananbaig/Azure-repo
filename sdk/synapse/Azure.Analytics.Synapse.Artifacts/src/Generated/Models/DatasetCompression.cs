// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The compression method used on a dataset. </summary>
    public partial class DatasetCompression
    {
        /// <summary> Initializes a new instance of <see cref="DatasetCompression"/>. </summary>
        /// <param name="type"> Type of dataset compression. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> is null. </exception>
        public DatasetCompression(object type)
        {
            Argument.AssertNotNull(type, nameof(type));

            Type = type;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="DatasetCompression"/>. </summary>
        /// <param name="type"> Type of dataset compression. Type: string (or Expression with resultType string). </param>
        /// <param name="level"> The dataset compression level. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DatasetCompression(object type, object level, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            Level = level;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Initializes a new instance of <see cref="DatasetCompression"/> for deserialization. </summary>
        internal DatasetCompression()
        {
        }

        /// <summary> Type of dataset compression. Type: string (or Expression with resultType string). </summary>
        public object Type { get; set; }
        /// <summary> The dataset compression level. Type: string (or Expression with resultType string). </summary>
        public object Level { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
