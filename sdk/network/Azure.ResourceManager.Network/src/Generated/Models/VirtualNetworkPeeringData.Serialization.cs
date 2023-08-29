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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualNetworkPeeringData : IUtf8JsonSerializable, IModelJsonSerializable<VirtualNetworkPeeringData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualNetworkPeeringData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualNetworkPeeringData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualNetworkPeeringData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AllowVirtualNetworkAccess))
            {
                writer.WritePropertyName("allowVirtualNetworkAccess"u8);
                writer.WriteBooleanValue(AllowVirtualNetworkAccess.Value);
            }
            if (Optional.IsDefined(AllowForwardedTraffic))
            {
                writer.WritePropertyName("allowForwardedTraffic"u8);
                writer.WriteBooleanValue(AllowForwardedTraffic.Value);
            }
            if (Optional.IsDefined(AllowGatewayTransit))
            {
                writer.WritePropertyName("allowGatewayTransit"u8);
                writer.WriteBooleanValue(AllowGatewayTransit.Value);
            }
            if (Optional.IsDefined(UseRemoteGateways))
            {
                writer.WritePropertyName("useRemoteGateways"u8);
                writer.WriteBooleanValue(UseRemoteGateways.Value);
            }
            if (Optional.IsDefined(RemoteVirtualNetwork))
            {
                writer.WritePropertyName("remoteVirtualNetwork"u8);
                JsonSerializer.Serialize(writer, RemoteVirtualNetwork);
            }
            if (Optional.IsDefined(RemoteAddressSpace))
            {
                writer.WritePropertyName("remoteAddressSpace"u8);
                writer.WriteObjectValue(RemoteAddressSpace);
            }
            if (Optional.IsDefined(RemoteVirtualNetworkAddressSpace))
            {
                writer.WritePropertyName("remoteVirtualNetworkAddressSpace"u8);
                writer.WriteObjectValue(RemoteVirtualNetworkAddressSpace);
            }
            if (Optional.IsDefined(RemoteBgpCommunities))
            {
                writer.WritePropertyName("remoteBgpCommunities"u8);
                writer.WriteObjectValue(RemoteBgpCommunities);
            }
            if (Optional.IsDefined(PeeringState))
            {
                writer.WritePropertyName("peeringState"u8);
                writer.WriteStringValue(PeeringState.Value.ToString());
            }
            if (Optional.IsDefined(PeeringSyncLevel))
            {
                writer.WritePropertyName("peeringSyncLevel"u8);
                writer.WriteStringValue(PeeringSyncLevel.Value.ToString());
            }
            if (Optional.IsDefined(DoNotVerifyRemoteGateways))
            {
                writer.WritePropertyName("doNotVerifyRemoteGateways"u8);
                writer.WriteBooleanValue(DoNotVerifyRemoteGateways.Value);
            }
            writer.WriteEndObject();
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

        internal static VirtualNetworkPeeringData DeserializeVirtualNetworkPeeringData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<bool> allowVirtualNetworkAccess = default;
            Optional<bool> allowForwardedTraffic = default;
            Optional<bool> allowGatewayTransit = default;
            Optional<bool> useRemoteGateways = default;
            Optional<WritableSubResource> remoteVirtualNetwork = default;
            Optional<AddressSpace> remoteAddressSpace = default;
            Optional<AddressSpace> remoteVirtualNetworkAddressSpace = default;
            Optional<VirtualNetworkBgpCommunities> remoteBgpCommunities = default;
            Optional<VirtualNetworkEncryption> remoteVirtualNetworkEncryption = default;
            Optional<VirtualNetworkPeeringState> peeringState = default;
            Optional<VirtualNetworkPeeringLevel> peeringSyncLevel = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<bool> doNotVerifyRemoteGateways = default;
            Optional<Guid> resourceGuid = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("allowVirtualNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowVirtualNetworkAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowForwardedTraffic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowForwardedTraffic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowGatewayTransit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowGatewayTransit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useRemoteGateways"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useRemoteGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("remoteVirtualNetwork"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteVirtualNetwork = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("remoteAddressSpace"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteAddressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("remoteVirtualNetworkAddressSpace"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteVirtualNetworkAddressSpace = AddressSpace.DeserializeAddressSpace(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("remoteBgpCommunities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteBgpCommunities = VirtualNetworkBgpCommunities.DeserializeVirtualNetworkBgpCommunities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("remoteVirtualNetworkEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            remoteVirtualNetworkEncryption = VirtualNetworkEncryption.DeserializeVirtualNetworkEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peeringState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peeringState = new VirtualNetworkPeeringState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("peeringSyncLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peeringSyncLevel = new VirtualNetworkPeeringLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("doNotVerifyRemoteGateways"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            doNotVerifyRemoteGateways = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualNetworkPeeringData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToNullable(allowVirtualNetworkAccess), Optional.ToNullable(allowForwardedTraffic), Optional.ToNullable(allowGatewayTransit), Optional.ToNullable(useRemoteGateways), remoteVirtualNetwork, remoteAddressSpace.Value, remoteVirtualNetworkAddressSpace.Value, remoteBgpCommunities.Value, remoteVirtualNetworkEncryption.Value, Optional.ToNullable(peeringState), Optional.ToNullable(peeringSyncLevel), Optional.ToNullable(provisioningState), Optional.ToNullable(doNotVerifyRemoteGateways), Optional.ToNullable(resourceGuid), rawData);
        }

        VirtualNetworkPeeringData IModelJsonSerializable<VirtualNetworkPeeringData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualNetworkPeeringData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkPeeringData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualNetworkPeeringData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualNetworkPeeringData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualNetworkPeeringData IModelSerializable<VirtualNetworkPeeringData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualNetworkPeeringData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualNetworkPeeringData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VirtualNetworkPeeringData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VirtualNetworkPeeringData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualNetworkPeeringData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
