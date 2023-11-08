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

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class MetricsBasedChart : IUtf8JsonSerializable, IJsonModel<MetricsBasedChart>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MetricsBasedChart>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<MetricsBasedChart>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AggregationType))
            {
                writer.WritePropertyName("aggregationType"u8);
                writer.WriteStringValue(AggregationType.Value.ToString());
            }
            if (Optional.IsDefined(TimeSpanDuration))
            {
                writer.WritePropertyName("timeSpanDuration"u8);
                writer.WriteStringValue(TimeSpanDuration.Value, "P");
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(FilterGroup))
            {
                writer.WritePropertyName("filterGroup"u8);
                writer.WriteObjectValue(FilterGroup);
            }
            if (Optional.IsDefined(ReplacementKey))
            {
                writer.WritePropertyName("replacementKey"u8);
                writer.WriteStringValue(ReplacementKey);
            }
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

        MetricsBasedChart IJsonModel<MetricsBasedChart>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricsBasedChart)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricsBasedChart(document.RootElement, options);
        }

        internal static MetricsBasedChart DeserializeMetricsBasedChart(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<AggregationType> aggregationType = default;
            Optional<TimeSpan> timeSpanDuration = default;
            Optional<string> title = default;
            Optional<FilterGroup> filterGroup = default;
            Optional<string> replacementKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aggregationType = new AggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeSpanDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeSpanDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filterGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filterGroup = FilterGroup.DeserializeFilterGroup(property.Value);
                    continue;
                }
                if (property.NameEquals("replacementKey"u8))
                {
                    replacementKey = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MetricsBasedChart(name.Value, Optional.ToNullable(aggregationType), Optional.ToNullable(timeSpanDuration), title.Value, filterGroup.Value, replacementKey.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<MetricsBasedChart>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricsBasedChart)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MetricsBasedChart IModel<MetricsBasedChart>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MetricsBasedChart)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMetricsBasedChart(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<MetricsBasedChart>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
