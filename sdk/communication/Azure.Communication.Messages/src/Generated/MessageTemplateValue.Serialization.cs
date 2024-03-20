// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.Messages
{
    [PersistableModelProxy(typeof(UnknownMessageTemplateValue))]
    public partial class MessageTemplateValue : IUtf8JsonSerializable, IJsonModel<MessageTemplateValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MessageTemplateValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MessageTemplateValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTemplateValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageTemplateValue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        MessageTemplateValue IJsonModel<MessageTemplateValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTemplateValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MessageTemplateValue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMessageTemplateValue(document.RootElement, options);
        }

        internal static MessageTemplateValue DeserializeMessageTemplateValue(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "document": return MessageTemplateDocument.DeserializeMessageTemplateDocument(element, options);
                    case "image": return MessageTemplateImage.DeserializeMessageTemplateImage(element, options);
                    case "location": return MessageTemplateLocation.DeserializeMessageTemplateLocation(element, options);
                    case "quickAction": return MessageTemplateQuickAction.DeserializeMessageTemplateQuickAction(element, options);
                    case "text": return MessageTemplateText.DeserializeMessageTemplateText(element, options);
                    case "video": return MessageTemplateVideo.DeserializeMessageTemplateVideo(element, options);
                }
            }
            return UnknownMessageTemplateValue.DeserializeUnknownMessageTemplateValue(element, options);
        }

        BinaryData IPersistableModel<MessageTemplateValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTemplateValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MessageTemplateValue)} does not support '{options.Format}' format.");
            }
        }

        MessageTemplateValue IPersistableModel<MessageTemplateValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MessageTemplateValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMessageTemplateValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MessageTemplateValue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MessageTemplateValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MessageTemplateValue FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMessageTemplateValue(document.RootElement);
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
