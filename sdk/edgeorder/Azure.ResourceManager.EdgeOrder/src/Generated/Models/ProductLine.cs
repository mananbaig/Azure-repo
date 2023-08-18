// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Product line. </summary>
    public partial class ProductLine
    {
        /// <summary> Initializes a new instance of ProductLine. </summary>
        internal ProductLine()
        {
            ImageInformation = new Core.ChangeTrackingList<EdgeOrderProductImageInformation>();
            FilterableProperties = new Core.ChangeTrackingList<FilterableProperty>();
            Products = new Core.ChangeTrackingList<EdgeOrderProduct>();
        }

        /// <summary> Initializes a new instance of ProductLine. </summary>
        /// <param name="displayName"> Display Name for the product system. </param>
        /// <param name="description"> Description related to the product system. </param>
        /// <param name="imageInformation"> Image information for the product system. </param>
        /// <param name="costInformation"> Cost information for the product system. </param>
        /// <param name="availabilityInformation"> Availability information of the product system. </param>
        /// <param name="hierarchyInformation"> Hierarchy information of a product. </param>
        /// <param name="filterableProperties"> list of filters supported for a product. </param>
        /// <param name="products"> List of products in the product line. </param>
        internal ProductLine(string displayName, ProductDescription description, IReadOnlyList<EdgeOrderProductImageInformation> imageInformation, EdgeOrderProductCostInformation costInformation, ProductAvailabilityInformation availabilityInformation, HierarchyInformation hierarchyInformation, IReadOnlyList<FilterableProperty> filterableProperties, IReadOnlyList<EdgeOrderProduct> products)
        {
            DisplayName = displayName;
            Description = description;
            ImageInformation = imageInformation;
            CostInformation = costInformation;
            AvailabilityInformation = availabilityInformation;
            HierarchyInformation = hierarchyInformation;
            FilterableProperties = filterableProperties;
            Products = products;
        }

        /// <summary> Display Name for the product system. </summary>
        public string DisplayName { get; }
        /// <summary> Description related to the product system. </summary>
        public ProductDescription Description { get; }
        /// <summary> Image information for the product system. </summary>
        public IReadOnlyList<EdgeOrderProductImageInformation> ImageInformation { get; }
        /// <summary> Cost information for the product system. </summary>
        public EdgeOrderProductCostInformation CostInformation { get; }
        /// <summary> Availability information of the product system. </summary>
        public ProductAvailabilityInformation AvailabilityInformation { get; }
        /// <summary> Hierarchy information of a product. </summary>
        public HierarchyInformation HierarchyInformation { get; }
        /// <summary> list of filters supported for a product. </summary>
        public IReadOnlyList<FilterableProperty> FilterableProperties { get; }
        /// <summary> List of products in the product line. </summary>
        public IReadOnlyList<EdgeOrderProduct> Products { get; }
    }
}
