// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Inference
{
    [PersistableModelProxy(typeof(UnknownChatCompletionsNamedToolSelection))]
    public partial class ChatCompletionsNamedToolSelection : IUtf8JsonSerializable, IJsonModel<ChatCompletionsNamedToolSelection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChatCompletionsNamedToolSelection>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChatCompletionsNamedToolSelection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsNamedToolSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionsNamedToolSelection)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
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
        }

        ChatCompletionsNamedToolSelection IJsonModel<ChatCompletionsNamedToolSelection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsNamedToolSelection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionsNamedToolSelection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionsNamedToolSelection(document.RootElement, options);
        }

        internal static ChatCompletionsNamedToolSelection DeserializeChatCompletionsNamedToolSelection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "function": return ChatCompletionsNamedFunctionToolSelection.DeserializeChatCompletionsNamedFunctionToolSelection(element, options);
                }
            }
            return UnknownChatCompletionsNamedToolSelection.DeserializeUnknownChatCompletionsNamedToolSelection(element, options);
        }

        BinaryData IPersistableModel<ChatCompletionsNamedToolSelection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsNamedToolSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionsNamedToolSelection)} does not support writing '{options.Format}' format.");
            }
        }

        ChatCompletionsNamedToolSelection IPersistableModel<ChatCompletionsNamedToolSelection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionsNamedToolSelection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletionsNamedToolSelection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionsNamedToolSelection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionsNamedToolSelection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ChatCompletionsNamedToolSelection FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletionsNamedToolSelection(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
