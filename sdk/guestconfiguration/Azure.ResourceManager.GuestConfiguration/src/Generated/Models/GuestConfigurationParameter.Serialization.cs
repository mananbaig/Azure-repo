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

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class GuestConfigurationParameter : IUtf8JsonSerializable, IModelJsonSerializable<GuestConfigurationParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GuestConfigurationParameter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GuestConfigurationParameter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GuestConfigurationParameter>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
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

        internal static GuestConfigurationParameter DeserializeGuestConfigurationParameter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
            return new GuestConfigurationParameter(name.Value, value.Value, serializedAdditionalRawData);
        }

        GuestConfigurationParameter IModelJsonSerializable<GuestConfigurationParameter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GuestConfigurationParameter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestConfigurationParameter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GuestConfigurationParameter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GuestConfigurationParameter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GuestConfigurationParameter IModelSerializable<GuestConfigurationParameter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GuestConfigurationParameter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGuestConfigurationParameter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GuestConfigurationParameter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GuestConfigurationParameter"/> to convert. </param>
        public static implicit operator RequestContent(GuestConfigurationParameter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GuestConfigurationParameter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GuestConfigurationParameter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGuestConfigurationParameter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
