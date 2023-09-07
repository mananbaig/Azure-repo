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

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class ResourceMetricDefinitionListResult : IUtf8JsonSerializable, IModelJsonSerializable<ResourceMetricDefinitionListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceMetricDefinitionListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceMetricDefinitionListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceMetricDefinitionListResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResourceMetricDefinition>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static ResourceMetricDefinitionListResult DeserializeResourceMetricDefinitionListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ResourceMetricDefinition> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ResourceMetricDefinition> array = new List<ResourceMetricDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceMetricDefinition.DeserializeResourceMetricDefinition(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceMetricDefinitionListResult(value, nextLink.Value, serializedAdditionalRawData);
        }

        ResourceMetricDefinitionListResult IModelJsonSerializable<ResourceMetricDefinitionListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceMetricDefinitionListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceMetricDefinitionListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceMetricDefinitionListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceMetricDefinitionListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceMetricDefinitionListResult IModelSerializable<ResourceMetricDefinitionListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceMetricDefinitionListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceMetricDefinitionListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceMetricDefinitionListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceMetricDefinitionListResult"/> to convert. </param>
        public static implicit operator RequestContent(ResourceMetricDefinitionListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceMetricDefinitionListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceMetricDefinitionListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceMetricDefinitionListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
