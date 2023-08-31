// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> `GeoJSON` object properties. </summary>
    public partial class AreaProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of AreaProperties. </summary>
        /// <param name="subType"> `GeoJSON` object sub-type. </param>
        /// <param name="radius"> The radius of the area's circle, in meters. </param>
        public AreaProperties(GeoJsonPropertiesSubType subType, double radius)
        {
            SubType = subType;
            Radius = radius;
        }

        /// <summary> Initializes a new instance of AreaProperties. </summary>
        /// <param name="subType"> `GeoJSON` object sub-type. </param>
        /// <param name="radius"> The radius of the area's circle, in meters. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AreaProperties(GeoJsonPropertiesSubType subType, double radius, Dictionary<string, BinaryData> rawData)
        {
            SubType = subType;
            Radius = radius;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AreaProperties"/> for deserialization. </summary>
        internal AreaProperties()
        {
        }

        /// <summary> `GeoJSON` object sub-type. </summary>
        public GeoJsonPropertiesSubType SubType { get; }
        /// <summary> The radius of the area's circle, in meters. </summary>
        public double Radius { get; }
    }
}
