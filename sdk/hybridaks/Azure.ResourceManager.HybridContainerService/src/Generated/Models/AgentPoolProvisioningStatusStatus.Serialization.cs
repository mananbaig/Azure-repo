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

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class AgentPoolProvisioningStatusStatus : IUtf8JsonSerializable, IModelJsonSerializable<AgentPoolProvisioningStatusStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AgentPoolProvisioningStatusStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AgentPoolProvisioningStatusStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(ProvisioningStatus))
            {
                writer.WritePropertyName("provisioningStatus"u8);
                writer.WriteObjectValue(ProvisioningStatus);
            }
            if (Optional.IsDefined(ReadyReplicas))
            {
                writer.WritePropertyName("readyReplicas"u8);
                writer.WriteNumberValue(ReadyReplicas.Value);
            }
            if (Optional.IsDefined(Replicas))
            {
                writer.WritePropertyName("replicas"u8);
                writer.WriteNumberValue(Replicas.Value);
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

        internal static AgentPoolProvisioningStatusStatus DeserializeAgentPoolProvisioningStatusStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorMessage = default;
            Optional<AgentPoolProvisioningStatusStatusProvisioningStatus> provisioningStatus = default;
            Optional<int> readyReplicas = default;
            Optional<int> replicas = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatus = AgentPoolProvisioningStatusStatusProvisioningStatus.DeserializeAgentPoolProvisioningStatusStatusProvisioningStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("readyReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readyReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicas = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AgentPoolProvisioningStatusStatus(errorMessage.Value, provisioningStatus.Value, Optional.ToNullable(readyReplicas), Optional.ToNullable(replicas), rawData);
        }

        AgentPoolProvisioningStatusStatus IModelJsonSerializable<AgentPoolProvisioningStatusStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAgentPoolProvisioningStatusStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AgentPoolProvisioningStatusStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AgentPoolProvisioningStatusStatus IModelSerializable<AgentPoolProvisioningStatusStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAgentPoolProvisioningStatusStatus(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AgentPoolProvisioningStatusStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AgentPoolProvisioningStatusStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAgentPoolProvisioningStatusStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
