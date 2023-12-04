// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers
{
    public partial class ContainerAppManagedEnvironmentData : IUtf8JsonSerializable, IJsonModel<ContainerAppManagedEnvironmentData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppManagedEnvironmentData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppManagedEnvironmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppManagedEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerAppManagedEnvironmentData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(DaprAIInstrumentationKey))
            {
                writer.WritePropertyName("daprAIInstrumentationKey"u8);
                writer.WriteStringValue(DaprAIInstrumentationKey);
            }
            if (Optional.IsDefined(DaprAIConnectionString))
            {
                writer.WritePropertyName("daprAIConnectionString"u8);
                writer.WriteStringValue(DaprAIConnectionString);
            }
            if (Optional.IsDefined(VnetConfiguration))
            {
                writer.WritePropertyName("vnetConfiguration"u8);
                writer.WriteObjectValue(VnetConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentErrors))
            {
                writer.WritePropertyName("deploymentErrors"u8);
                writer.WriteStringValue(DeploymentErrors);
            }
            if (options.Format != "W" && Optional.IsDefined(DefaultDomain))
            {
                writer.WritePropertyName("defaultDomain"u8);
                writer.WriteStringValue(DefaultDomain);
            }
            if (options.Format != "W" && Optional.IsDefined(StaticIP))
            {
                writer.WritePropertyName("staticIp"u8);
                writer.WriteStringValue(StaticIP.ToString());
            }
            if (Optional.IsDefined(AppLogsConfiguration))
            {
                writer.WritePropertyName("appLogsConfiguration"u8);
                writer.WriteObjectValue(AppLogsConfiguration);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (Optional.IsDefined(CustomDomainConfiguration))
            {
                writer.WritePropertyName("customDomainConfiguration"u8);
                writer.WriteObjectValue(CustomDomainConfiguration);
            }
            if (options.Format != "W" && Optional.IsDefined(EventStreamEndpoint))
            {
                writer.WritePropertyName("eventStreamEndpoint"u8);
                writer.WriteStringValue(EventStreamEndpoint);
            }
            if (Optional.IsCollectionDefined(WorkloadProfiles))
            {
                writer.WritePropertyName("workloadProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in WorkloadProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KedaConfiguration))
            {
                writer.WritePropertyName("kedaConfiguration"u8);
                writer.WriteObjectValue(KedaConfiguration);
            }
            if (Optional.IsDefined(DaprConfiguration))
            {
                writer.WritePropertyName("daprConfiguration"u8);
                writer.WriteObjectValue(DaprConfiguration);
            }
            if (Optional.IsDefined(InfrastructureResourceGroup))
            {
                writer.WritePropertyName("infrastructureResourceGroup"u8);
                writer.WriteStringValue(InfrastructureResourceGroup);
            }
            if (Optional.IsDefined(PeerAuthentication))
            {
                writer.WritePropertyName("peerAuthentication"u8);
                writer.WriteObjectValue(PeerAuthentication);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        ContainerAppManagedEnvironmentData IJsonModel<ContainerAppManagedEnvironmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppManagedEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerAppManagedEnvironmentData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppManagedEnvironmentData(document.RootElement, options);
        }

        internal static ContainerAppManagedEnvironmentData DeserializeContainerAppManagedEnvironmentData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ContainerAppEnvironmentProvisioningState> provisioningState = default;
            Optional<string> daprAIInstrumentationKey = default;
            Optional<string> daprAIConnectionString = default;
            Optional<ContainerAppVnetConfiguration> vnetConfiguration = default;
            Optional<string> deploymentErrors = default;
            Optional<string> defaultDomain = default;
            Optional<IPAddress> staticIP = default;
            Optional<ContainerAppLogsConfiguration> appLogsConfiguration = default;
            Optional<bool> zoneRedundant = default;
            Optional<ContainerAppCustomDomainConfiguration> customDomainConfiguration = default;
            Optional<string> eventStreamEndpoint = default;
            Optional<IList<ContainerAppWorkloadProfile>> workloadProfiles = default;
            Optional<KedaConfiguration> kedaConfiguration = default;
            Optional<DaprConfiguration> daprConfiguration = default;
            Optional<string> infrastructureResourceGroup = default;
            Optional<ManagedEnvironmentPropertiesPeerAuthentication> peerAuthentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ContainerAppEnvironmentProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("daprAIInstrumentationKey"u8))
                        {
                            daprAIInstrumentationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("daprAIConnectionString"u8))
                        {
                            daprAIConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vnetConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vnetConfiguration = ContainerAppVnetConfiguration.DeserializeContainerAppVnetConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("deploymentErrors"u8))
                        {
                            deploymentErrors = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultDomain"u8))
                        {
                            defaultDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("staticIp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            staticIP = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appLogsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appLogsConfiguration = ContainerAppLogsConfiguration.DeserializeContainerAppLogsConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("zoneRedundant"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            zoneRedundant = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("customDomainConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomainConfiguration = ContainerAppCustomDomainConfiguration.DeserializeContainerAppCustomDomainConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("eventStreamEndpoint"u8))
                        {
                            eventStreamEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("workloadProfiles"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ContainerAppWorkloadProfile> array = new List<ContainerAppWorkloadProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerAppWorkloadProfile.DeserializeContainerAppWorkloadProfile(item));
                            }
                            workloadProfiles = array;
                            continue;
                        }
                        if (property0.NameEquals("kedaConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kedaConfiguration = KedaConfiguration.DeserializeKedaConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("daprConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            daprConfiguration = DaprConfiguration.DeserializeDaprConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("infrastructureResourceGroup"u8))
                        {
                            infrastructureResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("peerAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peerAuthentication = ManagedEnvironmentPropertiesPeerAuthentication.DeserializeManagedEnvironmentPropertiesPeerAuthentication(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppManagedEnvironmentData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, kind.Value, Optional.ToNullable(provisioningState), daprAIInstrumentationKey.Value, daprAIConnectionString.Value, vnetConfiguration.Value, deploymentErrors.Value, defaultDomain.Value, staticIP.Value, appLogsConfiguration.Value, Optional.ToNullable(zoneRedundant), customDomainConfiguration.Value, eventStreamEndpoint.Value, Optional.ToList(workloadProfiles), kedaConfiguration.Value, daprConfiguration.Value, infrastructureResourceGroup.Value, peerAuthentication.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppManagedEnvironmentData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppManagedEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerAppManagedEnvironmentData)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppManagedEnvironmentData IPersistableModel<ContainerAppManagedEnvironmentData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppManagedEnvironmentData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppManagedEnvironmentData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerAppManagedEnvironmentData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppManagedEnvironmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
