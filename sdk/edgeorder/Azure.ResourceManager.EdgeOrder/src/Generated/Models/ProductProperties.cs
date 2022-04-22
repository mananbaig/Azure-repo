// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Properties of products. </summary>
    internal partial class ProductProperties : CommonProperties
    {
        /// <summary> Initializes a new instance of ProductProperties. </summary>
        internal ProductProperties()
        {
            Configurations = new ChangeTrackingList<ProductConfiguration>();
        }

        /// <summary> List of configurations for the product. </summary>
        public IReadOnlyList<ProductConfiguration> Configurations { get; }
    }
}
