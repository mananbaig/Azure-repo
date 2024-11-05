// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBMigrationSettings : IUtf8JsonSerializable, IJsonModel<MongoDBMigrationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBMigrationSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MongoDBMigrationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBMigrationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBMigrationSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BoostRUs))
            {
                writer.WritePropertyName("boostRUs"u8);
                writer.WriteNumberValue(BoostRUs.Value);
            }
            writer.WritePropertyName("databases"u8);
            writer.WriteStartObject();
            foreach (var item in Databases)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value, options);
            }
            writer.WriteEndObject();
            if (Optional.IsDefined(Replication))
            {
                writer.WritePropertyName("replication"u8);
                writer.WriteStringValue(Replication.Value.ToString());
            }
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source, options);
            writer.WritePropertyName("target"u8);
            writer.WriteObjectValue(Target, options);
            if (Optional.IsDefined(Throttling))
            {
                writer.WritePropertyName("throttling"u8);
                writer.WriteObjectValue(Throttling, options);
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

        MongoDBMigrationSettings IJsonModel<MongoDBMigrationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBMigrationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBMigrationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBMigrationSettings(document.RootElement, options);
        }

        internal static MongoDBMigrationSettings DeserializeMongoDBMigrationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? boostRUs = default;
            IDictionary<string, MongoDBDatabaseSettings> databases = default;
            MongoDBReplication? replication = default;
            MongoDBConnectionInfo source = default;
            MongoDBConnectionInfo target = default;
            MongoDBThrottlingSettings throttling = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("boostRUs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    boostRUs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("databases"u8))
                {
                    Dictionary<string, MongoDBDatabaseSettings> dictionary = new Dictionary<string, MongoDBDatabaseSettings>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, MongoDBDatabaseSettings.DeserializeMongoDBDatabaseSettings(property0.Value, options));
                    }
                    databases = dictionary;
                    continue;
                }
                if (property.NameEquals("replication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replication = new MongoDBReplication(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = MongoDBConnectionInfo.DeserializeMongoDBConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = MongoDBConnectionInfo.DeserializeMongoDBConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("throttling"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throttling = MongoDBThrottlingSettings.DeserializeMongoDBThrottlingSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MongoDBMigrationSettings(
                boostRUs,
                databases,
                replication,
                source,
                target,
                throttling,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoDBMigrationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBMigrationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBMigrationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        MongoDBMigrationSettings IPersistableModel<MongoDBMigrationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBMigrationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBMigrationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBMigrationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBMigrationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
