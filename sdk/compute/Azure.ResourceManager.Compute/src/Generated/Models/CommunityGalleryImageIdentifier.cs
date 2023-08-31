// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the community gallery image definition identifier. </summary>
    public partial class CommunityGalleryImageIdentifier
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageIdentifier"/>. </summary>
        internal CommunityGalleryImageIdentifier()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CommunityGalleryImageIdentifier"/>. </summary>
        /// <param name="publisher"> The name of the gallery image definition publisher. </param>
        /// <param name="offer"> The name of the gallery image definition offer. </param>
        /// <param name="sku"> The name of the gallery image definition SKU. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CommunityGalleryImageIdentifier(string publisher, string offer, string sku, Dictionary<string, BinaryData> rawData)
        {
            Publisher = publisher;
            Offer = offer;
            Sku = sku;
            _rawData = rawData;
        }

        /// <summary> The name of the gallery image definition publisher. </summary>
        public string Publisher { get; }
        /// <summary> The name of the gallery image definition offer. </summary>
        public string Offer { get; }
        /// <summary> The name of the gallery image definition SKU. </summary>
        public string Sku { get; }
    }
}
