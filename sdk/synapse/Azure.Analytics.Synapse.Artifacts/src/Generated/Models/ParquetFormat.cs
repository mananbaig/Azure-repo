// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The data stored in Parquet format. </summary>
    public partial class ParquetFormat : DatasetStorageFormat
    {

        /// <summary> Initializes a new instance of ParquetFormat. </summary>
        /// <param name="type"> Type of dataset storage format. </param>
        /// <param name="serializer"> Serializer. Type: string (or Expression with resultType string). </param>
        /// <param name="deserializer"> Deserializer. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> . </param>
        internal ParquetFormat(string type, object serializer, object deserializer, IReadOnlyDictionary<string, object> additionalProperties) : base(type, serializer, deserializer, additionalProperties)
        {
            Type = type ?? "ParquetFormat";
        }
    }
}
