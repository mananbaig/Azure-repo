// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlQueryPerformanceInsightResetDataResult : IUtf8JsonSerializable, IJsonModel<MySqlQueryPerformanceInsightResetDataResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlQueryPerformanceInsightResetDataResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MySqlQueryPerformanceInsightResetDataResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlQueryPerformanceInsightResetDataResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlQueryPerformanceInsightResetDataResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        MySqlQueryPerformanceInsightResetDataResult IJsonModel<MySqlQueryPerformanceInsightResetDataResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlQueryPerformanceInsightResetDataResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlQueryPerformanceInsightResetDataResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlQueryPerformanceInsightResetDataResult(document.RootElement, options);
        }

        internal static MySqlQueryPerformanceInsightResetDataResult DeserializeMySqlQueryPerformanceInsightResetDataResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MySqlQueryPerformanceInsightResetDataResultState? status = default;
            string message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MySqlQueryPerformanceInsightResetDataResultState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MySqlQueryPerformanceInsightResetDataResult(status, message, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlQueryPerformanceInsightResetDataResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlQueryPerformanceInsightResetDataResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlQueryPerformanceInsightResetDataResult)} does not support writing '{options.Format}' format.");
            }
        }

        MySqlQueryPerformanceInsightResetDataResult IPersistableModel<MySqlQueryPerformanceInsightResetDataResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlQueryPerformanceInsightResetDataResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlQueryPerformanceInsightResetDataResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlQueryPerformanceInsightResetDataResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlQueryPerformanceInsightResetDataResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
