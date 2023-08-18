// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> The list of product families. </summary>
    internal partial class ProductFamilies
    {
        /// <summary> Initializes a new instance of ProductFamilies. </summary>
        internal ProductFamilies()
        {
            Value = new Core.ChangeTrackingList<ProductFamily>();
        }

        /// <summary> Initializes a new instance of ProductFamilies. </summary>
        /// <param name="value"> List of product families. </param>
        /// <param name="nextLink"> Link for the next set of product families. </param>
        internal ProductFamilies(IReadOnlyList<ProductFamily> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of product families. </summary>
        public IReadOnlyList<ProductFamily> Value { get; }
        /// <summary> Link for the next set of product families. </summary>
        public string NextLink { get; }
    }
}
