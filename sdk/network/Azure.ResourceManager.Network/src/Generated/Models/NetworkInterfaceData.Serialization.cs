// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkInterfaceData : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetworkInterfaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetworkInterfaceData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetworkInterfaceData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ETag))
                {
                    writer.WritePropertyName("etag"u8);
                    writer.WriteStringValue(ETag.Value.ToString());
                }
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceType))
                {
                    writer.WritePropertyName("type"u8);
                    writer.WriteStringValue(ResourceType.Value);
                }
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(VirtualMachine))
                {
                    writer.WritePropertyName("virtualMachine"u8);
                    JsonSerializer.Serialize(writer, VirtualMachine);
                }
            }
            if (Optional.IsDefined(NetworkSecurityGroup))
            {
                writer.WritePropertyName("networkSecurityGroup"u8);
                writer.WriteObjectValue(NetworkSecurityGroup);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PrivateEndpoint))
                {
                    writer.WritePropertyName("privateEndpoint"u8);
                    writer.WriteObjectValue(PrivateEndpoint);
                }
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(TapConfigurations))
                {
                    writer.WritePropertyName("tapConfigurations"u8);
                    writer.WriteStartArray();
                    foreach (var item in TapConfigurations)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsDefined(DnsSettings))
            {
                writer.WritePropertyName("dnsSettings"u8);
                writer.WriteObjectValue(DnsSettings);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MacAddress))
                {
                    writer.WritePropertyName("macAddress"u8);
                    writer.WriteStringValue(MacAddress);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Primary))
                {
                    writer.WritePropertyName("primary"u8);
                    writer.WriteBooleanValue(Primary.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(VnetEncryptionSupported))
                {
                    writer.WritePropertyName("vnetEncryptionSupported"u8);
                    writer.WriteBooleanValue(VnetEncryptionSupported.Value);
                }
            }
            if (Optional.IsDefined(EnableAcceleratedNetworking))
            {
                writer.WritePropertyName("enableAcceleratedNetworking"u8);
                writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
            }
            if (Optional.IsDefined(DisableTcpStateTracking))
            {
                writer.WritePropertyName("disableTcpStateTracking"u8);
                writer.WriteBooleanValue(DisableTcpStateTracking.Value);
            }
            if (Optional.IsDefined(EnableIPForwarding))
            {
                writer.WritePropertyName("enableIPForwarding"u8);
                writer.WriteBooleanValue(EnableIPForwarding.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(HostedWorkloads))
                {
                    writer.WritePropertyName("hostedWorkloads"u8);
                    writer.WriteStartArray();
                    foreach (var item in HostedWorkloads)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DscpConfiguration))
                {
                    writer.WritePropertyName("dscpConfiguration"u8);
                    JsonSerializer.Serialize(writer, DscpConfiguration);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceGuid))
                {
                    writer.WritePropertyName("resourceGuid"u8);
                    writer.WriteStringValue(ResourceGuid.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            if (Optional.IsDefined(NicType))
            {
                writer.WritePropertyName("nicType"u8);
                writer.WriteStringValue(NicType.Value.ToString());
            }
            if (Optional.IsDefined(PrivateLinkService))
            {
                writer.WritePropertyName("privateLinkService"u8);
                writer.WriteObjectValue(PrivateLinkService);
            }
            if (Optional.IsDefined(MigrationPhase))
            {
                writer.WritePropertyName("migrationPhase"u8);
                writer.WriteStringValue(MigrationPhase.Value.ToString());
            }
            if (Optional.IsDefined(AuxiliaryMode))
            {
                writer.WritePropertyName("auxiliaryMode"u8);
                writer.WriteStringValue(AuxiliaryMode.Value.ToString());
            }
            if (Optional.IsDefined(AuxiliarySku))
            {
                writer.WritePropertyName("auxiliarySku"u8);
                writer.WriteStringValue(AuxiliarySku.Value.ToString());
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NetworkInterfaceData IJsonModel<NetworkInterfaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceData(document.RootElement, options);
        }

        internal static NetworkInterfaceData DeserializeNetworkInterfaceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExtendedLocation> extendedLocation = default;
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<WritableSubResource> virtualMachine = default;
            Optional<NetworkSecurityGroupData> networkSecurityGroup = default;
            Optional<PrivateEndpointData> privateEndpoint = default;
            Optional<IList<NetworkInterfaceIPConfigurationData>> ipConfigurations = default;
            Optional<IReadOnlyList<NetworkInterfaceTapConfigurationData>> tapConfigurations = default;
            Optional<NetworkInterfaceDnsSettings> dnsSettings = default;
            Optional<string> macAddress = default;
            Optional<bool> primary = default;
            Optional<bool> vnetEncryptionSupported = default;
            Optional<bool> enableAcceleratedNetworking = default;
            Optional<bool> disableTcpStateTracking = default;
            Optional<bool> enableIPForwarding = default;
            Optional<IReadOnlyList<string>> hostedWorkloads = default;
            Optional<WritableSubResource> dscpConfiguration = default;
            Optional<Guid> resourceGuid = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<string> workloadType = default;
            Optional<NetworkInterfaceNicType> nicType = default;
            Optional<PrivateLinkServiceData> privateLinkService = default;
            Optional<NetworkInterfaceMigrationPhase> migrationPhase = default;
            Optional<NetworkInterfaceAuxiliaryMode> auxiliaryMode = default;
            Optional<NetworkInterfaceAuxiliarySku> auxiliarySku = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
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
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualMachine"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachine = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityGroup = NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateEndpoint = PrivateEndpointData.DeserializePrivateEndpointData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceIPConfigurationData> array = new List<NetworkInterfaceIPConfigurationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceIPConfigurationData.DeserializeNetworkInterfaceIPConfigurationData(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("tapConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceTapConfigurationData> array = new List<NetworkInterfaceTapConfigurationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceTapConfigurationData.DeserializeNetworkInterfaceTapConfigurationData(item));
                            }
                            tapConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsSettings = NetworkInterfaceDnsSettings.DeserializeNetworkInterfaceDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("macAddress"u8))
                        {
                            macAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("primary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("vnetEncryptionSupported"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vnetEncryptionSupported = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAcceleratedNetworking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAcceleratedNetworking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("disableTcpStateTracking"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableTcpStateTracking = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableIPForwarding"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableIPForwarding = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hostedWorkloads"u8))
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
                            hostedWorkloads = array;
                            continue;
                        }
                        if (property0.NameEquals("dscpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dscpConfiguration = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("workloadType"u8))
                        {
                            workloadType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nicType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nicType = new NetworkInterfaceNicType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkService = PrivateLinkServiceData.DeserializePrivateLinkServiceData(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("migrationPhase"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            migrationPhase = new NetworkInterfaceMigrationPhase(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("auxiliaryMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            auxiliaryMode = new NetworkInterfaceAuxiliaryMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("auxiliarySku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            auxiliarySku = new NetworkInterfaceAuxiliarySku(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkInterfaceData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), serializedAdditionalRawData, extendedLocation, Optional.ToNullable(etag), virtualMachine, networkSecurityGroup.Value, privateEndpoint.Value, Optional.ToList(ipConfigurations), Optional.ToList(tapConfigurations), dnsSettings.Value, macAddress.Value, Optional.ToNullable(primary), Optional.ToNullable(vnetEncryptionSupported), Optional.ToNullable(enableAcceleratedNetworking), Optional.ToNullable(disableTcpStateTracking), Optional.ToNullable(enableIPForwarding), Optional.ToList(hostedWorkloads), dscpConfiguration, Optional.ToNullable(resourceGuid), Optional.ToNullable(provisioningState), workloadType.Value, Optional.ToNullable(nicType), privateLinkService.Value, Optional.ToNullable(migrationPhase), Optional.ToNullable(auxiliaryMode), Optional.ToNullable(auxiliarySku));
        }

        BinaryData IPersistableModel<NetworkInterfaceData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkInterfaceData IPersistableModel<NetworkInterfaceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkInterfaceData(document.RootElement, options);
        }

        string IPersistableModel<NetworkInterfaceData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
