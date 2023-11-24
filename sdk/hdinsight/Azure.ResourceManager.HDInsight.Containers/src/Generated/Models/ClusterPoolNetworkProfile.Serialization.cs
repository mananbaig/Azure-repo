// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    internal partial class ClusterPoolNetworkProfile : IUtf8JsonSerializable, IJsonModel<ClusterPoolNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterPoolNetworkProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterPoolNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ClusterPoolNetworkProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
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

        ClusterPoolNetworkProfile IJsonModel<ClusterPoolNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ClusterPoolNetworkProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterPoolNetworkProfile(document.RootElement, options);
        }

        internal static ClusterPoolNetworkProfile DeserializeClusterPoolNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier subnetId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterPoolNetworkProfile(subnetId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterPoolNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ClusterPoolNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        ClusterPoolNetworkProfile IPersistableModel<ClusterPoolNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterPoolNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ClusterPoolNetworkProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterPoolNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
