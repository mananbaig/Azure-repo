// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductFamiliesMetadata
    {
        internal static ProductFamiliesMetadata DeserializeProductFamiliesMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> displayName = default;
            Core.Optional<ProductDescription> description = default;
            Core.Optional<IReadOnlyList<EdgeOrderProductImageInformation>> imageInformation = default;
            Core.Optional<EdgeOrderProductCostInformation> costInformation = default;
            Core.Optional<ProductAvailabilityInformation> availabilityInformation = default;
            Core.Optional<HierarchyInformation> hierarchyInformation = default;
            Core.Optional<IReadOnlyList<FilterableProperty>> filterableProperties = default;
            Core.Optional<IReadOnlyList<ProductLine>> productLines = default;
            Core.Optional<IReadOnlyList<ResourceProviderDetails>> resourceProviderDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            description = ProductDescription.DeserializeProductDescription(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("imageInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EdgeOrderProductImageInformation> array = new List<EdgeOrderProductImageInformation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EdgeOrderProductImageInformation.DeserializeEdgeOrderProductImageInformation(item));
                            }
                            imageInformation = array;
                            continue;
                        }
                        if (property0.NameEquals("costInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            costInformation = EdgeOrderProductCostInformation.DeserializeEdgeOrderProductCostInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilityInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityInformation = ProductAvailabilityInformation.DeserializeProductAvailabilityInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hierarchyInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filterableProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FilterableProperty> array = new List<FilterableProperty>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FilterableProperty.DeserializeFilterableProperty(item));
                            }
                            filterableProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("productLines"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ProductLine> array = new List<ProductLine>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ProductLine.DeserializeProductLine(item));
                            }
                            productLines = array;
                            continue;
                        }
                        if (property0.NameEquals("resourceProviderDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceProviderDetails> array = new List<ResourceProviderDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.ResourceProviderDetails.DeserializeResourceProviderDetails(item));
                            }
                            resourceProviderDetails = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProductFamiliesMetadata(displayName.Value, description.Value, Core.Optional.ToList(imageInformation), costInformation.Value, availabilityInformation.Value, hierarchyInformation.Value, Core.Optional.ToList(filterableProperties), Core.Optional.ToList(productLines), Core.Optional.ToList(resourceProviderDetails));
        }
    }
}
