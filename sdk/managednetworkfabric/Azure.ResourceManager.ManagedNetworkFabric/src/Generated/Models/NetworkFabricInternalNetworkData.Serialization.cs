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
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricInternalNetworkData : IUtf8JsonSerializable, IModelJsonSerializable<NetworkFabricInternalNetworkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkFabricInternalNetworkData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkFabricInternalNetworkData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(Mtu))
            {
                writer.WritePropertyName("mtu"u8);
                writer.WriteNumberValue(Mtu.Value);
            }
            if (Optional.IsCollectionDefined(ConnectedIPv4Subnets))
            {
                writer.WritePropertyName("connectedIPv4Subnets"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedIPv4Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConnectedIPv6Subnets))
            {
                writer.WritePropertyName("connectedIPv6Subnets"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedIPv6Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ImportRoutePolicyId))
            {
                writer.WritePropertyName("importRoutePolicyId"u8);
                writer.WriteStringValue(ImportRoutePolicyId);
            }
            if (Optional.IsDefined(ExportRoutePolicyId))
            {
                writer.WritePropertyName("exportRoutePolicyId"u8);
                writer.WriteStringValue(ExportRoutePolicyId);
            }
            if (Optional.IsDefined(ImportRoutePolicy))
            {
                writer.WritePropertyName("importRoutePolicy"u8);
                writer.WriteObjectValue(ImportRoutePolicy);
            }
            if (Optional.IsDefined(ExportRoutePolicy))
            {
                writer.WritePropertyName("exportRoutePolicy"u8);
                writer.WriteObjectValue(ExportRoutePolicy);
            }
            if (Optional.IsDefined(IngressAclId))
            {
                writer.WritePropertyName("ingressAclId"u8);
                writer.WriteStringValue(IngressAclId);
            }
            if (Optional.IsDefined(EgressAclId))
            {
                writer.WritePropertyName("egressAclId"u8);
                writer.WriteStringValue(EgressAclId);
            }
            if (Optional.IsDefined(IsMonitoringEnabled))
            {
                writer.WritePropertyName("isMonitoringEnabled"u8);
                writer.WriteStringValue(IsMonitoringEnabled.Value.ToString());
            }
            if (Optional.IsDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStringValue(Extension.Value.ToString());
            }
            writer.WritePropertyName("vlanId"u8);
            writer.WriteNumberValue(VlanId);
            if (Optional.IsDefined(BgpConfiguration))
            {
                writer.WritePropertyName("bgpConfiguration"u8);
                writer.WriteObjectValue(BgpConfiguration);
            }
            if (Optional.IsDefined(StaticRouteConfiguration))
            {
                writer.WritePropertyName("staticRouteConfiguration"u8);
                writer.WriteObjectValue(StaticRouteConfiguration);
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

        internal static NetworkFabricInternalNetworkData DeserializeNetworkFabricInternalNetworkData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> annotation = default;
            Optional<int> mtu = default;
            Optional<IList<ConnectedSubnet>> connectedIPv4Subnets = default;
            Optional<IList<ConnectedSubnet>> connectedIPv6Subnets = default;
            Optional<ResourceIdentifier> importRoutePolicyId = default;
            Optional<ResourceIdentifier> exportRoutePolicyId = default;
            Optional<ImportRoutePolicy> importRoutePolicy = default;
            Optional<ExportRoutePolicy> exportRoutePolicy = default;
            Optional<ResourceIdentifier> ingressAclId = default;
            Optional<ResourceIdentifier> egressAclId = default;
            Optional<IsMonitoringEnabled> isMonitoringEnabled = default;
            Optional<StaticRouteConfigurationExtension> extension = default;
            int vlanId = default;
            Optional<InternalNetworkBgpConfiguration> bgpConfiguration = default;
            Optional<InternalNetworkStaticRouteConfiguration> staticRouteConfiguration = default;
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mtu"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mtu = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("connectedIPv4Subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectedSubnet> array = new List<ConnectedSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectedSubnet.DeserializeConnectedSubnet(item));
                            }
                            connectedIPv4Subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("connectedIPv6Subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectedSubnet> array = new List<ConnectedSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectedSubnet.DeserializeConnectedSubnet(item));
                            }
                            connectedIPv6Subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicy = ImportRoutePolicy.DeserializeImportRoutePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicy = ExportRoutePolicy.DeserializeExportRoutePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ingressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressAclId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("egressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressAclId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isMonitoringEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isMonitoringEnabled = new IsMonitoringEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("extension"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            extension = new StaticRouteConfigurationExtension(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vlanId"u8))
                        {
                            vlanId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("bgpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpConfiguration = InternalNetworkBgpConfiguration.DeserializeInternalNetworkBgpConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("staticRouteConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            staticRouteConfiguration = InternalNetworkStaticRouteConfiguration.DeserializeInternalNetworkStaticRouteConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
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
            return new NetworkFabricInternalNetworkData(id, name, type, systemData.Value, annotation.Value, Optional.ToNullable(mtu), Optional.ToList(connectedIPv4Subnets), Optional.ToList(connectedIPv6Subnets), importRoutePolicyId.Value, exportRoutePolicyId.Value, importRoutePolicy.Value, exportRoutePolicy.Value, ingressAclId.Value, egressAclId.Value, Optional.ToNullable(isMonitoringEnabled), Optional.ToNullable(extension), vlanId, bgpConfiguration.Value, staticRouteConfiguration.Value, Optional.ToNullable(configurationState), Optional.ToNullable(provisioningState), Optional.ToNullable(administrativeState), rawData);
        }

        NetworkFabricInternalNetworkData IModelJsonSerializable<NetworkFabricInternalNetworkData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricInternalNetworkData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkFabricInternalNetworkData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkFabricInternalNetworkData IModelSerializable<NetworkFabricInternalNetworkData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkFabricInternalNetworkData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkFabricInternalNetworkData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkFabricInternalNetworkData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkFabricInternalNetworkData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
