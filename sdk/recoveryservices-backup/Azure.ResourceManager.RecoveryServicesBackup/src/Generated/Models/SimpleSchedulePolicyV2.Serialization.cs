// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class SimpleSchedulePolicyV2 : IUtf8JsonSerializable, IJsonModel<SimpleSchedulePolicyV2>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SimpleSchedulePolicyV2>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SimpleSchedulePolicyV2>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleRunFrequency))
            {
                writer.WritePropertyName("scheduleRunFrequency"u8);
                writer.WriteStringValue(ScheduleRunFrequency.Value.ToString());
            }
            if (Optional.IsDefined(HourlySchedule))
            {
                writer.WritePropertyName("hourlySchedule"u8);
                writer.WriteObjectValue(HourlySchedule);
            }
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
            writer.WritePropertyName("schedulePolicyType"u8);
            writer.WriteStringValue(SchedulePolicyType);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SimpleSchedulePolicyV2 IJsonModel<SimpleSchedulePolicyV2>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSimpleSchedulePolicyV2(document.RootElement, options);
        }

        internal static SimpleSchedulePolicyV2 DeserializeSimpleSchedulePolicyV2(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ScheduleRunType> scheduleRunFrequency = default;
            Optional<BackupHourlySchedule> hourlySchedule = default;
            Optional<BackupDailySchedule> dailySchedule = default;
            Optional<BackupWeeklySchedule> weeklySchedule = default;
            string schedulePolicyType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduleRunFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduleRunFrequency = new ScheduleRunType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("hourlySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hourlySchedule = BackupHourlySchedule.DeserializeBackupHourlySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("dailySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dailySchedule = BackupDailySchedule.DeserializeBackupDailySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("weeklySchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weeklySchedule = BackupWeeklySchedule.DeserializeBackupWeeklySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("schedulePolicyType"u8))
                {
                    schedulePolicyType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SimpleSchedulePolicyV2(schedulePolicyType, serializedAdditionalRawData, Optional.ToNullable(scheduleRunFrequency), hourlySchedule.Value, dailySchedule.Value, weeklySchedule.Value);
        }

        BinaryData IModel<SimpleSchedulePolicyV2>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SimpleSchedulePolicyV2 IModel<SimpleSchedulePolicyV2>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SimpleSchedulePolicyV2)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSimpleSchedulePolicyV2(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SimpleSchedulePolicyV2>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
