// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class YearlyRetentionSchedule : IUtf8JsonSerializable, IJsonModel<YearlyRetentionSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<YearlyRetentionSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<YearlyRetentionSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<YearlyRetentionSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(YearlyRetentionSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RetentionScheduleFormatType))
            {
                writer.WritePropertyName("retentionScheduleFormatType"u8);
                writer.WriteStringValue(RetentionScheduleFormatType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(MonthsOfYear))
            {
                writer.WritePropertyName("monthsOfYear"u8);
                writer.WriteStartArray();
                foreach (var item in MonthsOfYear)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RetentionScheduleDaily))
            {
                writer.WritePropertyName("retentionScheduleDaily"u8);
                writer.WriteObjectValue(RetentionScheduleDaily);
            }
            if (Optional.IsDefined(RetentionScheduleWeekly))
            {
                writer.WritePropertyName("retentionScheduleWeekly"u8);
                writer.WriteObjectValue(RetentionScheduleWeekly);
            }
            if (Optional.IsCollectionDefined(RetentionTimes))
            {
                writer.WritePropertyName("retentionTimes"u8);
                writer.WriteStartArray();
                foreach (var item in RetentionTimes)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RetentionDuration))
            {
                writer.WritePropertyName("retentionDuration"u8);
                writer.WriteObjectValue(RetentionDuration);
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

        YearlyRetentionSchedule IJsonModel<YearlyRetentionSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<YearlyRetentionSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(YearlyRetentionSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeYearlyRetentionSchedule(document.RootElement, options);
        }

        internal static YearlyRetentionSchedule DeserializeYearlyRetentionSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RetentionScheduleFormat> retentionScheduleFormatType = default;
            Optional<IList<BackupMonthOfYear>> monthsOfYear = default;
            Optional<DailyRetentionFormat> retentionScheduleDaily = default;
            Optional<WeeklyRetentionFormat> retentionScheduleWeekly = default;
            Optional<IList<DateTimeOffset>> retentionTimes = default;
            Optional<RetentionDuration> retentionDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionScheduleFormatType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleFormatType = new RetentionScheduleFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monthsOfYear"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupMonthOfYear> array = new List<BackupMonthOfYear>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBackupMonthOfYear());
                    }
                    monthsOfYear = array;
                    continue;
                }
                if (property.NameEquals("retentionScheduleDaily"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleDaily = DailyRetentionFormat.DeserializeDailyRetentionFormat(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionScheduleWeekly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleWeekly = WeeklyRetentionFormat.DeserializeWeeklyRetentionFormat(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionTimes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    retentionTimes = array;
                    continue;
                }
                if (property.NameEquals("retentionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionDuration = RetentionDuration.DeserializeRetentionDuration(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new YearlyRetentionSchedule(Optional.ToNullable(retentionScheduleFormatType), Optional.ToList(monthsOfYear), retentionScheduleDaily.Value, retentionScheduleWeekly.Value, Optional.ToList(retentionTimes), retentionDuration.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RetentionScheduleFormatType))
            {
                builder.Append("  retentionScheduleFormatType:");
                builder.AppendLine($" '{RetentionScheduleFormatType.ToString()}'");
            }

            if (Optional.IsCollectionDefined(MonthsOfYear))
            {
                if (MonthsOfYear.Any())
                {
                    builder.Append("  monthsOfYear:");
                    builder.AppendLine(" [");
                    foreach (var item in MonthsOfYear)
                    {
                        builder.AppendLine($"    '{item.ToString()}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(RetentionScheduleDaily))
            {
                builder.Append("  retentionScheduleDaily:");
                AppendChildObject(builder, RetentionScheduleDaily, options, 2, false);
            }

            if (Optional.IsDefined(RetentionScheduleWeekly))
            {
                builder.Append("  retentionScheduleWeekly:");
                AppendChildObject(builder, RetentionScheduleWeekly, options, 2, false);
            }

            if (Optional.IsCollectionDefined(RetentionTimes))
            {
                if (RetentionTimes.Any())
                {
                    builder.Append("  retentionTimes:");
                    builder.AppendLine(" [");
                    foreach (var item in RetentionTimes)
                    {
                        var formattedDateTimeString = TypeFormatters.ToString(item, "o");
                        builder.AppendLine($"    '{formattedDateTimeString}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(RetentionDuration))
            {
                builder.Append("  retentionDuration:");
                AppendChildObject(builder, RetentionDuration, options, 2, false);
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

        BinaryData IPersistableModel<YearlyRetentionSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<YearlyRetentionSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(YearlyRetentionSchedule)} does not support '{options.Format}' format.");
            }
        }

        YearlyRetentionSchedule IPersistableModel<YearlyRetentionSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<YearlyRetentionSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeYearlyRetentionSchedule(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(YearlyRetentionSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<YearlyRetentionSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
