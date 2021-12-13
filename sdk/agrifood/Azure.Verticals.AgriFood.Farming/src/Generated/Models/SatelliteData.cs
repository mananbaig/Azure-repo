// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Verticals.AgriFood.Farming.Models
{
    /// <summary> Data Model for SatelliteIngestionJobRequest. </summary>
    public partial class SatelliteData
    {
        /// <summary> Initializes a new instance of SatelliteData. </summary>
        public SatelliteData()
        {
            ImageNames = new ChangeTrackingList<string>();
            ImageFormats = new ChangeTrackingList<string>();
            ImageResolutions = new ChangeTrackingList<double>();
        }

        /// <summary> Initializes a new instance of SatelliteData. </summary>
        /// <param name="imageNames"> List of ImageNames. </param>
        /// <param name="imageFormats"> List of ImageFormats. Available value: TIF. </param>
        /// <param name="imageResolutions"> List of ImageResolutions in meters. Available values: 10, 20, 60. </param>
        internal SatelliteData(IList<string> imageNames, IList<string> imageFormats, IList<double> imageResolutions)
        {
            ImageNames = imageNames;
            ImageFormats = imageFormats;
            ImageResolutions = imageResolutions;
        }

        /// <summary> List of ImageNames. </summary>
        public IList<string> ImageNames { get; }
        /// <summary> List of ImageFormats. Available value: TIF. </summary>
        public IList<string> ImageFormats { get; }
        /// <summary> List of ImageResolutions in meters. Available values: 10, 20, 60. </summary>
        public IList<double> ImageResolutions { get; }
    }
}
