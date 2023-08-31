// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Maps.Rendering
{
    /// <summary> The RegionCopyrights. </summary>
    public partial class RegionalCopyright
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RegionalCopyright"/>. </summary>
        /// <param name="copyrights"> Copyrights array. </param>
        /// <param name="country"> Country property. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RegionalCopyright(IReadOnlyList<string> copyrights, RegionalCopyrightCountry country, Dictionary<string, BinaryData> rawData)
        {
            Copyrights = copyrights;
            Country = country;
            _rawData = rawData;
        }
    }
}
