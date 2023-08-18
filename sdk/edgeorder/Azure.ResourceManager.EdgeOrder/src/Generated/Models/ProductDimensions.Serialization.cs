// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductDimensions
    {
        internal static ProductDimensions DeserializeProductDimensions(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<double> length = default;
            Core.Optional<double> height = default;
            Core.Optional<double> width = default;
            Core.Optional<ProductLengthHeightWidthUnit> lengthHeightUnit = default;
            Core.Optional<double> weight = default;
            Core.Optional<double> depth = default;
            Core.Optional<ProductWeightMeasurementUnit> weightUnit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("length"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    length = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("height"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    height = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("width"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    width = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("lengthHeightUnit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lengthHeightUnit = new ProductLengthHeightWidthUnit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weight = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("depth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    depth = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("weightUnit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weightUnit = new ProductWeightMeasurementUnit(property.Value.GetString());
                    continue;
                }
            }
            return new ProductDimensions(Core.Optional.ToNullable(length), Core.Optional.ToNullable(height), Core.Optional.ToNullable(width), Core.Optional.ToNullable(lengthHeightUnit), Core.Optional.ToNullable(weight), Core.Optional.ToNullable(depth), Core.Optional.ToNullable(weightUnit));
        }
    }
}
