// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Secrets))
            {
                writer.WritePropertyName("secrets"u8);
                writer.WriteStartArray();
                foreach (var item in Secrets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ActiveRevisionsMode))
            {
                writer.WritePropertyName("activeRevisionsMode"u8);
                writer.WriteStringValue(ActiveRevisionsMode.Value.ToString());
            }
            if (Optional.IsDefined(Ingress))
            {
                writer.WritePropertyName("ingress"u8);
                writer.WriteObjectValue(Ingress);
            }
            if (Optional.IsCollectionDefined(Registries))
            {
                writer.WritePropertyName("registries"u8);
                writer.WriteStartArray();
                foreach (var item in Registries)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Dapr))
            {
                writer.WritePropertyName("dapr"u8);
                writer.WriteObjectValue(Dapr);
            }
            if (Optional.IsDefined(MaxInactiveRevisions))
            {
                writer.WritePropertyName("maxInactiveRevisions"u8);
                writer.WriteNumberValue(MaxInactiveRevisions.Value);
            }
            if (Optional.IsDefined(Service))
            {
                writer.WritePropertyName("service"u8);
                writer.WriteObjectValue(Service);
            }
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

        ContainerAppConfiguration IJsonModel<ContainerAppConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppConfiguration(document.RootElement, options);
        }

        internal static ContainerAppConfiguration DeserializeContainerAppConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<ContainerAppWritableSecret> secrets = default;
            ContainerAppActiveRevisionsMode? activeRevisionsMode = default;
            ContainerAppIngressConfiguration ingress = default;
            IList<ContainerAppRegistryCredentials> registries = default;
            ContainerAppDaprConfiguration dapr = default;
            int? maxInactiveRevisions = default;
            Service service = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppWritableSecret> array = new List<ContainerAppWritableSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppWritableSecret.DeserializeContainerAppWritableSecret(item, options));
                    }
                    secrets = array;
                    continue;
                }
                if (property.NameEquals("activeRevisionsMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeRevisionsMode = new ContainerAppActiveRevisionsMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ingress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingress = ContainerAppIngressConfiguration.DeserializeContainerAppIngressConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("registries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppRegistryCredentials> array = new List<ContainerAppRegistryCredentials>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppRegistryCredentials.DeserializeContainerAppRegistryCredentials(item, options));
                    }
                    registries = array;
                    continue;
                }
                if (property.NameEquals("dapr"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dapr = ContainerAppDaprConfiguration.DeserializeContainerAppDaprConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("maxInactiveRevisions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxInactiveRevisions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("service"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    service = Service.DeserializeService(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppConfiguration(
                secrets ?? new ChangeTrackingList<ContainerAppWritableSecret>(),
                activeRevisionsMode,
                ingress,
                registries ?? new ChangeTrackingList<ContainerAppRegistryCredentials>(),
                dapr,
                maxInactiveRevisions,
                service,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppConfiguration IPersistableModel<ContainerAppConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
