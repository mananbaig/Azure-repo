// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerMaintenanceWindow : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerMaintenanceWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerMaintenanceWindow>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerMaintenanceWindow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerMaintenanceWindow)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CustomWindow))
            {
                writer.WritePropertyName("customWindow"u8);
                writer.WriteStringValue(CustomWindow);
            }
            if (Optional.IsDefined(StartHour))
            {
                writer.WritePropertyName("startHour"u8);
                writer.WriteNumberValue(StartHour.Value);
            }
            if (Optional.IsDefined(StartMinute))
            {
                writer.WritePropertyName("startMinute"u8);
                writer.WriteNumberValue(StartMinute.Value);
            }
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteNumberValue(DayOfWeek.Value);
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

        PostgreSqlFlexibleServerMaintenanceWindow IJsonModel<PostgreSqlFlexibleServerMaintenanceWindow>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerMaintenanceWindow)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerMaintenanceWindow(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerMaintenanceWindow DeserializePostgreSqlFlexibleServerMaintenanceWindow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string customWindow = default;
            int? startHour = default;
            int? startMinute = default;
            int? dayOfWeek = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customWindow"u8))
                {
                    customWindow = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startHour"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startHour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startMinute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startMinute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostgreSqlFlexibleServerMaintenanceWindow(customWindow, startHour, startMinute, dayOfWeek, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerMaintenanceWindow>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerMaintenanceWindow)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerMaintenanceWindow IPersistableModel<PostgreSqlFlexibleServerMaintenanceWindow>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerMaintenanceWindow>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerMaintenanceWindow(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerMaintenanceWindow)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerMaintenanceWindow>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
