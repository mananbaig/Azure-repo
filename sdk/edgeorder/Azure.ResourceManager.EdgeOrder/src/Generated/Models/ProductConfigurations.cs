// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> The list of configurations. </summary>
    internal partial class ProductConfigurations
    {
        /// <summary> Initializes a new instance of ProductConfigurations. </summary>
        internal ProductConfigurations()
        {
            Value = new Core.ChangeTrackingList<ProductConfiguration>();
        }

        /// <summary> Initializes a new instance of ProductConfigurations. </summary>
        /// <param name="value"> List of configurations. </param>
        /// <param name="nextLink"> Link for the next set of configurations. </param>
        internal ProductConfigurations(IReadOnlyList<ProductConfiguration> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of configurations. </summary>
        public IReadOnlyList<ProductConfiguration> Value { get; }
        /// <summary> Link for the next set of configurations. </summary>
        public string NextLink { get; }
    }
}
