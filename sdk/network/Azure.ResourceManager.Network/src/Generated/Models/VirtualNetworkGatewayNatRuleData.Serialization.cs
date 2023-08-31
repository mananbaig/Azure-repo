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
    public partial class VirtualNetworkGatewayNatRuleData : IUtf8JsonSerializable, IModelJsonSerializable<VirtualNetworkGatewayNatRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualNetworkGatewayNatRuleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualNetworkGatewayNatRuleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualNetworkGatewayNatRuleData>(this, options.Format);

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
            if (Optional.IsDefined(VpnNatRuleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(VpnNatRuleType.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InternalMappings))
            {
                writer.WritePropertyName("internalMappings"u8);
                writer.WriteStartArray();
                foreach (var item in InternalMappings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VpnNatRuleMapping>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalMappings))
            {
                writer.WritePropertyName("externalMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalMappings)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VpnNatRuleMapping>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IPConfigurationId))
            {
                writer.WritePropertyName("ipConfigurationId"u8);
                writer.WriteStringValue(IPConfigurationId);
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

        internal static VirtualNetworkGatewayNatRuleData DeserializeVirtualNetworkGatewayNatRuleData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<VpnNatRuleType> type0 = default;
            Optional<VpnNatRuleMode> mode = default;
            Optional<IList<VpnNatRuleMapping>> internalMappings = default;
            Optional<IList<VpnNatRuleMapping>> externalMappings = default;
            Optional<string> ipConfigurationId = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new VpnNatRuleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mode = new VpnNatRuleMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("internalMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item));
                            }
                            internalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("externalMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VpnNatRuleMapping> array = new List<VpnNatRuleMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VpnNatRuleMapping.DeserializeVpnNatRuleMapping(item));
                            }
                            externalMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurationId"u8))
                        {
                            ipConfigurationId = property0.Value.GetString();
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
            return new VirtualNetworkGatewayNatRuleData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToNullable(provisioningState), Optional.ToNullable(type0), Optional.ToNullable(mode), Optional.ToList(internalMappings), Optional.ToList(externalMappings), ipConfigurationId.Value, rawData);
        }

        VirtualNetworkGatewayNatRuleData IModelJsonSerializable<VirtualNetworkGatewayNatRuleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualNetworkGatewayNatRuleData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualNetworkGatewayNatRuleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualNetworkGatewayNatRuleData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualNetworkGatewayNatRuleData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualNetworkGatewayNatRuleData IModelSerializable<VirtualNetworkGatewayNatRuleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VirtualNetworkGatewayNatRuleData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualNetworkGatewayNatRuleData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VirtualNetworkGatewayNatRuleData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VirtualNetworkGatewayNatRuleData"/> to convert. </param>
        public static implicit operator RequestContent(VirtualNetworkGatewayNatRuleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VirtualNetworkGatewayNatRuleData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VirtualNetworkGatewayNatRuleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualNetworkGatewayNatRuleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
