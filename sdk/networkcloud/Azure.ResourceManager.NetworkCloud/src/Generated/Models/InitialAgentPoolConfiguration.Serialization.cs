// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class InitialAgentPoolConfiguration : IUtf8JsonSerializable, IJsonModel<InitialAgentPoolConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InitialAgentPoolConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InitialAgentPoolConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitialAgentPoolConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InitialAgentPoolConfiguration)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorConfiguration))
            {
                writer.WritePropertyName("administratorConfiguration"u8);
                writer.WriteObjectValue(AdministratorConfiguration, options);
            }
            if (Optional.IsDefined(AgentOptions))
            {
                writer.WritePropertyName("agentOptions"u8);
                writer.WriteObjectValue(AgentOptions, options);
            }
            if (Optional.IsDefined(AttachedNetworkConfiguration))
            {
                writer.WritePropertyName("attachedNetworkConfiguration"u8);
                writer.WriteObjectValue(AttachedNetworkConfiguration, options);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones"u8);
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(Taints))
            {
                writer.WritePropertyName("taints"u8);
                writer.WriteStartArray();
                foreach (var item in Taints)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings"u8);
                writer.WriteObjectValue(UpgradeSettings, options);
            }
            writer.WritePropertyName("vmSkuName"u8);
            writer.WriteStringValue(VmSkuName);
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

        InitialAgentPoolConfiguration IJsonModel<InitialAgentPoolConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitialAgentPoolConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InitialAgentPoolConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInitialAgentPoolConfiguration(document.RootElement, options);
        }

        internal static InitialAgentPoolConfiguration DeserializeInitialAgentPoolConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AdministratorConfiguration administratorConfiguration = default;
            NetworkCloudAgentConfiguration agentOptions = default;
            AttachedNetworkConfiguration attachedNetworkConfiguration = default;
            IList<string> availabilityZones = default;
            long count = default;
            IList<KubernetesLabel> labels = default;
            NetworkCloudAgentPoolMode mode = default;
            string name = default;
            IList<KubernetesLabel> taints = default;
            AgentPoolUpgradeSettings upgradeSettings = default;
            string vmSkuName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("administratorConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administratorConfiguration = AdministratorConfiguration.DeserializeAdministratorConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("agentOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agentOptions = NetworkCloudAgentConfiguration.DeserializeNetworkCloudAgentConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("attachedNetworkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    attachedNetworkConfiguration = AttachedNetworkConfiguration.DeserializeAttachedNetworkConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("availabilityZones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("labels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesLabel> array = new List<KubernetesLabel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesLabel.DeserializeKubernetesLabel(item, options));
                    }
                    labels = array;
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = new NetworkCloudAgentPoolMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesLabel> array = new List<KubernetesLabel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesLabel.DeserializeKubernetesLabel(item, options));
                    }
                    taints = array;
                    continue;
                }
                if (property.NameEquals("upgradeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vmSkuName"u8))
                {
                    vmSkuName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InitialAgentPoolConfiguration(
                administratorConfiguration,
                agentOptions,
                attachedNetworkConfiguration,
                availabilityZones ?? new ChangeTrackingList<string>(),
                count,
                labels ?? new ChangeTrackingList<KubernetesLabel>(),
                mode,
                name,
                taints ?? new ChangeTrackingList<KubernetesLabel>(),
                upgradeSettings,
                vmSkuName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InitialAgentPoolConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitialAgentPoolConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InitialAgentPoolConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        InitialAgentPoolConfiguration IPersistableModel<InitialAgentPoolConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InitialAgentPoolConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInitialAgentPoolConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InitialAgentPoolConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InitialAgentPoolConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
