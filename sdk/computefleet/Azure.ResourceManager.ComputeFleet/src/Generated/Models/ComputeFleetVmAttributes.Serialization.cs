// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    public partial class ComputeFleetVmAttributes : IUtf8JsonSerializable, IJsonModel<ComputeFleetVmAttributes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeFleetVmAttributes>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeFleetVmAttributes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetVmAttributes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetVmAttributes)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("vCpuCount"u8);
            writer.WriteObjectValue(VCpuCount, options);
            writer.WritePropertyName("memoryInGiB"u8);
            writer.WriteObjectValue(MemoryInGiB, options);
            if (Optional.IsDefined(MemoryInGiBPerVCpu))
            {
                writer.WritePropertyName("memoryInGiBPerVCpu"u8);
                writer.WriteObjectValue(MemoryInGiBPerVCpu, options);
            }
            if (Optional.IsDefined(LocalStorageSupport))
            {
                writer.WritePropertyName("localStorageSupport"u8);
                writer.WriteStringValue(LocalStorageSupport.Value.ToString());
            }
            if (Optional.IsDefined(LocalStorageInGiB))
            {
                writer.WritePropertyName("localStorageInGiB"u8);
                writer.WriteObjectValue(LocalStorageInGiB, options);
            }
            if (Optional.IsCollectionDefined(LocalStorageDiskTypes))
            {
                writer.WritePropertyName("localStorageDiskTypes"u8);
                writer.WriteStartArray();
                foreach (var item in LocalStorageDiskTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DataDiskCount))
            {
                writer.WritePropertyName("dataDiskCount"u8);
                writer.WriteObjectValue(DataDiskCount, options);
            }
            if (Optional.IsDefined(NetworkInterfaceCount))
            {
                writer.WritePropertyName("networkInterfaceCount"u8);
                writer.WriteObjectValue(NetworkInterfaceCount, options);
            }
            if (Optional.IsDefined(NetworkBandwidthInMbps))
            {
                writer.WritePropertyName("networkBandwidthInMbps"u8);
                writer.WriteObjectValue(NetworkBandwidthInMbps, options);
            }
            if (Optional.IsDefined(RdmaSupport))
            {
                writer.WritePropertyName("rdmaSupport"u8);
                writer.WriteStringValue(RdmaSupport.Value.ToString());
            }
            if (Optional.IsDefined(RdmaNetworkInterfaceCount))
            {
                writer.WritePropertyName("rdmaNetworkInterfaceCount"u8);
                writer.WriteObjectValue(RdmaNetworkInterfaceCount, options);
            }
            if (Optional.IsDefined(AcceleratorSupport))
            {
                writer.WritePropertyName("acceleratorSupport"u8);
                writer.WriteStringValue(AcceleratorSupport.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AcceleratorManufacturers))
            {
                writer.WritePropertyName("acceleratorManufacturers"u8);
                writer.WriteStartArray();
                foreach (var item in AcceleratorManufacturers)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AcceleratorTypes))
            {
                writer.WritePropertyName("acceleratorTypes"u8);
                writer.WriteStartArray();
                foreach (var item in AcceleratorTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AcceleratorCount))
            {
                writer.WritePropertyName("acceleratorCount"u8);
                writer.WriteObjectValue(AcceleratorCount, options);
            }
            if (Optional.IsCollectionDefined(VmCategories))
            {
                writer.WritePropertyName("vmCategories"u8);
                writer.WriteStartArray();
                foreach (var item in VmCategories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ArchitectureTypes))
            {
                writer.WritePropertyName("architectureTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ArchitectureTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CpuManufacturers))
            {
                writer.WritePropertyName("cpuManufacturers"u8);
                writer.WriteStartArray();
                foreach (var item in CpuManufacturers)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BurstableSupport))
            {
                writer.WritePropertyName("burstableSupport"u8);
                writer.WriteStringValue(BurstableSupport.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExcludedVmSizes))
            {
                writer.WritePropertyName("excludedVMSizes"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedVmSizes)
                {
                    writer.WriteStringValue(item);
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
        }

        ComputeFleetVmAttributes IJsonModel<ComputeFleetVmAttributes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetVmAttributes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetVmAttributes)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeFleetVmAttributes(document.RootElement, options);
        }

        internal static ComputeFleetVmAttributes DeserializeComputeFleetVmAttributes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputeFleetVmAttributeMinMaxInteger vCpuCount = default;
            ComputeFleetVmAttributeMinMaxDouble memoryInGiB = default;
            ComputeFleetVmAttributeMinMaxDouble memoryInGiBPerVCpu = default;
            ComputeFleetVmAttributeSupport? localStorageSupport = default;
            ComputeFleetVmAttributeMinMaxDouble localStorageInGiB = default;
            IList<LocalStorageDiskType> localStorageDiskTypes = default;
            ComputeFleetVmAttributeMinMaxInteger dataDiskCount = default;
            ComputeFleetVmAttributeMinMaxInteger networkInterfaceCount = default;
            ComputeFleetVmAttributeMinMaxDouble networkBandwidthInMbps = default;
            ComputeFleetVmAttributeSupport? rdmaSupport = default;
            ComputeFleetVmAttributeMinMaxInteger rdmaNetworkInterfaceCount = default;
            ComputeFleetVmAttributeSupport? acceleratorSupport = default;
            IList<AcceleratorManufacturer> acceleratorManufacturers = default;
            IList<AcceleratorType> acceleratorTypes = default;
            ComputeFleetVmAttributeMinMaxInteger acceleratorCount = default;
            IList<ComputeFleetVmCategory> vmCategories = default;
            IList<ArchitectureType> architectureTypes = default;
            IList<CpuManufacturer> cpuManufacturers = default;
            ComputeFleetVmAttributeSupport? burstableSupport = default;
            IList<string> excludedVmSizes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vCpuCount"u8))
                {
                    vCpuCount = ComputeFleetVmAttributeMinMaxInteger.DeserializeComputeFleetVmAttributeMinMaxInteger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("memoryInGiB"u8))
                {
                    memoryInGiB = ComputeFleetVmAttributeMinMaxDouble.DeserializeComputeFleetVmAttributeMinMaxDouble(property.Value, options);
                    continue;
                }
                if (property.NameEquals("memoryInGiBPerVCpu"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInGiBPerVCpu = ComputeFleetVmAttributeMinMaxDouble.DeserializeComputeFleetVmAttributeMinMaxDouble(property.Value, options);
                    continue;
                }
                if (property.NameEquals("localStorageSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localStorageSupport = new ComputeFleetVmAttributeSupport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("localStorageInGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    localStorageInGiB = ComputeFleetVmAttributeMinMaxDouble.DeserializeComputeFleetVmAttributeMinMaxDouble(property.Value, options);
                    continue;
                }
                if (property.NameEquals("localStorageDiskTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LocalStorageDiskType> array = new List<LocalStorageDiskType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new LocalStorageDiskType(item.GetString()));
                    }
                    localStorageDiskTypes = array;
                    continue;
                }
                if (property.NameEquals("dataDiskCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataDiskCount = ComputeFleetVmAttributeMinMaxInteger.DeserializeComputeFleetVmAttributeMinMaxInteger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkInterfaceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkInterfaceCount = ComputeFleetVmAttributeMinMaxInteger.DeserializeComputeFleetVmAttributeMinMaxInteger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkBandwidthInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkBandwidthInMbps = ComputeFleetVmAttributeMinMaxDouble.DeserializeComputeFleetVmAttributeMinMaxDouble(property.Value, options);
                    continue;
                }
                if (property.NameEquals("rdmaSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rdmaSupport = new ComputeFleetVmAttributeSupport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rdmaNetworkInterfaceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rdmaNetworkInterfaceCount = ComputeFleetVmAttributeMinMaxInteger.DeserializeComputeFleetVmAttributeMinMaxInteger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("acceleratorSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceleratorSupport = new ComputeFleetVmAttributeSupport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("acceleratorManufacturers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcceleratorManufacturer> array = new List<AcceleratorManufacturer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AcceleratorManufacturer(item.GetString()));
                    }
                    acceleratorManufacturers = array;
                    continue;
                }
                if (property.NameEquals("acceleratorTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcceleratorType> array = new List<AcceleratorType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AcceleratorType(item.GetString()));
                    }
                    acceleratorTypes = array;
                    continue;
                }
                if (property.NameEquals("acceleratorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceleratorCount = ComputeFleetVmAttributeMinMaxInteger.DeserializeComputeFleetVmAttributeMinMaxInteger(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vmCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeFleetVmCategory> array = new List<ComputeFleetVmCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ComputeFleetVmCategory(item.GetString()));
                    }
                    vmCategories = array;
                    continue;
                }
                if (property.NameEquals("architectureTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ArchitectureType> array = new List<ArchitectureType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ArchitectureType(item.GetString()));
                    }
                    architectureTypes = array;
                    continue;
                }
                if (property.NameEquals("cpuManufacturers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CpuManufacturer> array = new List<CpuManufacturer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CpuManufacturer(item.GetString()));
                    }
                    cpuManufacturers = array;
                    continue;
                }
                if (property.NameEquals("burstableSupport"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    burstableSupport = new ComputeFleetVmAttributeSupport(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("excludedVMSizes"u8))
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
                    excludedVmSizes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeFleetVmAttributes(
                vCpuCount,
                memoryInGiB,
                memoryInGiBPerVCpu,
                localStorageSupport,
                localStorageInGiB,
                localStorageDiskTypes ?? new ChangeTrackingList<LocalStorageDiskType>(),
                dataDiskCount,
                networkInterfaceCount,
                networkBandwidthInMbps,
                rdmaSupport,
                rdmaNetworkInterfaceCount,
                acceleratorSupport,
                acceleratorManufacturers ?? new ChangeTrackingList<AcceleratorManufacturer>(),
                acceleratorTypes ?? new ChangeTrackingList<AcceleratorType>(),
                acceleratorCount,
                vmCategories ?? new ChangeTrackingList<ComputeFleetVmCategory>(),
                architectureTypes ?? new ChangeTrackingList<ArchitectureType>(),
                cpuManufacturers ?? new ChangeTrackingList<CpuManufacturer>(),
                burstableSupport,
                excludedVmSizes ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeFleetVmAttributes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetVmAttributes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetVmAttributes)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeFleetVmAttributes IPersistableModel<ComputeFleetVmAttributes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetVmAttributes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeFleetVmAttributes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetVmAttributes)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeFleetVmAttributes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
