// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductLine : IUtf8JsonSerializable, IJsonModel<ProductLine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProductLine>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProductLine>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductLine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductLine)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteObjectValue(Description, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ImageInformation))
            {
                writer.WritePropertyName("imageInformation"u8);
                writer.WriteStartArray();
                foreach (var item in ImageInformation)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(CostInformation))
            {
                writer.WritePropertyName("costInformation"u8);
                writer.WriteObjectValue(CostInformation, options);
            }
            if (options.Format != "W" && Optional.IsDefined(AvailabilityInformation))
            {
                writer.WritePropertyName("availabilityInformation"u8);
                writer.WriteObjectValue(AvailabilityInformation, options);
            }
            if (options.Format != "W" && Optional.IsDefined(HierarchyInformation))
            {
                writer.WritePropertyName("hierarchyInformation"u8);
                writer.WriteObjectValue(HierarchyInformation, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(FilterableProperties))
            {
                writer.WritePropertyName("filterableProperties"u8);
                writer.WriteStartArray();
                foreach (var item in FilterableProperties)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Products))
            {
                writer.WritePropertyName("products"u8);
                writer.WriteStartArray();
                foreach (var item in Products)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ProductLine IJsonModel<ProductLine>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductLine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProductLine)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProductLine(document.RootElement, options);
        }

        internal static ProductLine DeserializeProductLine(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            ProductDescription description = default;
            IReadOnlyList<EdgeOrderProductImageInformation> imageInformation = default;
            EdgeOrderProductCostInformation costInformation = default;
            ProductAvailabilityInformation availabilityInformation = default;
            HierarchyInformation hierarchyInformation = default;
            IReadOnlyList<FilterableProperty> filterableProperties = default;
            IReadOnlyList<EdgeOrderProduct> products = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                            description = ProductDescription.DeserializeProductDescription(property0.Value, options);
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
                                array.Add(EdgeOrderProductImageInformation.DeserializeEdgeOrderProductImageInformation(item, options));
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
                            costInformation = EdgeOrderProductCostInformation.DeserializeEdgeOrderProductCostInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("availabilityInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availabilityInformation = ProductAvailabilityInformation.DeserializeProductAvailabilityInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("hierarchyInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hierarchyInformation = HierarchyInformation.DeserializeHierarchyInformation(property0.Value, options);
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
                                array.Add(FilterableProperty.DeserializeFilterableProperty(item, options));
                            }
                            filterableProperties = array;
                            continue;
                        }
                        if (property0.NameEquals("products"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EdgeOrderProduct> array = new List<EdgeOrderProduct>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EdgeOrderProduct.DeserializeEdgeOrderProduct(item, options));
                            }
                            products = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProductLine(
                displayName,
                description,
                imageInformation ?? new ChangeTrackingList<EdgeOrderProductImageInformation>(),
                costInformation,
                availabilityInformation,
                hierarchyInformation,
                filterableProperties ?? new ChangeTrackingList<FilterableProperty>(),
                products ?? new ChangeTrackingList<EdgeOrderProduct>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProductLine>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductLine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProductLine)} does not support writing '{options.Format}' format.");
            }
        }

        ProductLine IPersistableModel<ProductLine>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProductLine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProductLine(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProductLine)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProductLine>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
