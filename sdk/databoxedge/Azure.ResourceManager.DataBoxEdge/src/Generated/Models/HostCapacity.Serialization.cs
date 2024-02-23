// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class HostCapacity : IUtf8JsonSerializable, IJsonModel<HostCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HostCapacity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HostCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostCapacity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (HostName != null)
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (EffectiveAvailableMemoryInMBOnHost.HasValue)
            {
                writer.WritePropertyName("effectiveAvailableMemoryMbOnHost"u8);
                writer.WriteNumberValue(EffectiveAvailableMemoryInMBOnHost.Value);
            }
            if (AvailableGpuCount.HasValue)
            {
                writer.WritePropertyName("availableGpuCount"u8);
                writer.WriteNumberValue(AvailableGpuCount.Value);
            }
            if (!(VmUsedMemory is ChangeTrackingDictionary<string, DataBoxEdgeVmMemory> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("vmUsedMemory"u8);
                writer.WriteStartObject();
                foreach (var item in VmUsedMemory)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (GpuType != null)
            {
                writer.WritePropertyName("gpuType"u8);
                writer.WriteStringValue(GpuType);
            }
            if (!(NumaNodesData is ChangeTrackingList<NumaNodeInfo> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("numaNodesData"u8);
                writer.WriteStartArray();
                foreach (var item in NumaNodesData)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        HostCapacity IJsonModel<HostCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HostCapacity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHostCapacity(document.RootElement, options);
        }

        internal static HostCapacity DeserializeHostCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> hostName = default;
            Optional<long> effectiveAvailableMemoryMbOnHost = default;
            Optional<int> availableGpuCount = default;
            Optional<IDictionary<string, DataBoxEdgeVmMemory>> vmUsedMemory = default;
            Optional<string> gpuType = default;
            Optional<IList<NumaNodeInfo>> numaNodesData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveAvailableMemoryMbOnHost"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveAvailableMemoryMbOnHost = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("availableGpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    availableGpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vmUsedMemory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DataBoxEdgeVmMemory> dictionary = new Dictionary<string, DataBoxEdgeVmMemory>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DataBoxEdgeVmMemory.DeserializeDataBoxEdgeVmMemory(property0.Value, options));
                    }
                    vmUsedMemory = dictionary;
                    continue;
                }
                if (property.NameEquals("gpuType"u8))
                {
                    gpuType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numaNodesData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NumaNodeInfo> array = new List<NumaNodeInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NumaNodeInfo.DeserializeNumaNodeInfo(item, options));
                    }
                    numaNodesData = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HostCapacity(hostName.Value, Optional.ToNullable(effectiveAvailableMemoryMbOnHost), Optional.ToNullable(availableGpuCount), Optional.ToDictionary(vmUsedMemory), gpuType.Value, Optional.ToList(numaNodesData), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HostCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HostCapacity)} does not support '{options.Format}' format.");
            }
        }

        HostCapacity IPersistableModel<HostCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HostCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHostCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HostCapacity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HostCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
