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
    internal partial class UnknownEnvironmentData : IUtf8JsonSerializable, IModelJsonSerializable<SecurityConnectorEnvironment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityConnectorEnvironment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityConnectorEnvironment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityConnectorEnvironment>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("environmentType"u8);
            writer.WriteStringValue(EnvironmentType.ToString());
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

        internal static SecurityConnectorEnvironment DeserializeUnknownEnvironmentData(JsonElement element, ModelSerializerOptions options = default) => DeserializeSecurityConnectorEnvironment(element, options);

        SecurityConnectorEnvironment IModelJsonSerializable<SecurityConnectorEnvironment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityConnectorEnvironment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownEnvironmentData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityConnectorEnvironment>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityConnectorEnvironment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityConnectorEnvironment IModelSerializable<SecurityConnectorEnvironment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityConnectorEnvironment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityConnectorEnvironment(doc.RootElement, options);
        }
    }
}
