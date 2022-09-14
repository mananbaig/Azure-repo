// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Rendering
{
    /// <summary> Country property. </summary>
    public partial class RegionalCopyrightCountry
    {
        /// <summary> Initializes a new instance of RegionalCopyrightCountry. </summary>
        internal RegionalCopyrightCountry()
        {
        }

        /// <summary> Initializes a new instance of RegionalCopyrightCountry. </summary>
        /// <param name="iso3"> ISO3 property. </param>
        /// <param name="label"> Label property. </param>
        internal RegionalCopyrightCountry(string iso3, string label)
        {
            Iso3 = iso3;
            Label = label;
        }
        /// <summary> Label property. </summary>
        public string Label { get; }
    }
}
