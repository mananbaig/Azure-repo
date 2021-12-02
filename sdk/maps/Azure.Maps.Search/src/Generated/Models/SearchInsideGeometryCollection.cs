// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Maps.Search.Models
{
    /// <summary> A valid `GeoJSON GeometryCollection` object type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.8) for details. </summary>
    public partial class SearchInsideGeometryCollection : PolygonOrGeometryCollectionOrFeatureCollection
    {
        /// <summary> Initializes a new instance of SearchInsideGeometryCollection. </summary>
        /// <param name="geometries"> Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="geometries"/> is null. </exception>
        public SearchInsideGeometryCollection(IEnumerable<SearchInsidePolygon> geometries)
        {
            if (geometries == null)
            {
                throw new ArgumentNullException(nameof(geometries));
            }

            Geometries = geometries.ToList();
            Type = PolygonOrGeometryCollectionOrFeatureCollectionType.GeoJsonGeometryCollection;
        }

        /// <summary> Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude). </summary>
        public IList<SearchInsidePolygon> Geometries { get; }
    }
}
