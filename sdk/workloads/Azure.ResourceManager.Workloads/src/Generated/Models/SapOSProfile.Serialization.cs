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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapOSProfile : IUtf8JsonSerializable, IModelJsonSerializable<SapOSProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapOSProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapOSProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapOSProfile>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AdminUsername))
            {
                writer.WritePropertyName("adminUsername"u8);
                writer.WriteStringValue(AdminUsername);
            }
            if (Optional.IsDefined(AdminPassword))
            {
                writer.WritePropertyName("adminPassword"u8);
                writer.WriteStringValue(AdminPassword);
            }
            if (Optional.IsDefined(OSConfiguration))
            {
                writer.WritePropertyName("osConfiguration"u8);
                if (OSConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SapOSConfiguration>)OSConfiguration).Serialize(writer, options);
                }
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

        internal static SapOSProfile DeserializeSapOSProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> adminUsername = default;
            Optional<string> adminPassword = default;
            Optional<SapOSConfiguration> osConfiguration = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminUsername"u8))
                {
                    adminUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("adminPassword"u8))
                {
                    adminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osConfiguration = SapOSConfiguration.DeserializeSapOSConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SapOSProfile(adminUsername.Value, adminPassword.Value, osConfiguration.Value, serializedAdditionalRawData);
        }

        SapOSProfile IModelJsonSerializable<SapOSProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapOSProfile>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapOSProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapOSProfile>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapOSProfile>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapOSProfile IModelSerializable<SapOSProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapOSProfile>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapOSProfile(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SapOSProfile"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SapOSProfile"/> to convert. </param>
        public static implicit operator RequestContent(SapOSProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SapOSProfile"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SapOSProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapOSProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
