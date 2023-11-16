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

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    public partial class NewRelicObservabilityMetricRules : IUtf8JsonSerializable, IJsonModel<NewRelicObservabilityMetricRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NewRelicObservabilityMetricRules>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NewRelicObservabilityMetricRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NewRelicObservabilityMetricRules>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NewRelicObservabilityMetricRules>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SendMetrics))
            {
                writer.WritePropertyName("sendMetrics"u8);
                writer.WriteStringValue(SendMetrics.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags"u8);
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UserEmail))
            {
                writer.WritePropertyName("userEmail"u8);
                writer.WriteStringValue(UserEmail);
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

        NewRelicObservabilityMetricRules IJsonModel<NewRelicObservabilityMetricRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityMetricRules)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNewRelicObservabilityMetricRules(document.RootElement, options);
        }

        internal static NewRelicObservabilityMetricRules DeserializeNewRelicObservabilityMetricRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NewRelicObservabilitySendMetricsStatus> sendMetrics = default;
            Optional<IList<NewRelicObservabilityFilteringTag>> filteringTags = default;
            Optional<string> userEmail = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendMetrics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendMetrics = new NewRelicObservabilitySendMetricsStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filteringTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NewRelicObservabilityFilteringTag> array = new List<NewRelicObservabilityFilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NewRelicObservabilityFilteringTag.DeserializeNewRelicObservabilityFilteringTag(item));
                    }
                    filteringTags = array;
                    continue;
                }
                if (property.NameEquals("userEmail"u8))
                {
                    userEmail = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NewRelicObservabilityMetricRules(Optional.ToNullable(sendMetrics), Optional.ToList(filteringTags), userEmail.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NewRelicObservabilityMetricRules>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityMetricRules)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NewRelicObservabilityMetricRules IPersistableModel<NewRelicObservabilityMetricRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NewRelicObservabilityMetricRules)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNewRelicObservabilityMetricRules(document.RootElement, options);
        }

        string IPersistableModel<NewRelicObservabilityMetricRules>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
