// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SingleServerConfiguration : IUtf8JsonSerializable, IJsonModel<SingleServerConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingleServerConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SingleServerConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleServerConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration);
            }
            if (Optional.IsDefined(DatabaseType))
            {
                writer.WritePropertyName("databaseType"u8);
                writer.WriteStringValue(DatabaseType.Value.ToString());
            }
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            writer.WritePropertyName("virtualMachineConfiguration"u8);
            writer.WriteObjectValue(VirtualMachineConfiguration);
            if (Optional.IsDefined(DBDiskConfiguration))
            {
                writer.WritePropertyName("dbDiskConfiguration"u8);
                writer.WriteObjectValue(DBDiskConfiguration);
            }
            if (Optional.IsDefined(CustomResourceNames))
            {
                writer.WritePropertyName("customResourceNames"u8);
                writer.WriteObjectValue(CustomResourceNames);
            }
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("appResourceGroup"u8);
            writer.WriteStringValue(AppResourceGroup);
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

        SingleServerConfiguration IJsonModel<SingleServerConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingleServerConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingleServerConfiguration(document.RootElement, options);
        }

        internal static SingleServerConfiguration DeserializeSingleServerConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkConfiguration> networkConfiguration = default;
            Optional<SapDatabaseType> databaseType = default;
            ResourceIdentifier subnetId = default;
            SapVirtualMachineConfiguration virtualMachineConfiguration = default;
            Optional<DiskConfiguration> dbDiskConfiguration = default;
            Optional<SingleServerCustomResourceNames> customResourceNames = default;
            SapDeploymentType deploymentType = default;
            string appResourceGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = NetworkConfiguration.DeserializeNetworkConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("databaseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseType = new SapDatabaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"u8))
                {
                    virtualMachineConfiguration = SapVirtualMachineConfiguration.DeserializeSapVirtualMachineConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dbDiskConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbDiskConfiguration = DiskConfiguration.DeserializeDiskConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("customResourceNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customResourceNames = SingleServerCustomResourceNames.DeserializeSingleServerCustomResourceNames(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceGroup"u8))
                {
                    appResourceGroup = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SingleServerConfiguration(deploymentType, appResourceGroup, serializedAdditionalRawData, networkConfiguration.Value, Optional.ToNullable(databaseType), subnetId, virtualMachineConfiguration, dbDiskConfiguration.Value, customResourceNames.Value);
        }

        BinaryData IPersistableModel<SingleServerConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SingleServerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        SingleServerConfiguration IPersistableModel<SingleServerConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingleServerConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSingleServerConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SingleServerConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingleServerConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
