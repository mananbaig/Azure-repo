// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The sort parameters for search. </summary>
    internal partial class SearchSort
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SearchSort"/>. </summary>
        internal SearchSort()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SearchSort"/>. </summary>
        /// <param name="name"> The name of the field the search query is sorted on. </param>
        /// <param name="order"> The sort order of the search. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SearchSort(string name, SearchSortEnum? order, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Order = order;
            _rawData = rawData;
        }

        /// <summary> The name of the field the search query is sorted on. </summary>
        public string Name { get; }
        /// <summary> The sort order of the search. </summary>
        public SearchSortEnum? Order { get; }
    }
}
