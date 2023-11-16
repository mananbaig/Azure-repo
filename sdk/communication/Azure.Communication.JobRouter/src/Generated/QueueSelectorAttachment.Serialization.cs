// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    [PersistableModelProxy(typeof(UnknownQueueSelectorAttachment))]
    public partial class QueueSelectorAttachment : IUtf8JsonSerializable, IJsonModel<QueueSelectorAttachment>
    {
        void IJsonModel<QueueSelectorAttachment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(QueueSelectorAttachment)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        QueueSelectorAttachment IJsonModel<QueueSelectorAttachment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(QueueSelectorAttachment)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueueSelectorAttachment(document.RootElement, options);
        }

        internal static QueueSelectorAttachment DeserializeQueueSelectorAttachment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "conditional": return ConditionalQueueSelectorAttachment.DeserializeConditionalQueueSelectorAttachment(element);
                    case "passThrough": return PassThroughQueueSelectorAttachment.DeserializePassThroughQueueSelectorAttachment(element);
                    case "ruleEngine": return RuleEngineQueueSelectorAttachment.DeserializeRuleEngineQueueSelectorAttachment(element);
                    case "static": return StaticQueueSelectorAttachment.DeserializeStaticQueueSelectorAttachment(element);
                    case "weightedAllocation": return WeightedAllocationQueueSelectorAttachment.DeserializeWeightedAllocationQueueSelectorAttachment(element);
                }
            }
            return UnknownQueueSelectorAttachment.DeserializeUnknownQueueSelectorAttachment(element);
        }

        BinaryData IPersistableModel<QueueSelectorAttachment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(QueueSelectorAttachment)} does not support '{options.Format}' format.");
            }
        }

        QueueSelectorAttachment IPersistableModel<QueueSelectorAttachment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueueSelectorAttachment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeQueueSelectorAttachment(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(QueueSelectorAttachment)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueueSelectorAttachment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static QueueSelectorAttachment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeQueueSelectorAttachment(document.RootElement, new ModelReaderWriterOptions("W"));
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
