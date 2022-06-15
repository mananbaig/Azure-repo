// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.GeoJson;
using Azure.Core;

namespace Azure.Maps.Search.Models

{
    /// <summary> Summary object for a Search API response. </summary>
    [CodeGenModel("SearchSummary")]
    public partial class SearchSummary
    {
        /// <summary> Indication when the internal search engine has applied a geospatial bias to improve the ranking of results.  In  some methods, this can be affected by setting the lat and lon parameters where available.  In other cases it is  purely internal. </summary>
        [CodeGenMember("GeoBias")]
        public GeoPosition GeoBias { get; }
    }
}
