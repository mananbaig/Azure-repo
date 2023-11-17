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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAutoScaleRecurrence : IUtf8JsonSerializable, IJsonModel<HDInsightAutoScaleRecurrence>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAutoScaleRecurrence>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightAutoScaleRecurrence>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HDInsightAutoScaleRecurrence>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HDInsightAutoScaleRecurrence>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (Optional.IsCollectionDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                writer.WriteStartArray();
                foreach (var item in Schedule)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        HDInsightAutoScaleRecurrence IJsonModel<HDInsightAutoScaleRecurrence>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleRecurrence)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAutoScaleRecurrence(document.RootElement, options);
        }

        internal static HDInsightAutoScaleRecurrence DeserializeHDInsightAutoScaleRecurrence(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timeZone = default;
            Optional<IList<HDInsightAutoScaleSchedule>> schedule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightAutoScaleSchedule> array = new List<HDInsightAutoScaleSchedule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightAutoScaleSchedule.DeserializeHDInsightAutoScaleSchedule(item));
                    }
                    schedule = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightAutoScaleRecurrence(timeZone.Value, Optional.ToList(schedule), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAutoScaleRecurrence>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleRecurrence)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HDInsightAutoScaleRecurrence IPersistableModel<HDInsightAutoScaleRecurrence>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleRecurrence)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHDInsightAutoScaleRecurrence(document.RootElement, options);
        }

        string IPersistableModel<HDInsightAutoScaleRecurrence>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
