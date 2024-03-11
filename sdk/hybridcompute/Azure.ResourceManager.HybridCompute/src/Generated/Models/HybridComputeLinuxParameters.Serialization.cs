// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeLinuxParameters : IUtf8JsonSerializable, IJsonModel<HybridComputeLinuxParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeLinuxParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputeLinuxParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeLinuxParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeLinuxParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ClassificationsToInclude))
            {
                writer.WritePropertyName("classificationsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ClassificationsToInclude)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PackageNameMasksToInclude))
            {
                writer.WritePropertyName("packageNameMasksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in PackageNameMasksToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PackageNameMasksToExclude))
            {
                writer.WritePropertyName("packageNameMasksToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in PackageNameMasksToExclude)
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
            writer.WriteEndObject();
        }

        HybridComputeLinuxParameters IJsonModel<HybridComputeLinuxParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeLinuxParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeLinuxParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeLinuxParameters(document.RootElement, options);
        }

        internal static HybridComputeLinuxParameters DeserializeHybridComputeLinuxParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<VmGuestPatchClassificationLinux> classificationsToInclude = default;
            IList<string> packageNameMasksToInclude = default;
            IList<string> packageNameMasksToExclude = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classificationsToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VmGuestPatchClassificationLinux> array = new List<VmGuestPatchClassificationLinux>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new VmGuestPatchClassificationLinux(item.GetString()));
                    }
                    classificationsToInclude = array;
                    continue;
                }
                if (property.NameEquals("packageNameMasksToInclude"u8))
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
                    packageNameMasksToInclude = array;
                    continue;
                }
                if (property.NameEquals("packageNameMasksToExclude"u8))
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
                    packageNameMasksToExclude = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridComputeLinuxParameters(classificationsToInclude ?? new ChangeTrackingList<VmGuestPatchClassificationLinux>(), packageNameMasksToInclude ?? new ChangeTrackingList<string>(), packageNameMasksToExclude ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridComputeLinuxParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeLinuxParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeLinuxParameters)} does not support '{options.Format}' format.");
            }
        }

        HybridComputeLinuxParameters IPersistableModel<HybridComputeLinuxParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeLinuxParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputeLinuxParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputeLinuxParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeLinuxParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
