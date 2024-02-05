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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmWorkloadProtectedItemExtendedInfo : IUtf8JsonSerializable, IJsonModel<VmWorkloadProtectedItemExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmWorkloadProtectedItemExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmWorkloadProtectedItemExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmWorkloadProtectedItemExtendedInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OldestRecoverOn))
            {
                writer.WritePropertyName("oldestRecoveryPoint"u8);
                writer.WriteStringValue(OldestRecoverOn.Value, "O");
            }
            if (Optional.IsDefined(OldestRecoveryPointInVault))
            {
                writer.WritePropertyName("oldestRecoveryPointInVault"u8);
                writer.WriteStringValue(OldestRecoveryPointInVault.Value, "O");
            }
            if (Optional.IsDefined(OldestRecoveryPointInArchive))
            {
                writer.WritePropertyName("oldestRecoveryPointInArchive"u8);
                writer.WriteStringValue(OldestRecoveryPointInArchive.Value, "O");
            }
            if (Optional.IsDefined(NewestRecoveryPointInArchive))
            {
                writer.WritePropertyName("newestRecoveryPointInArchive"u8);
                writer.WriteStringValue(NewestRecoveryPointInArchive.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointCount))
            {
                writer.WritePropertyName("recoveryPointCount"u8);
                writer.WriteNumberValue(RecoveryPointCount.Value);
            }
            if (Optional.IsDefined(PolicyState))
            {
                writer.WritePropertyName("policyState"u8);
                writer.WriteStringValue(PolicyState);
            }
            if (Optional.IsDefined(RecoveryModel))
            {
                writer.WritePropertyName("recoveryModel"u8);
                writer.WriteStringValue(RecoveryModel);
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

        VmWorkloadProtectedItemExtendedInfo IJsonModel<VmWorkloadProtectedItemExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmWorkloadProtectedItemExtendedInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadProtectedItemExtendedInfo(document.RootElement, options);
        }

        internal static VmWorkloadProtectedItemExtendedInfo DeserializeVmWorkloadProtectedItemExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> oldestRecoveryPoint = default;
            Optional<DateTimeOffset> oldestRecoveryPointInVault = default;
            Optional<DateTimeOffset> oldestRecoveryPointInArchive = default;
            Optional<DateTimeOffset> newestRecoveryPointInArchive = default;
            Optional<int> recoveryPointCount = default;
            Optional<string> policyState = default;
            Optional<string> recoveryModel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oldestRecoveryPoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPoint = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("oldestRecoveryPointInVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPointInVault = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("oldestRecoveryPointInArchive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oldestRecoveryPointInArchive = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("newestRecoveryPointInArchive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    newestRecoveryPointInArchive = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyState"u8))
                {
                    policyState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryModel"u8))
                {
                    recoveryModel = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmWorkloadProtectedItemExtendedInfo(Optional.ToNullable(oldestRecoveryPoint), Optional.ToNullable(oldestRecoveryPointInVault), Optional.ToNullable(oldestRecoveryPointInArchive), Optional.ToNullable(newestRecoveryPointInArchive), Optional.ToNullable(recoveryPointCount), policyState.Value, recoveryModel.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(OldestRecoverOn))
            {
                builder.Append("  oldestRecoveryPoint:");
                var formattedDateTimeString = TypeFormatters.ToString(OldestRecoverOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(OldestRecoveryPointInVault))
            {
                builder.Append("  oldestRecoveryPointInVault:");
                var formattedDateTimeString = TypeFormatters.ToString(OldestRecoveryPointInVault.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(OldestRecoveryPointInArchive))
            {
                builder.Append("  oldestRecoveryPointInArchive:");
                var formattedDateTimeString = TypeFormatters.ToString(OldestRecoveryPointInArchive.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(NewestRecoveryPointInArchive))
            {
                builder.Append("  newestRecoveryPointInArchive:");
                var formattedDateTimeString = TypeFormatters.ToString(NewestRecoveryPointInArchive.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(RecoveryPointCount))
            {
                builder.Append("  recoveryPointCount:");
                builder.AppendLine($" {RecoveryPointCount.Value}");
            }

            if (Optional.IsDefined(PolicyState))
            {
                builder.Append("  policyState:");
                builder.AppendLine($" '{PolicyState}'");
            }

            if (Optional.IsDefined(RecoveryModel))
            {
                builder.Append("  recoveryModel:");
                builder.AppendLine($" '{RecoveryModel}'");
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

        BinaryData IPersistableModel<VmWorkloadProtectedItemExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VmWorkloadProtectedItemExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        VmWorkloadProtectedItemExtendedInfo IPersistableModel<VmWorkloadProtectedItemExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmWorkloadProtectedItemExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmWorkloadProtectedItemExtendedInfo(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VmWorkloadProtectedItemExtendedInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmWorkloadProtectedItemExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
