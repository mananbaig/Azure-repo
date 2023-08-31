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

namespace Azure.Core.TestFramework.Models
{
    public partial class BodyKeySanitizer : IUtf8JsonSerializable, IModelJsonSerializable<BodyKeySanitizer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BodyKeySanitizer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BodyKeySanitizer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(JsonPath))
            {
                writer.WritePropertyName("jsonPath"u8);
                writer.WriteStringValue(JsonPath);
            }
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            if (Optional.IsDefined(Regex))
            {
                writer.WritePropertyName("regex"u8);
                writer.WriteStringValue(Regex);
            }
            if (Optional.IsDefined(GroupForReplace))
            {
                writer.WritePropertyName("groupForReplace"u8);
                writer.WriteStringValue(GroupForReplace);
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

        internal static BodyKeySanitizer DeserializeBodyKeySanitizer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> jsonPath = default;
            string value = default;
            Optional<string> regex = default;
            Optional<string> groupForReplace = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jsonPath"u8))
                {
                    jsonPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regex"u8))
                {
                    regex = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupForReplace"u8))
                {
                    groupForReplace = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BodyKeySanitizer(jsonPath.Value, value, regex.Value, groupForReplace.Value, rawData);
        }

        BodyKeySanitizer IModelJsonSerializable<BodyKeySanitizer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBodyKeySanitizer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BodyKeySanitizer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BodyKeySanitizer IModelSerializable<BodyKeySanitizer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBodyKeySanitizer(doc.RootElement, options);
        }

        public static implicit operator RequestContent(BodyKeySanitizer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BodyKeySanitizer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBodyKeySanitizer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
