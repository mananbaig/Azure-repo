// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class UnknownResourceDetails : IUtf8JsonSerializable, IModelJsonSerializable<SecurityCenterResourceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityCenterResourceDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityCenterResourceDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityCenterResourceDetails>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source.ToString());
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

        internal static SecurityCenterResourceDetails DeserializeUnknownResourceDetails(JsonElement element, ModelSerializerOptions options = default) => DeserializeSecurityCenterResourceDetails(element, options);

        SecurityCenterResourceDetails IModelJsonSerializable<SecurityCenterResourceDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityCenterResourceDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownResourceDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityCenterResourceDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityCenterResourceDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityCenterResourceDetails IModelSerializable<SecurityCenterResourceDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityCenterResourceDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityCenterResourceDetails(doc.RootElement, options);
        }
    }
}
