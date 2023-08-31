// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the gallery image definition purchase plan. This is used by marketplace images. </summary>
    public partial class ImagePurchasePlan
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ImagePurchasePlan"/>. </summary>
        public ImagePurchasePlan()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImagePurchasePlan"/>. </summary>
        /// <param name="name"> The plan ID. </param>
        /// <param name="publisher"> The publisher ID. </param>
        /// <param name="product"> The product ID. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImagePurchasePlan(string name, string publisher, string product, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Publisher = publisher;
            Product = product;
            _rawData = rawData;
        }

        /// <summary> The plan ID. </summary>
        public string Name { get; set; }
        /// <summary> The publisher ID. </summary>
        public string Publisher { get; set; }
        /// <summary> The product ID. </summary>
        public string Product { get; set; }
    }
}
