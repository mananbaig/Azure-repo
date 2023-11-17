// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class FlinkHiveCatalogOption : IUtf8JsonSerializable, IJsonModel<FlinkHiveCatalogOption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FlinkHiveCatalogOption>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FlinkHiveCatalogOption>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<FlinkHiveCatalogOption>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<FlinkHiveCatalogOption>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("metastoreDbConnectionPasswordSecret"u8);
            writer.WriteStringValue(MetastoreDBConnectionPasswordSecret);
            writer.WritePropertyName("metastoreDbConnectionURL"u8);
            writer.WriteStringValue(MetastoreDBConnectionUriString);
            writer.WritePropertyName("metastoreDbConnectionUserName"u8);
            writer.WriteStringValue(MetastoreDBConnectionUserName);
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        FlinkHiveCatalogOption IJsonModel<FlinkHiveCatalogOption>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FlinkHiveCatalogOption)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFlinkHiveCatalogOption(document.RootElement, options);
        }

        internal static FlinkHiveCatalogOption DeserializeFlinkHiveCatalogOption(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metastoreDBConnectionPasswordSecret = default;
            string metastoreDBConnectionURL = default;
            string metastoreDBConnectionUserName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metastoreDbConnectionPasswordSecret"u8))
                {
                    metastoreDBConnectionPasswordSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionURL"u8))
                {
                    metastoreDBConnectionURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionUserName"u8))
                {
                    metastoreDBConnectionUserName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FlinkHiveCatalogOption(metastoreDBConnectionPasswordSecret, metastoreDBConnectionURL, metastoreDBConnectionUserName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FlinkHiveCatalogOption>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FlinkHiveCatalogOption)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FlinkHiveCatalogOption IPersistableModel<FlinkHiveCatalogOption>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FlinkHiveCatalogOption)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFlinkHiveCatalogOption(document.RootElement, options);
        }

        string IPersistableModel<FlinkHiveCatalogOption>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
