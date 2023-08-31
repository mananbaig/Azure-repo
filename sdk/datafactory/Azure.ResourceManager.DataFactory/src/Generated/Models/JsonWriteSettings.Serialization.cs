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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class JsonWriteSettings : IUtf8JsonSerializable, IModelJsonSerializable<JsonWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JsonWriteSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JsonWriteSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<JsonWriteSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FilePattern))
            {
                writer.WritePropertyName("filePattern"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(FilePattern);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(FilePattern.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FormatWriteSettingsType);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static JsonWriteSettings DeserializeJsonWriteSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> filePattern = default;
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filePattern"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filePattern = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new JsonWriteSettings(type, additionalProperties, filePattern.Value);
        }

        JsonWriteSettings IModelJsonSerializable<JsonWriteSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<JsonWriteSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJsonWriteSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JsonWriteSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<JsonWriteSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JsonWriteSettings IModelSerializable<JsonWriteSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<JsonWriteSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJsonWriteSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(JsonWriteSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator JsonWriteSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJsonWriteSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
