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
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServiceProperties : IUtf8JsonSerializable, IModelJsonSerializable<DeviceProvisioningServiceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeviceProvisioningServiceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeviceProvisioningServiceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceProvisioningServiceProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IPFilterRules))
            {
                writer.WritePropertyName("ipFilterRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPFilterRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DeviceProvisioningServicesIPFilterRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DeviceProvisioningServicesPrivateEndpointConnectionData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsCollectionDefined(IotHubs))
            {
                writer.WritePropertyName("iotHubs"u8);
                writer.WriteStartArray();
                foreach (var item in IotHubs)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IotHubDefinitionDescription>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AllocationPolicy))
            {
                writer.WritePropertyName("allocationPolicy"u8);
                writer.WriteStringValue(AllocationPolicy.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AuthorizationPolicies))
            {
                writer.WritePropertyName("authorizationPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizationPolicies)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DeviceProvisioningServicesSharedAccessKey>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsDataResidencyEnabled))
            {
                writer.WritePropertyName("enableDataResidency"u8);
                writer.WriteBooleanValue(IsDataResidencyEnabled.Value);
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

        internal static DeviceProvisioningServiceProperties DeserializeDeviceProvisioningServiceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DeviceProvisioningServicesState> state = default;
            Optional<DeviceProvisioningServicesPublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<DeviceProvisioningServicesIPFilterRule>> ipFilterRules = default;
            Optional<IList<DeviceProvisioningServicesPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Optional<string> provisioningState = default;
            Optional<IList<IotHubDefinitionDescription>> iotHubs = default;
            Optional<DeviceProvisioningServicesAllocationPolicy> allocationPolicy = default;
            Optional<string> serviceOperationsHostName = default;
            Optional<string> deviceProvisioningHostName = default;
            Optional<string> idScope = default;
            Optional<IList<DeviceProvisioningServicesSharedAccessKey>> authorizationPolicies = default;
            Optional<bool> enableDataResidency = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new DeviceProvisioningServicesState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new DeviceProvisioningServicesPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipFilterRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesIPFilterRule> array = new List<DeviceProvisioningServicesIPFilterRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesIPFilterRule.DeserializeDeviceProvisioningServicesIPFilterRule(item));
                    }
                    ipFilterRules = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesPrivateEndpointConnectionData> array = new List<DeviceProvisioningServicesPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesPrivateEndpointConnectionData.DeserializeDeviceProvisioningServicesPrivateEndpointConnectionData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iotHubs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotHubDefinitionDescription> array = new List<IotHubDefinitionDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotHubDefinitionDescription.DeserializeIotHubDefinitionDescription(item));
                    }
                    iotHubs = array;
                    continue;
                }
                if (property.NameEquals("allocationPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationPolicy = new DeviceProvisioningServicesAllocationPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serviceOperationsHostName"u8))
                {
                    serviceOperationsHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceProvisioningHostName"u8))
                {
                    deviceProvisioningHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("idScope"u8))
                {
                    idScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizationPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesSharedAccessKey> array = new List<DeviceProvisioningServicesSharedAccessKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesSharedAccessKey.DeserializeDeviceProvisioningServicesSharedAccessKey(item));
                    }
                    authorizationPolicies = array;
                    continue;
                }
                if (property.NameEquals("enableDataResidency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDataResidency = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DeviceProvisioningServiceProperties(Optional.ToNullable(state), Optional.ToNullable(publicNetworkAccess), Optional.ToList(ipFilterRules), Optional.ToList(privateEndpointConnections), provisioningState.Value, Optional.ToList(iotHubs), Optional.ToNullable(allocationPolicy), serviceOperationsHostName.Value, deviceProvisioningHostName.Value, idScope.Value, Optional.ToList(authorizationPolicies), Optional.ToNullable(enableDataResidency), serializedAdditionalRawData);
        }

        DeviceProvisioningServiceProperties IModelJsonSerializable<DeviceProvisioningServiceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceProvisioningServiceProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceProvisioningServiceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeviceProvisioningServiceProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceProvisioningServiceProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeviceProvisioningServiceProperties IModelSerializable<DeviceProvisioningServiceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeviceProvisioningServiceProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeviceProvisioningServiceProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeviceProvisioningServiceProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeviceProvisioningServiceProperties"/> to convert. </param>
        public static implicit operator RequestContent(DeviceProvisioningServiceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeviceProvisioningServiceProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeviceProvisioningServiceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeviceProvisioningServiceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
