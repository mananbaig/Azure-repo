// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Models
{
    /// <summary> Removes elisions. For example, &quot;l&apos;avion&quot; (the plane) will be converted to &quot;avion&quot; (plane). This token filter is implemented using Apache Lucene. </summary>
    public partial class ElisionTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of ElisionTokenFilter. </summary>
        public ElisionTokenFilter()
        {
            ODataType = "#Microsoft.Azure.Search.ElisionTokenFilter";
        }

        /// <summary> Initializes a new instance of ElisionTokenFilter. </summary>
        /// <param name="articles"> The set of articles to remove. </param>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal ElisionTokenFilter(IList<string> articles, string oDataType, string name) : base(oDataType, name)
        {
            Articles = articles;
            ODataType = "#Microsoft.Azure.Search.ElisionTokenFilter";
        }

        /// <summary> The set of articles to remove. </summary>
        public IList<string> Articles { get; set; }
    }
}
