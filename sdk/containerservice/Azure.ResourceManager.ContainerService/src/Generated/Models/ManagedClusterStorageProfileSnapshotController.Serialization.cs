// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerService;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterStorageProfileSnapshotController : IUtf8JsonSerializable, IJsonModel<ManagedClusterStorageProfileSnapshotController>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterStorageProfileSnapshotController>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterStorageProfileSnapshotController>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterStorageProfileSnapshotController>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterStorageProfileSnapshotController)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
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

        ManagedClusterStorageProfileSnapshotController IJsonModel<ManagedClusterStorageProfileSnapshotController>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterStorageProfileSnapshotController>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterStorageProfileSnapshotController)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterStorageProfileSnapshotController(document.RootElement, options);
        }

        internal static ManagedClusterStorageProfileSnapshotController DeserializeManagedClusterStorageProfileSnapshotController(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterStorageProfileSnapshotController(enabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterStorageProfileSnapshotController>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterStorageProfileSnapshotController>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterStorageProfileSnapshotController)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterStorageProfileSnapshotController IPersistableModel<ManagedClusterStorageProfileSnapshotController>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterStorageProfileSnapshotController>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterStorageProfileSnapshotController(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterStorageProfileSnapshotController)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterStorageProfileSnapshotController>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
