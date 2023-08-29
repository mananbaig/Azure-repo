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

namespace Azure.ResourceManager.Network
{
    public partial class NetworkVirtualApplianceConnectionData : IUtf8JsonSerializable, IModelJsonSerializable<NetworkVirtualApplianceConnectionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkVirtualApplianceConnectionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkVirtualApplianceConnectionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkVirtualApplianceConnectionData>(this, options.Format);

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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamePropertiesName);
            }
            if (Optional.IsDefined(Asn))
            {
                writer.WritePropertyName("asn"u8);
                writer.WriteNumberValue(Asn.Value);
            }
            if (Optional.IsDefined(TunnelIdentifier))
            {
                writer.WritePropertyName("tunnelIdentifier"u8);
                writer.WriteNumberValue(TunnelIdentifier.Value);
            }
            if (Optional.IsCollectionDefined(BgpPeerAddress))
            {
                writer.WritePropertyName("bgpPeerAddress"u8);
                writer.WriteStartArray();
                foreach (var item in BgpPeerAddress)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableInternetSecurity))
            {
                writer.WritePropertyName("enableInternetSecurity"u8);
                writer.WriteBooleanValue(EnableInternetSecurity.Value);
            }
            if (Optional.IsDefined(RoutingConfiguration))
            {
                writer.WritePropertyName("routingConfiguration"u8);
                writer.WriteObjectValue(RoutingConfiguration);
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

        internal static NetworkVirtualApplianceConnectionData DeserializeNetworkVirtualApplianceConnectionData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<string> name0 = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<long> asn = default;
            Optional<long> tunnelIdentifier = default;
            Optional<IList<string>> bgpPeerAddress = default;
            Optional<bool> enableInternetSecurity = default;
            Optional<RoutingConfigurationNfv> routingConfiguration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
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
                        if (property0.NameEquals("asn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            asn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("tunnelIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tunnelIdentifier = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bgpPeerAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            bgpPeerAddress = array;
                            continue;
                        }
                        if (property0.NameEquals("enableInternetSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableInternetSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("routingConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingConfiguration = RoutingConfigurationNfv.DeserializeRoutingConfigurationNfv(property0.Value);
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
            return new NetworkVirtualApplianceConnectionData(id.Value, name.Value, Optional.ToNullable(type), name0.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(asn), Optional.ToNullable(tunnelIdentifier), Optional.ToList(bgpPeerAddress), Optional.ToNullable(enableInternetSecurity), routingConfiguration.Value, rawData);
        }

        NetworkVirtualApplianceConnectionData IModelJsonSerializable<NetworkVirtualApplianceConnectionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkVirtualApplianceConnectionData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkVirtualApplianceConnectionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkVirtualApplianceConnectionData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkVirtualApplianceConnectionData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkVirtualApplianceConnectionData IModelSerializable<NetworkVirtualApplianceConnectionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkVirtualApplianceConnectionData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkVirtualApplianceConnectionData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkVirtualApplianceConnectionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkVirtualApplianceConnectionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkVirtualApplianceConnectionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
