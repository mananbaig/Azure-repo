// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class UnknownWorkloadNetworkDhcpEntity : IUtf8JsonSerializable, IModelJsonSerializable<WorkloadNetworkDhcpEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WorkloadNetworkDhcpEntity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WorkloadNetworkDhcpEntity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("dhcpType"u8);
            writer.WriteStringValue(DhcpType.ToString());
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Revision))
            {
                writer.WritePropertyName("revision"u8);
                writer.WriteNumberValue(Revision.Value);
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

        internal static WorkloadNetworkDhcpEntity DeserializeUnknownWorkloadNetworkDhcpEntity(JsonElement element, ModelSerializerOptions options = default) => DeserializeWorkloadNetworkDhcpEntity(element, options);

        WorkloadNetworkDhcpEntity IModelJsonSerializable<WorkloadNetworkDhcpEntity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownWorkloadNetworkDhcpEntity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WorkloadNetworkDhcpEntity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WorkloadNetworkDhcpEntity IModelSerializable<WorkloadNetworkDhcpEntity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWorkloadNetworkDhcpEntity(doc.RootElement, options);
        }
    }
}
