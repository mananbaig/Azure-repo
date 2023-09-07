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

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class RawValueSecretInfo : IUtf8JsonSerializable, IModelJsonSerializable<RawValueSecretInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RawValueSecretInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RawValueSecretInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RawValueSecretInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                if (Value != null)
                {
                    writer.WritePropertyName("value"u8);
                    writer.WriteStringValue(Value);
                }
                else
                {
                    writer.WriteNull("value");
                }
            }
            writer.WritePropertyName("secretType"u8);
            writer.WriteStringValue(SecretType.ToString());
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

        internal static RawValueSecretInfo DeserializeRawValueSecretInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> value = default;
            LinkerSecretType secretType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        value = null;
                        continue;
                    }
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretType"u8))
                {
                    secretType = new LinkerSecretType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RawValueSecretInfo(secretType, value.Value, serializedAdditionalRawData);
        }

        RawValueSecretInfo IModelJsonSerializable<RawValueSecretInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RawValueSecretInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRawValueSecretInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RawValueSecretInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RawValueSecretInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RawValueSecretInfo IModelSerializable<RawValueSecretInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RawValueSecretInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRawValueSecretInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RawValueSecretInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RawValueSecretInfo"/> to convert. </param>
        public static implicit operator RequestContent(RawValueSecretInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RawValueSecretInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RawValueSecretInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRawValueSecretInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
