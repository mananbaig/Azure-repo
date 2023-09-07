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

namespace Azure.ResourceManager.HardwareSecurityModules.Models
{
    internal partial class HardwareSecurityModulesSku : IUtf8JsonSerializable, IModelJsonSerializable<HardwareSecurityModulesSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HardwareSecurityModulesSku>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HardwareSecurityModulesSku>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HardwareSecurityModulesSku>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name.Value.ToString());
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

        internal static HardwareSecurityModulesSku DeserializeHardwareSecurityModulesSku(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HardwareSecurityModulesSkuName> name = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = new HardwareSecurityModulesSkuName(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HardwareSecurityModulesSku(Optional.ToNullable(name), serializedAdditionalRawData);
        }

        HardwareSecurityModulesSku IModelJsonSerializable<HardwareSecurityModulesSku>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HardwareSecurityModulesSku>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHardwareSecurityModulesSku(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HardwareSecurityModulesSku>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HardwareSecurityModulesSku>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HardwareSecurityModulesSku IModelSerializable<HardwareSecurityModulesSku>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HardwareSecurityModulesSku>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHardwareSecurityModulesSku(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HardwareSecurityModulesSku"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HardwareSecurityModulesSku"/> to convert. </param>
        public static implicit operator RequestContent(HardwareSecurityModulesSku model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HardwareSecurityModulesSku"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HardwareSecurityModulesSku(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHardwareSecurityModulesSku(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
