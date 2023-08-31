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

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    public partial class PairedKey : IUtf8JsonSerializable, IModelJsonSerializable<PairedKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PairedKey>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PairedKey>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(PairedKeyType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PairedKeyType);
            }
            if (Optional.IsDefined(AdditionalProperties))
            {
                if (AdditionalProperties != null)
                {
                    writer.WritePropertyName("additionalProperties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AdditionalProperties);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(AdditionalProperties.ToString()).RootElement);
#endif
                }
                else
                {
                    writer.WriteNull("additionalProperties");
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static PairedKey DeserializePairedKey(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> type = default;
            Optional<BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        additionalProperties = null;
                        continue;
                    }
                    additionalProperties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PairedKey(id.Value, type.Value, additionalProperties.Value, rawData);
        }

        PairedKey IModelJsonSerializable<PairedKey>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePairedKey(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PairedKey>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PairedKey IModelSerializable<PairedKey>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePairedKey(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PairedKey model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PairedKey(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePairedKey(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
