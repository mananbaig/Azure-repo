// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    /// <summary> The GeoJsonLineStringData. </summary>
    public partial class GeoJsonLineStringData
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonLineStringData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson LineString` geometry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="coordinates"/> is null. </exception>
        public GeoJsonLineStringData(IEnumerable<IList<double>> coordinates)
        {
            Argument.AssertNotNull(coordinates, nameof(coordinates));

            Coordinates = coordinates.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonLineStringData"/>. </summary>
        /// <param name="coordinates"> Coordinates for the `GeoJson LineString` geometry. </param>
        internal GeoJsonLineStringData(IList<IList<double>> coordinates)
        {
            Coordinates = coordinates;
        }

        /// <summary> Coordinates for the `GeoJson LineString` geometry. </summary>
        public IList<IList<double>> Coordinates { get; }
    }
}
