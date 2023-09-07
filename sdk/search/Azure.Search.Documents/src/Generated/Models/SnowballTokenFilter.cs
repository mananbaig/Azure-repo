// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A filter that stems words using a Snowball-generated stemmer. This token filter is implemented using Apache Lucene. </summary>
    public partial class SnowballTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="SnowballTokenFilter"/>. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="language"> The language to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public SnowballTokenFilter(string name, SnowballTokenFilterLanguage language) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Language = language;
            ODataType = "#Microsoft.Azure.Search.SnowballTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="SnowballTokenFilter"/>. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="language"> The language to use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SnowballTokenFilter(string oDataType, string name, SnowballTokenFilterLanguage language, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(oDataType, name, serializedAdditionalRawData)
        {
            Language = language;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.SnowballTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="SnowballTokenFilter"/> for deserialization. </summary>
        internal SnowballTokenFilter()
        {
        }

        /// <summary> The language to use. </summary>
        public SnowballTokenFilterLanguage Language { get; set; }
    }
}
