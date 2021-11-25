// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace Azure.Maps.Search.Models
{
    /// <summary> Options. </summary>
    public class SearchPointOfInterestCategoryOptions: SearchPointOfInterestOptions
    {
        /// <summary>
        /// Indexes for which extended postal codes should be included in the results.
        ///
        /// Available indexes are:
        ///
        ///  **Addr** = Address ranges
        ///
        ///  **Geo** = Geographies
        ///
        ///  **PAD** = Point Addresses
        ///
        ///  **POI** = Points of Interest
        ///
        ///  **Str** = Streets
        ///
        ///  **XStr** = Cross Streets (intersections)
        ///
        /// Value should be a comma separated list of index types (in any order) or **None** for no indexes.
        ///
        /// By default extended postal codes are included for all indexes except Geo. Extended postal code lists for geographies can be quite long so they have to be explicitly requested when needed.
        ///
        /// Usage examples:
        ///
        ///  extendedPostalCodesFor=POI
        ///
        ///  extendedPostalCodesFor=PAD,Addr,POI
        ///
        ///  extendedPostalCodesFor=None
        ///
        /// Extended postal code is returned as an **extendedPostalCode** property of an address. Availability is region-dependent.
        /// </summary>
        public new IEnumerable<SearchIndexes> ExtendedPostalCodesFor { get; set; }
    }
}
