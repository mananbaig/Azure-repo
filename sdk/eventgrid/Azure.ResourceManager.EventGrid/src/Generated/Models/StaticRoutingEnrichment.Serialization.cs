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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class StaticRoutingEnrichment : IUtf8JsonSerializable, IModelJsonSerializable<StaticRoutingEnrichment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StaticRoutingEnrichment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StaticRoutingEnrichment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StaticRoutingEnrichment>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
            }
            if (Optional.IsDefined(ValueType))
            {
                writer.WritePropertyName("valueType"u8);
                writer.WriteStringValue(ValueType.Value.ToString());
            }
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

        internal static StaticRoutingEnrichment DeserializeStaticRoutingEnrichment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key = default;
            Optional<StaticRoutingEnrichmentType> valueType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueType = new StaticRoutingEnrichmentType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StaticRoutingEnrichment(key.Value, Optional.ToNullable(valueType), serializedAdditionalRawData);
        }

        StaticRoutingEnrichment IModelJsonSerializable<StaticRoutingEnrichment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StaticRoutingEnrichment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticRoutingEnrichment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StaticRoutingEnrichment>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StaticRoutingEnrichment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StaticRoutingEnrichment IModelSerializable<StaticRoutingEnrichment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StaticRoutingEnrichment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStaticRoutingEnrichment(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StaticRoutingEnrichment"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StaticRoutingEnrichment"/> to convert. </param>
        public static implicit operator RequestContent(StaticRoutingEnrichment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StaticRoutingEnrichment"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StaticRoutingEnrichment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStaticRoutingEnrichment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
