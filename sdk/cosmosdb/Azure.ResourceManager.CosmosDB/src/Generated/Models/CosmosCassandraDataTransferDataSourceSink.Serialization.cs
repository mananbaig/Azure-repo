// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosCassandraDataTransferDataSourceSink : IUtf8JsonSerializable, IJsonModel<CosmosCassandraDataTransferDataSourceSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosCassandraDataTransferDataSourceSink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosCassandraDataTransferDataSourceSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosCassandraDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosCassandraDataTransferDataSourceSink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("keyspaceName"u8);
            writer.WriteStringValue(KeyspaceName);
            writer.WritePropertyName("tableName"u8);
            writer.WriteStringValue(TableName);
            if (RemoteAccountName != null)
            {
                writer.WritePropertyName("remoteAccountName"u8);
                writer.WriteStringValue(RemoteAccountName);
            }
            writer.WritePropertyName("component"u8);
            writer.WriteStringValue(Component.ToString());
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

        CosmosCassandraDataTransferDataSourceSink IJsonModel<CosmosCassandraDataTransferDataSourceSink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosCassandraDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosCassandraDataTransferDataSourceSink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosCassandraDataTransferDataSourceSink(document.RootElement, options);
        }

        internal static CosmosCassandraDataTransferDataSourceSink DeserializeCosmosCassandraDataTransferDataSourceSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyspaceName = default;
            string tableName = default;
            string remoteAccountName = default;
            DataTransferComponent component = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyspaceName"u8))
                {
                    keyspaceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteAccountName"u8))
                {
                    remoteAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("component"u8))
                {
                    component = new DataTransferComponent(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosCassandraDataTransferDataSourceSink(component, serializedAdditionalRawData, remoteAccountName, keyspaceName, tableName);
        }

        BinaryData IPersistableModel<CosmosCassandraDataTransferDataSourceSink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosCassandraDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosCassandraDataTransferDataSourceSink)} does not support '{options.Format}' format.");
            }
        }

        CosmosCassandraDataTransferDataSourceSink IPersistableModel<CosmosCassandraDataTransferDataSourceSink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosCassandraDataTransferDataSourceSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosCassandraDataTransferDataSourceSink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosCassandraDataTransferDataSourceSink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosCassandraDataTransferDataSourceSink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
