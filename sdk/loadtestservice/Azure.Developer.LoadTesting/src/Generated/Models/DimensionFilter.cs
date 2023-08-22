// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> Dimension name and values to filter. </summary>
    public partial class DimensionFilter
    {
        /// <summary> Initializes a new instance of DimensionFilter. </summary>
        public DimensionFilter()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> The dimension name. </summary>
        public string Name { get; set; }
        /// <summary> The dimension values. Maximum values can be 20. </summary>
        public IList<string> Values { get; }
    }
}
