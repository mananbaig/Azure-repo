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
    public partial class AuthPlatform : IUtf8JsonSerializable, IModelJsonSerializable<AuthPlatform>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AuthPlatform>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AuthPlatform>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AuthPlatform>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(RuntimeVersion))
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (Optional.IsDefined(ConfigFilePath))
            {
                writer.WritePropertyName("configFilePath"u8);
                writer.WriteStringValue(ConfigFilePath);
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

        internal static AuthPlatform DeserializeAuthPlatform(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> runtimeVersion = default;
            Optional<string> configFilePath = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configFilePath"u8))
                {
                    configFilePath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AuthPlatform(Optional.ToNullable(enabled), runtimeVersion.Value, configFilePath.Value, serializedAdditionalRawData);
        }

        AuthPlatform IModelJsonSerializable<AuthPlatform>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AuthPlatform>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthPlatform(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AuthPlatform>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AuthPlatform>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AuthPlatform IModelSerializable<AuthPlatform>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AuthPlatform>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAuthPlatform(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AuthPlatform"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AuthPlatform"/> to convert. </param>
        public static implicit operator RequestContent(AuthPlatform model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AuthPlatform"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AuthPlatform(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAuthPlatform(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
