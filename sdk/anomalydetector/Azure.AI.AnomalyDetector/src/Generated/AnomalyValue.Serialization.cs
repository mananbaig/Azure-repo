// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    public partial class AnomalyValue : IUtf8JsonSerializable, IJsonModel<AnomalyValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnomalyValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AnomalyValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnomalyValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnomalyValue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("isAnomaly"u8);
            writer.WriteBooleanValue(IsAnomaly);
            writer.WritePropertyName("severity"u8);
            writer.WriteNumberValue(Severity);
            writer.WritePropertyName("score"u8);
            writer.WriteNumberValue(Score);
            if (Optional.IsCollectionDefined(Interpretation))
            {
                writer.WritePropertyName("interpretation"u8);
                writer.WriteStartArray();
                foreach (var item in Interpretation)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AnomalyValue IJsonModel<AnomalyValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnomalyValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnomalyValue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnomalyValue(document.RootElement, options);
        }

        internal static AnomalyValue DeserializeAnomalyValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool isAnomaly = default;
            float severity = default;
            float score = default;
            Optional<IReadOnlyList<AnomalyInterpretation>> interpretation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isAnomaly"u8))
                {
                    isAnomaly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("score"u8))
                {
                    score = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("interpretation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnomalyInterpretation> array = new List<AnomalyInterpretation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnomalyInterpretation.DeserializeAnomalyInterpretation(item, options));
                    }
                    interpretation = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AnomalyValue(isAnomaly, severity, score, Optional.ToList(interpretation), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AnomalyValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnomalyValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AnomalyValue)} does not support '{options.Format}' format.");
            }
        }

        AnomalyValue IPersistableModel<AnomalyValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnomalyValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAnomalyValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnomalyValue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnomalyValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnomalyValue FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAnomalyValue(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
