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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusDisasterRecoveryData : IUtf8JsonSerializable, IModelJsonSerializable<ServiceBusDisasterRecoveryData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceBusDisasterRecoveryData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceBusDisasterRecoveryData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusDisasterRecoveryData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PartnerNamespace))
            {
                writer.WritePropertyName("partnerNamespace"u8);
                writer.WriteStringValue(PartnerNamespace);
            }
            if (Optional.IsDefined(AlternateName))
            {
                writer.WritePropertyName("alternateName"u8);
                writer.WriteStringValue(AlternateName);
            }
            writer.WriteEndObject();
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

        internal static ServiceBusDisasterRecoveryData DeserializeServiceBusDisasterRecoveryData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ServiceBusDisasterRecoveryProvisioningState> provisioningState = default;
            Optional<long> pendingReplicationOperationsCount = default;
            Optional<string> partnerNamespace = default;
            Optional<string> alternateName = default;
            Optional<ServiceBusDisasterRecoveryRole> role = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToServiceBusDisasterRecoveryProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("pendingReplicationOperationsCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pendingReplicationOperationsCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("partnerNamespace"u8))
                        {
                            partnerNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alternateName"u8))
                        {
                            alternateName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            role = property0.Value.GetString().ToServiceBusDisasterRecoveryRole();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceBusDisasterRecoveryData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(pendingReplicationOperationsCount), partnerNamespace.Value, alternateName.Value, Optional.ToNullable(role), Optional.ToNullable(location), serializedAdditionalRawData);
        }

        ServiceBusDisasterRecoveryData IModelJsonSerializable<ServiceBusDisasterRecoveryData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusDisasterRecoveryData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusDisasterRecoveryData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceBusDisasterRecoveryData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusDisasterRecoveryData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceBusDisasterRecoveryData IModelSerializable<ServiceBusDisasterRecoveryData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusDisasterRecoveryData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceBusDisasterRecoveryData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceBusDisasterRecoveryData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceBusDisasterRecoveryData"/> to convert. </param>
        public static implicit operator RequestContent(ServiceBusDisasterRecoveryData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceBusDisasterRecoveryData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceBusDisasterRecoveryData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceBusDisasterRecoveryData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
