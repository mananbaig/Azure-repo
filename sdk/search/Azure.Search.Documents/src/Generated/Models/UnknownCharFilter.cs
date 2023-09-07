// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownCharFilter. </summary>
    internal partial class UnknownCharFilter : CharFilter
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCharFilter"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the char filter. </param>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCharFilter(string oDataType, string name, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(oDataType, name, serializedAdditionalRawData)
        {
            ODataType = oDataType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownCharFilter"/> for deserialization. </summary>
        internal UnknownCharFilter()
        {
        }
    }
}
