// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ManagedClusterUpgradeDeltaHealthPolicy : IUtf8JsonSerializable, IJsonModel<ManagedClusterUpgradeDeltaHealthPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterUpgradeDeltaHealthPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterUpgradeDeltaHealthPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterUpgradeDeltaHealthPolicy)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("maxPercentDeltaUnhealthyNodes"u8);
            writer.WriteNumberValue(MaxPercentDeltaUnhealthyNodes);
            if (Optional.IsDefined(MaxPercentUpgradeDomainDeltaUnhealthyNodes))
            {
                writer.WritePropertyName("maxPercentUpgradeDomainDeltaUnhealthyNodes"u8);
                writer.WriteNumberValue(MaxPercentUpgradeDomainDeltaUnhealthyNodes.Value);
            }
            if (Optional.IsDefined(MaxPercentDeltaUnhealthyApplications))
            {
                writer.WritePropertyName("maxPercentDeltaUnhealthyApplications"u8);
                writer.WriteNumberValue(MaxPercentDeltaUnhealthyApplications.Value);
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

        ManagedClusterUpgradeDeltaHealthPolicy IJsonModel<ManagedClusterUpgradeDeltaHealthPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterUpgradeDeltaHealthPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterUpgradeDeltaHealthPolicy(document.RootElement, options);
        }

        internal static ManagedClusterUpgradeDeltaHealthPolicy DeserializeManagedClusterUpgradeDeltaHealthPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int maxPercentDeltaUnhealthyNodes = default;
            int? maxPercentUpgradeDomainDeltaUnhealthyNodes = default;
            int? maxPercentDeltaUnhealthyApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxPercentDeltaUnhealthyNodes"u8))
                {
                    maxPercentDeltaUnhealthyNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentUpgradeDomainDeltaUnhealthyNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentUpgradeDomainDeltaUnhealthyNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPercentDeltaUnhealthyApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxPercentDeltaUnhealthyApplications = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterUpgradeDeltaHealthPolicy(maxPercentDeltaUnhealthyNodes, maxPercentUpgradeDomainDeltaUnhealthyNodes, maxPercentDeltaUnhealthyApplications, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterUpgradeDeltaHealthPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterUpgradeDeltaHealthPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterUpgradeDeltaHealthPolicy IPersistableModel<ManagedClusterUpgradeDeltaHealthPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterUpgradeDeltaHealthPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterUpgradeDeltaHealthPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterUpgradeDeltaHealthPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterUpgradeDeltaHealthPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
