// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> This object is returned from a successful POI Category Tree call. </summary>
    public partial class PointOfInterestCategoryTreeResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PointOfInterestCategoryTreeResult"/>. </summary>
        internal PointOfInterestCategoryTreeResult()
        {
            Categories = new ChangeTrackingList<PointOfInterestCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="PointOfInterestCategoryTreeResult"/>. </summary>
        /// <param name="categories"> Categories array. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PointOfInterestCategoryTreeResult(IReadOnlyList<PointOfInterestCategory> categories, Dictionary<string, BinaryData> rawData)
        {
            Categories = categories;
            _rawData = rawData;
        }

        /// <summary> Categories array. </summary>
        public IReadOnlyList<PointOfInterestCategory> Categories { get; }
    }
}
