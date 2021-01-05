// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The ConversionList. </summary>
    internal partial class ConversionList
    {
        /// <summary> Initializes a new instance of ConversionList. </summary>
        /// <param name="conversions"> The list of conversions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="conversions"/> is null. </exception>
        internal ConversionList(IEnumerable<AssetConversion> conversions)
        {
            if (conversions == null)
            {
                throw new ArgumentNullException(nameof(conversions));
            }

            Conversions = conversions.ToList();
        }

        /// <summary> Initializes a new instance of ConversionList. </summary>
        /// <param name="conversions"> The list of conversions. </param>
        /// <param name="nextLink"> If more conversions are available this link with the same authentication header can be used to retrieve further values. </param>
        internal ConversionList(IReadOnlyList<AssetConversion> conversions, string nextLink)
        {
            Conversions = conversions;
            NextLink = nextLink;
        }

        /// <summary> The list of conversions. </summary>
        public IReadOnlyList<AssetConversion> Conversions { get; }
        /// <summary> If more conversions are available this link with the same authentication header can be used to retrieve further values. </summary>
        public string NextLink { get; }
    }
}
