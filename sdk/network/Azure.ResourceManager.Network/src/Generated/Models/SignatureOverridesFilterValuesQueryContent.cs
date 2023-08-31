// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the filter values possibles for a given column. </summary>
    public partial class SignatureOverridesFilterValuesQueryContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SignatureOverridesFilterValuesQueryContent"/>. </summary>
        public SignatureOverridesFilterValuesQueryContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignatureOverridesFilterValuesQueryContent"/>. </summary>
        /// <param name="filterName"> Describes the name of the column which values will be returned. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SignatureOverridesFilterValuesQueryContent(string filterName, Dictionary<string, BinaryData> rawData)
        {
            FilterName = filterName;
            _rawData = rawData;
        }

        /// <summary> Describes the name of the column which values will be returned. </summary>
        public string FilterName { get; set; }
    }
}
