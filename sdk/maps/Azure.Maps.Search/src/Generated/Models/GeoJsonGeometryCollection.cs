// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    /// <summary> A valid `GeoJSON GeometryCollection` object type. Please refer to [RFC 7946](https://tools.ietf.org/html/rfc7946#section-3.1.8) for details. </summary>
    internal partial class GeoJsonGeometryCollection : GeoJsonGeometry
    {
        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometryCollection"/>. </summary>
        /// <param name="geometries">
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="geometries"/> is null. </exception>
        public GeoJsonGeometryCollection(IEnumerable<GeoJsonGeometry> geometries)
        {
            Argument.AssertNotNull(geometries, nameof(geometries));

            Geometries = geometries.ToList();
            Type = GeoJsonObjectType.GeoJsonGeometryCollection;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometryCollection"/>. </summary>
        /// <param name="type"> Specifies the `GeoJSON` type. Must be one of the nine valid GeoJSON object types - Point, MultiPoint, LineString, MultiLineString, Polygon, MultiPolygon, GeometryCollection, Feature and FeatureCollection. </param>
        /// <param name="geometries">
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoJsonGeometryCollection(GeoJsonObjectType type, IList<GeoJsonGeometry> geometries, Dictionary<string, BinaryData> rawData) : base(type, rawData)
        {
            Geometries = geometries;
            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="GeoJsonGeometryCollection"/> for deserialization. </summary>
        internal GeoJsonGeometryCollection()
        {
        }

        /// <summary>
        /// Contains a list of valid `GeoJSON` geometry objects. **Note** that coordinates in GeoJSON are in x, y order (longitude, latitude).
        /// Please note <see cref="GeoJsonGeometry"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="GeoJsonGeometryCollection"/>, <see cref="GeoJsonLineString"/>, <see cref="GeoJsonMultiLineString"/>, <see cref="GeoJsonMultiPoint"/>, <see cref="GeoJsonMultiPolygon"/>, <see cref="GeoJsonPoint"/> and <see cref="GeoJsonPolygon"/>.
        /// </summary>
        public IList<GeoJsonGeometry> Geometries { get; }
    }
}
