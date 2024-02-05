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
    public partial class LongTermRetentionPolicy : IUtf8JsonSerializable, IJsonModel<LongTermRetentionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LongTermRetentionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LongTermRetentionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LongTermRetentionPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DailySchedule))
            {
                writer.WritePropertyName("dailySchedule"u8);
                writer.WriteObjectValue(DailySchedule);
            }
            if (Optional.IsDefined(WeeklySchedule))
            {
                writer.WritePropertyName("weeklySchedule"u8);
                writer.WriteObjectValue(WeeklySchedule);
            }
            if (Optional.IsDefined(MonthlySchedule))
            {
                writer.WritePropertyName("monthlySchedule"u8);
                writer.WriteObjectValue(MonthlySchedule);
            }
            if (Optional.IsDefined(YearlySchedule))
            {
                writer.WritePropertyName("yearlySchedule"u8);
                writer.WriteObjectValue(YearlySchedule);
            }
            writer.WritePropertyName("retentionPolicyType"u8);
            writer.WriteStringValue(RetentionPolicyType);
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

        LongTermRetentionPolicy IJsonModel<LongTermRetentionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LongTermRetentionPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLongTermRetentionPolicy(document.RootElement, options);
        }

        internal static LongTermRetentionPolicy DeserializeLongTermRetentionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DailyRetentionSchedule> dailySchedule = default;
            Optional<WeeklyRetentionSchedule> weeklySchedule = default;
            Optional<MonthlyRetentionSchedule> monthlySchedule = default;
            Optional<YearlyRetentionSchedule> yearlySchedule = default;
            string retentionPolicyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dailySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailySchedule = DailyRetentionSchedule.DeserializeDailyRetentionSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("weeklySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weeklySchedule = WeeklyRetentionSchedule.DeserializeWeeklyRetentionSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("monthlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlySchedule = MonthlyRetentionSchedule.DeserializeMonthlyRetentionSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("yearlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    yearlySchedule = YearlyRetentionSchedule.DeserializeYearlyRetentionSchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionPolicyType"u8))
                {
                    retentionPolicyType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LongTermRetentionPolicy(retentionPolicyType, serializedAdditionalRawData, dailySchedule.Value, weeklySchedule.Value, monthlySchedule.Value, yearlySchedule.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(DailySchedule))
            {
                builder.Append("  dailySchedule:");
                AppendChildObject(builder, DailySchedule, options, 2, false);
            }

            if (Optional.IsDefined(WeeklySchedule))
            {
                builder.Append("  weeklySchedule:");
                AppendChildObject(builder, WeeklySchedule, options, 2, false);
            }

            if (Optional.IsDefined(MonthlySchedule))
            {
                builder.Append("  monthlySchedule:");
                AppendChildObject(builder, MonthlySchedule, options, 2, false);
            }

            if (Optional.IsDefined(YearlySchedule))
            {
                builder.Append("  yearlySchedule:");
                AppendChildObject(builder, YearlySchedule, options, 2, false);
            }

            if (Optional.IsDefined(RetentionPolicyType))
            {
                builder.Append("  retentionPolicyType:");
                builder.AppendLine($" '{RetentionPolicyType}'");
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

        BinaryData IPersistableModel<LongTermRetentionPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(LongTermRetentionPolicy)} does not support '{options.Format}' format.");
            }
        }

        LongTermRetentionPolicy IPersistableModel<LongTermRetentionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LongTermRetentionPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLongTermRetentionPolicy(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(LongTermRetentionPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LongTermRetentionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
