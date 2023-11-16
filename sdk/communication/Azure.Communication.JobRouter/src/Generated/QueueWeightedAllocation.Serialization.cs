// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class QueueWeightedAllocation : IUtf8JsonSerializable, IJsonModel<QueueWeightedAllocation>
    {
        void IJsonModel<QueueWeightedAllocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<QueueWeightedAllocation>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<QueueWeightedAllocation>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("weight"u8);
            writer.WriteNumberValue(Weight);
            writer.WritePropertyName("queueSelectors"u8);
            writer.WriteStartArray();
            foreach (var item in QueueSelectors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        QueueWeightedAllocation IJsonModel<QueueWeightedAllocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QueueWeightedAllocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueueWeightedAllocation(document.RootElement, options);
        }

        internal static QueueWeightedAllocation DeserializeQueueWeightedAllocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double weight = default;
            IReadOnlyList<RouterQueueSelector> queueSelectors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("weight"u8))
                {
                    weight = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("queueSelectors"u8))
                {
                    List<RouterQueueSelector> array = new List<RouterQueueSelector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouterQueueSelector.DeserializeRouterQueueSelector(item));
                    }
                    queueSelectors = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new QueueWeightedAllocation(weight, queueSelectors, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueueWeightedAllocation>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QueueWeightedAllocation)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        QueueWeightedAllocation IPersistableModel<QueueWeightedAllocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QueueWeightedAllocation)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeQueueWeightedAllocation(document.RootElement, options);
        }

        string IPersistableModel<QueueWeightedAllocation>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static QueueWeightedAllocation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeQueueWeightedAllocation(document.RootElement, ModelReaderWriterOptions.Wire);
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
