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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageBasePolicyDetails : IUtf8JsonSerializable, IJsonModel<InMageBasePolicyDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageBasePolicyDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageBasePolicyDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageBasePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageBasePolicyDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointThresholdInMinutes))
            {
                writer.WritePropertyName("recoveryPointThresholdInMinutes"u8);
                writer.WriteNumberValue(RecoveryPointThresholdInMinutes.Value);
            }
            if (Optional.IsDefined(RecoveryPointHistory))
            {
                writer.WritePropertyName("recoveryPointHistory"u8);
                writer.WriteNumberValue(RecoveryPointHistory.Value);
            }
            if (Optional.IsDefined(AppConsistentFrequencyInMinutes))
            {
                writer.WritePropertyName("appConsistentFrequencyInMinutes"u8);
                writer.WriteNumberValue(AppConsistentFrequencyInMinutes.Value);
            }
            if (Optional.IsDefined(MultiVmSyncStatus))
            {
                writer.WritePropertyName("multiVmSyncStatus"u8);
                writer.WriteStringValue(MultiVmSyncStatus);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        InMageBasePolicyDetails IJsonModel<InMageBasePolicyDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageBasePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageBasePolicyDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageBasePolicyDetails(document.RootElement, options);
        }

        internal static InMageBasePolicyDetails DeserializeInMageBasePolicyDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> recoveryPointThresholdInMinutes = default;
            Optional<int> recoveryPointHistory = default;
            Optional<int> appConsistentFrequencyInMinutes = default;
            Optional<string> multiVmSyncStatus = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointThresholdInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointThresholdInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recoveryPointHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointHistory = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("appConsistentFrequencyInMinutes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appConsistentFrequencyInMinutes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("multiVmSyncStatus"u8))
                {
                    multiVmSyncStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageBasePolicyDetails(instanceType, serializedAdditionalRawData, Optional.ToNullable(recoveryPointThresholdInMinutes), Optional.ToNullable(recoveryPointHistory), Optional.ToNullable(appConsistentFrequencyInMinutes), multiVmSyncStatus.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RecoveryPointThresholdInMinutes))
            {
                builder.Append("  recoveryPointThresholdInMinutes:");
                builder.AppendLine($" {RecoveryPointThresholdInMinutes.Value}");
            }

            if (Optional.IsDefined(RecoveryPointHistory))
            {
                builder.Append("  recoveryPointHistory:");
                builder.AppendLine($" {RecoveryPointHistory.Value}");
            }

            if (Optional.IsDefined(AppConsistentFrequencyInMinutes))
            {
                builder.Append("  appConsistentFrequencyInMinutes:");
                builder.AppendLine($" {AppConsistentFrequencyInMinutes.Value}");
            }

            if (Optional.IsDefined(MultiVmSyncStatus))
            {
                builder.Append("  multiVmSyncStatus:");
                builder.AppendLine($" '{MultiVmSyncStatus}'");
            }

            if (Optional.IsDefined(InstanceType))
            {
                builder.Append("  instanceType:");
                builder.AppendLine($" '{InstanceType}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<InMageBasePolicyDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageBasePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InMageBasePolicyDetails)} does not support '{options.Format}' format.");
            }
        }

        InMageBasePolicyDetails IPersistableModel<InMageBasePolicyDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageBasePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageBasePolicyDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(InMageBasePolicyDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageBasePolicyDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
