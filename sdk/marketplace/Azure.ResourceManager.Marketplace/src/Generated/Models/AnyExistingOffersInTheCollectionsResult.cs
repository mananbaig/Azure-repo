// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Response object of query if are there existing offers in the collections. </summary>
    public partial class AnyExistingOffersInTheCollectionsResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AnyExistingOffersInTheCollectionsResult"/>. </summary>
        internal AnyExistingOffersInTheCollectionsResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnyExistingOffersInTheCollectionsResult"/>. </summary>
        /// <param name="value"> Boolean answer, true if exists at least a single offer in an enabled collection, otherwise, false. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AnyExistingOffersInTheCollectionsResult(bool? value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Boolean answer, true if exists at least a single offer in an enabled collection, otherwise, false. </summary>
        public bool? Value { get; }
    }
}
