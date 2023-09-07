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

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class CustomLocationAuthentication : IUtf8JsonSerializable, IModelJsonSerializable<CustomLocationAuthentication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomLocationAuthentication>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomLocationAuthentication>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomLocationAuthentication>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CustomLocationPropertiesAuthenticationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(CustomLocationPropertiesAuthenticationType);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
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

        internal static CustomLocationAuthentication DeserializeCustomLocationAuthentication(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<string> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CustomLocationAuthentication(type.Value, value.Value, serializedAdditionalRawData);
        }

        CustomLocationAuthentication IModelJsonSerializable<CustomLocationAuthentication>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomLocationAuthentication>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomLocationAuthentication(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomLocationAuthentication>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomLocationAuthentication>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomLocationAuthentication IModelSerializable<CustomLocationAuthentication>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CustomLocationAuthentication>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomLocationAuthentication(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CustomLocationAuthentication"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CustomLocationAuthentication"/> to convert. </param>
        public static implicit operator RequestContent(CustomLocationAuthentication model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CustomLocationAuthentication"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CustomLocationAuthentication(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomLocationAuthentication(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
