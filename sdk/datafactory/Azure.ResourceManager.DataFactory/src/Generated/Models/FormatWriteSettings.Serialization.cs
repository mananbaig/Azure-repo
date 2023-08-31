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
    public partial class FormatWriteSettings : IUtf8JsonSerializable, IModelJsonSerializable<FormatWriteSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FormatWriteSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FormatWriteSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static FormatWriteSettings DeserializeFormatWriteSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroWriteSettings": return AvroWriteSettings.DeserializeAvroWriteSettings(element);
                    case "JsonWriteSettings": return JsonWriteSettings.DeserializeJsonWriteSettings(element);
                    case "OrcWriteSettings": return OrcWriteSettings.DeserializeOrcWriteSettings(element);
                    case "ParquetWriteSettings": return ParquetWriteSettings.DeserializeParquetWriteSettings(element);
                    case "DelimitedTextWriteSettings": return DelimitedTextWriteSettings.DeserializeDelimitedTextWriteSettings(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownFormatWriteSettings(type, additionalProperties);
        }

        FormatWriteSettings IModelJsonSerializable<FormatWriteSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFormatWriteSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FormatWriteSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FormatWriteSettings IModelSerializable<FormatWriteSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFormatWriteSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FormatWriteSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FormatWriteSettings"/> to convert. </param>
        public static implicit operator RequestContent(FormatWriteSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FormatWriteSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FormatWriteSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFormatWriteSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
