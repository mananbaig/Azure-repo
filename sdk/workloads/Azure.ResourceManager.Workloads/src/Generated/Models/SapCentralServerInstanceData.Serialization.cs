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
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    public partial class SapCentralServerInstanceData : IUtf8JsonSerializable, IModelJsonSerializable<SapCentralServerInstanceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapCentralServerInstanceData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapCentralServerInstanceData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapCentralServerInstanceData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MessageServerProperties))
            {
                writer.WritePropertyName("messageServerProperties"u8);
                if (MessageServerProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MessageServerProperties>)MessageServerProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(EnqueueServerProperties))
            {
                writer.WritePropertyName("enqueueServerProperties"u8);
                if (EnqueueServerProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EnqueueServerProperties>)EnqueueServerProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(GatewayServerProperties))
            {
                writer.WritePropertyName("gatewayServerProperties"u8);
                if (GatewayServerProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<GatewayServerProperties>)GatewayServerProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(EnqueueReplicationServerProperties))
            {
                writer.WritePropertyName("enqueueReplicationServerProperties"u8);
                if (EnqueueReplicationServerProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<EnqueueReplicationServerProperties>)EnqueueReplicationServerProperties).Serialize(writer, options);
                }
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

        internal static SapCentralServerInstanceData DeserializeSapCentralServerInstanceData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> instanceNo = default;
            Optional<ResourceIdentifier> subnet = default;
            Optional<MessageServerProperties> messageServerProperties = default;
            Optional<EnqueueServerProperties> enqueueServerProperties = default;
            Optional<GatewayServerProperties> gatewayServerProperties = default;
            Optional<EnqueueReplicationServerProperties> enqueueReplicationServerProperties = default;
            Optional<string> kernelVersion = default;
            Optional<string> kernelPatch = default;
            Optional<SubResource> loadBalancerDetails = default;
            Optional<IReadOnlyList<CentralServerVmDetails>> vmDetails = default;
            Optional<SapVirtualInstanceStatus> status = default;
            Optional<SapHealthState> health = default;
            Optional<SapVirtualInstanceProvisioningState> provisioningState = default;
            Optional<SapVirtualInstanceError> errors = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
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
                        if (property0.NameEquals("instanceNo"u8))
                        {
                            instanceNo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("messageServerProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            messageServerProperties = MessageServerProperties.DeserializeMessageServerProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enqueueServerProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enqueueServerProperties = EnqueueServerProperties.DeserializeEnqueueServerProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("gatewayServerProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            gatewayServerProperties = GatewayServerProperties.DeserializeGatewayServerProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enqueueReplicationServerProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enqueueReplicationServerProperties = EnqueueReplicationServerProperties.DeserializeEnqueueReplicationServerProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("kernelVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kernelVersion = null;
                                continue;
                            }
                            kernelVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("kernelPatch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                kernelPatch = null;
                                continue;
                            }
                            kernelPatch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            loadBalancerDetails = JsonSerializer.Deserialize<SubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("vmDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CentralServerVmDetails> array = new List<CentralServerVmDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CentralServerVmDetails.DeserializeCentralServerVmDetails(item));
                            }
                            vmDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new SapVirtualInstanceStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("health"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            health = new SapHealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SapVirtualInstanceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("errors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errors = SapVirtualInstanceError.DeserializeSapVirtualInstanceError(property0.Value);
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
            return new SapCentralServerInstanceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, instanceNo.Value, subnet.Value, messageServerProperties.Value, enqueueServerProperties.Value, gatewayServerProperties.Value, enqueueReplicationServerProperties.Value, kernelVersion.Value, kernelPatch.Value, loadBalancerDetails, Optional.ToList(vmDetails), Optional.ToNullable(status), Optional.ToNullable(health), Optional.ToNullable(provisioningState), errors.Value, serializedAdditionalRawData);
        }

        SapCentralServerInstanceData IModelJsonSerializable<SapCentralServerInstanceData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapCentralServerInstanceData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapCentralServerInstanceData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapCentralServerInstanceData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapCentralServerInstanceData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapCentralServerInstanceData IModelSerializable<SapCentralServerInstanceData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapCentralServerInstanceData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapCentralServerInstanceData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SapCentralServerInstanceData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SapCentralServerInstanceData"/> to convert. </param>
        public static implicit operator RequestContent(SapCentralServerInstanceData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SapCentralServerInstanceData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SapCentralServerInstanceData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapCentralServerInstanceData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
