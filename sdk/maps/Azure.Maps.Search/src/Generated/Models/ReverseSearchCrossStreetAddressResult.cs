// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> This object is returned from a successful Search Address Reverse CrossStreet call. </summary>
    public partial class ReverseSearchCrossStreetAddressResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ReverseSearchCrossStreetAddressResult"/>. </summary>
        internal ReverseSearchCrossStreetAddressResult()
        {
            Addresses = new ChangeTrackingList<ReverseSearchCrossStreetAddressResultItem>();
        }

        /// <summary> Initializes a new instance of <see cref="ReverseSearchCrossStreetAddressResult"/>. </summary>
        /// <param name="summary"> Summary object for a Search Address Reverse Cross Street response. </param>
        /// <param name="addresses"> Addresses array. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ReverseSearchCrossStreetAddressResult(SearchSummary summary, IReadOnlyList<ReverseSearchCrossStreetAddressResultItem> addresses, Dictionary<string, BinaryData> rawData)
        {
            Summary = summary;
            Addresses = addresses;
            _rawData = rawData;
        }
        /// <summary> Addresses array. </summary>
        public IReadOnlyList<ReverseSearchCrossStreetAddressResultItem> Addresses { get; }
    }
}
