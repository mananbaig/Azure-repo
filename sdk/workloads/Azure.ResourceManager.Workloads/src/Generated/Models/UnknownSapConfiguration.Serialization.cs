// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class UnknownSapConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<SapConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapConfiguration>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        internal static SapConfiguration DeserializeUnknownSapConfiguration(JsonElement element, ModelSerializerOptions options = default) => DeserializeSapConfiguration(element, options);

        SapConfiguration IModelJsonSerializable<SapConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownSapConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapConfiguration IModelSerializable<SapConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapConfiguration(doc.RootElement, options);
        }
    }
}
