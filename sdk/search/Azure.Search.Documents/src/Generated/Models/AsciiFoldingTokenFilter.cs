// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Converts alphabetic, numeric, and symbolic Unicode characters which are not in the first 127 ASCII characters (the "Basic Latin" Unicode block) into their ASCII equivalents, if such equivalents exist. This token filter is implemented using Apache Lucene. </summary>
    public partial class AsciiFoldingTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="AsciiFoldingTokenFilter"/>. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AsciiFoldingTokenFilter(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.AsciiFoldingTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="AsciiFoldingTokenFilter"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="preserveOriginal"> A value indicating whether the original token will be kept. Default is false. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AsciiFoldingTokenFilter(string oDataType, string name, bool? preserveOriginal, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(oDataType, name, serializedAdditionalRawData)
        {
            PreserveOriginal = preserveOriginal;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.AsciiFoldingTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="AsciiFoldingTokenFilter"/> for deserialization. </summary>
        internal AsciiFoldingTokenFilter()
        {
        }

        /// <summary> A value indicating whether the original token will be kept. Default is false. </summary>
        public bool? PreserveOriginal { get; set; }
    }
}
