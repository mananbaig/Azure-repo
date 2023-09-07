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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class BigDataPoolAutoPauseProperties : IUtf8JsonSerializable, IModelJsonSerializable<BigDataPoolAutoPauseProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BigDataPoolAutoPauseProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BigDataPoolAutoPauseProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BigDataPoolAutoPauseProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DelayInMinutes))
            {
                writer.WritePropertyName("delayInMinutes"u8);
                writer.WriteNumberValue(DelayInMinutes.Value);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
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

        internal static BigDataPoolAutoPauseProperties DeserializeBigDataPoolAutoPauseProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> delayInMinutes = default;
            Optional<bool> enabled = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delayInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delayInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BigDataPoolAutoPauseProperties(Optional.ToNullable(delayInMinutes), Optional.ToNullable(enabled), serializedAdditionalRawData);
        }

        BigDataPoolAutoPauseProperties IModelJsonSerializable<BigDataPoolAutoPauseProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BigDataPoolAutoPauseProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBigDataPoolAutoPauseProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BigDataPoolAutoPauseProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BigDataPoolAutoPauseProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BigDataPoolAutoPauseProperties IModelSerializable<BigDataPoolAutoPauseProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BigDataPoolAutoPauseProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBigDataPoolAutoPauseProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BigDataPoolAutoPauseProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BigDataPoolAutoPauseProperties"/> to convert. </param>
        public static implicit operator RequestContent(BigDataPoolAutoPauseProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BigDataPoolAutoPauseProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BigDataPoolAutoPauseProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBigDataPoolAutoPauseProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
