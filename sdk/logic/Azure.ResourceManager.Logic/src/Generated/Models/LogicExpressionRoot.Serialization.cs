// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicExpressionRoot : IUtf8JsonSerializable, IJsonModel<LogicExpressionRoot>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicExpressionRoot>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LogicExpressionRoot>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicExpressionRoot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicExpressionRoot)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Value);
#else
                using (JsonDocument document = JsonDocument.Parse(Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(Subexpressions))
            {
                writer.WritePropertyName("subexpressions"u8);
                writer.WriteStartArray();
                foreach (var item in Subexpressions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error, options);
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

        LogicExpressionRoot IJsonModel<LogicExpressionRoot>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicExpressionRoot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicExpressionRoot)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicExpressionRoot(document.RootElement, options);
        }

        internal static LogicExpressionRoot DeserializeLogicExpressionRoot(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string path = default;
            string text = default;
            BinaryData value = default;
            IReadOnlyList<LogicExpression> subexpressions = default;
            LogicExpressionErrorInfo error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("subexpressions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LogicExpression> array = new List<LogicExpression>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeLogicExpression(item, options));
                    }
                    subexpressions = array;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = LogicExpressionErrorInfo.DeserializeLogicExpressionErrorInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LogicExpressionRoot(
                text,
                value,
                subexpressions ?? new ChangeTrackingList<LogicExpression>(),
                error,
                serializedAdditionalRawData,
                path);
        }

        BinaryData IPersistableModel<LogicExpressionRoot>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicExpressionRoot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicExpressionRoot)} does not support writing '{options.Format}' format.");
            }
        }

        LogicExpressionRoot IPersistableModel<LogicExpressionRoot>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicExpressionRoot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicExpressionRoot(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicExpressionRoot)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicExpressionRoot>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
