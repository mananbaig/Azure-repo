// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    /// <summary> The result of Autocomplete query. </summary>
    public partial class AutocompleteResults
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AutocompleteResults"/>. </summary>
        /// <param name="results"> The list of returned Autocompleted items. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="results"/> is null. </exception>
        internal AutocompleteResults(IEnumerable<AutocompleteItem> results)
        {
            Argument.AssertNotNull(results, nameof(results));

            Results = results.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AutocompleteResults"/>. </summary>
        /// <param name="coverage"> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </param>
        /// <param name="results"> The list of returned Autocompleted items. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutocompleteResults(double? coverage, IReadOnlyList<AutocompleteItem> results, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Coverage = coverage;
            Results = results;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AutocompleteResults"/> for deserialization. </summary>
        internal AutocompleteResults()
        {
        }

        /// <summary> A value indicating the percentage of the index that was considered by the autocomplete request, or null if minimumCoverage was not specified in the request. </summary>
        public double? Coverage { get; }
        /// <summary> The list of returned Autocompleted items. </summary>
        public IReadOnlyList<AutocompleteItem> Results { get; }
    }
}
