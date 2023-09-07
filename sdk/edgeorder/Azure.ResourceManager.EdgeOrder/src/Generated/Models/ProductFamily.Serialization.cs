// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class ProductFamily : IUtf8JsonSerializable, IModelJsonSerializable<ProductFamily>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProductFamily>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ProductFamily>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductFamily>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ResourceProviderDetails))
            {
                writer.WritePropertyName("resourceProviderDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceProviderDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ResourceProviderDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ProductFamily DeserializeProductFamily(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<ProductDescription> description = default;
            Optional<IReadOnlyList<EdgeOrderProductImageInformation>> imageInformation = default;
            Optional<EdgeOrderProductCostInformation> costInformation = default;
            Optional<ProductAvailabilityInformation> availabilityInformation = default;
            Optional<HierarchyInformation> hierarchyInformation = default;
            Optional<IReadOnlyList<FilterableProperty>> filterableProperties = default;
            Optional<IReadOnlyList<ProductLine>> productLines = default;
            Optional<IReadOnlyList<ResourceProviderDetails>> resourceProviderDetails = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ProductFamily(displayName.Value, description.Value, Optional.ToList(imageInformation), costInformation.Value, availabilityInformation.Value, hierarchyInformation.Value, Optional.ToList(filterableProperties), Optional.ToList(productLines), Optional.ToList(resourceProviderDetails), serializedAdditionalRawData);
        }

        ProductFamily IModelJsonSerializable<ProductFamily>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductFamily>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProductFamily(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProductFamily>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductFamily>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ProductFamily IModelSerializable<ProductFamily>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ProductFamily>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeProductFamily(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ProductFamily"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ProductFamily"/> to convert. </param>
        public static implicit operator RequestContent(ProductFamily model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ProductFamily"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ProductFamily(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeProductFamily(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
