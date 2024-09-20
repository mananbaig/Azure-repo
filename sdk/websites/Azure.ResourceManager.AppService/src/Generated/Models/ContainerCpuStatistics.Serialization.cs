// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ContainerCpuStatistics : IUtf8JsonSerializable, IJsonModel<ContainerCpuStatistics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerCpuStatistics>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerCpuStatistics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCpuStatistics)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CpuUsage))
            {
                writer.WritePropertyName("cpuUsage"u8);
                writer.WriteObjectValue(CpuUsage, options);
            }
            if (Optional.IsDefined(SystemCpuUsage))
            {
                writer.WritePropertyName("systemCpuUsage"u8);
                writer.WriteNumberValue(SystemCpuUsage.Value);
            }
            if (Optional.IsDefined(OnlineCpuCount))
            {
                writer.WritePropertyName("onlineCpuCount"u8);
                writer.WriteNumberValue(OnlineCpuCount.Value);
            }
            if (Optional.IsDefined(ThrottlingData))
            {
                writer.WritePropertyName("throttlingData"u8);
                writer.WriteObjectValue(ThrottlingData, options);
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

        ContainerCpuStatistics IJsonModel<ContainerCpuStatistics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuStatistics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerCpuStatistics)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerCpuStatistics(document.RootElement, options);
        }

        internal static ContainerCpuStatistics DeserializeContainerCpuStatistics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerCpuUsage cpuUsage = default;
            long? systemCpuUsage = default;
            int? onlineCpuCount = default;
            ContainerThrottlingInfo throttlingData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cpuUsage = ContainerCpuUsage.DeserializeContainerCpuUsage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("systemCpuUsage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemCpuUsage = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("onlineCpuCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onlineCpuCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("throttlingData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throttlingData = ContainerThrottlingInfo.DeserializeContainerThrottlingInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerCpuStatistics(cpuUsage, systemCpuUsage, onlineCpuCount, throttlingData, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CpuUsage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  cpuUsage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CpuUsage))
                {
                    builder.Append("  cpuUsage: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CpuUsage, options, 2, false, "  cpuUsage: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemCpuUsage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemCpuUsage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemCpuUsage))
                {
                    builder.Append("  systemCpuUsage: ");
                    builder.AppendLine($"'{SystemCpuUsage.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OnlineCpuCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  onlineCpuCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OnlineCpuCount))
                {
                    builder.Append("  onlineCpuCount: ");
                    builder.AppendLine($"{OnlineCpuCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThrottlingData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  throttlingData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ThrottlingData))
                {
                    builder.Append("  throttlingData: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ThrottlingData, options, 2, false, "  throttlingData: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerCpuStatistics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerCpuStatistics)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerCpuStatistics IPersistableModel<ContainerCpuStatistics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerCpuStatistics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerCpuStatistics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerCpuStatistics)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerCpuStatistics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
