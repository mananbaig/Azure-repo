// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of a SKU for a scalable resource. </summary>
    public partial class SkuDescription
    {
        /// <summary> Initializes a new instance of <see cref="SkuDescription"/>. </summary>
        public SkuDescription()
        {
            Locations = new ChangeTrackingList<string>();
            Capabilities = new ChangeTrackingList<Capability>();
        }

        /// <summary> Initializes a new instance of <see cref="SkuDescription"/>. </summary>
        /// <param name="name"> Name of the resource SKU. </param>
        /// <param name="tier"> Service tier of the resource SKU. </param>
        /// <param name="size"> Size specifier of the resource SKU. </param>
        /// <param name="family"> Family code of the resource SKU. </param>
        /// <param name="capacity"> Current number of instances assigned to the resource. </param>
        /// <param name="skuCapacity"> Min, max, and default scale values of the SKU. </param>
        /// <param name="locations"> Locations of the SKU. </param>
        /// <param name="capabilities"> Capabilities of the SKU, e.g., is traffic manager enabled?. </param>
        internal SkuDescription(string name, string tier, string size, string family, int? capacity, SkuCapacity skuCapacity, IList<string> locations, IList<Capability> capabilities)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            SkuCapacity = skuCapacity;
            Locations = locations;
            Capabilities = capabilities;
        }

        /// <summary> Name of the resource SKU. </summary>
        public string Name { get; set; }
        /// <summary> Service tier of the resource SKU. </summary>
        public string Tier { get; set; }
        /// <summary> Size specifier of the resource SKU. </summary>
        public string Size { get; set; }
        /// <summary> Family code of the resource SKU. </summary>
        public string Family { get; set; }
        /// <summary> Current number of instances assigned to the resource. </summary>
        public int? Capacity { get; set; }
        /// <summary> Min, max, and default scale values of the SKU. </summary>
        public SkuCapacity SkuCapacity { get; set; }
        /// <summary> Locations of the SKU. </summary>
        public IList<string> Locations { get; }
        /// <summary> Capabilities of the SKU, e.g., is traffic manager enabled?. </summary>
        public IList<Capability> Capabilities { get; }
    }
}
