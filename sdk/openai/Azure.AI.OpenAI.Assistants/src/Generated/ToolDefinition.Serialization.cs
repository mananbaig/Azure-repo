// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    [PersistableModelProxy(typeof(UnknownToolDefinition))]
    public partial class ToolDefinition : IUtf8JsonSerializable, IJsonModel<ToolDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ToolDefinition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ToolDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ToolDefinition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            writer.WriteEndObject();
        }

        ToolDefinition IJsonModel<ToolDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ToolDefinition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ToolDefinition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeToolDefinition(document.RootElement, options);
        }

        internal static ToolDefinition DeserializeToolDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "code_interpreter": return CodeInterpreterToolDefinition.DeserializeCodeInterpreterToolDefinition(element, options);
                    case "retrieval": return RetrievalToolDefinition.DeserializeRetrievalToolDefinition(element, options);
                    case "function": return FunctionToolDefinition.DeserializeFunctionToolDefinition(element, options);
                }
            }
            return UnknownToolDefinition.DeserializeUnknownToolDefinition(element, options);
        }

        BinaryData IPersistableModel<ToolDefinition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ToolDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ToolDefinition)} does not support '{options.Format}' format.");
            }
        }

        ToolDefinition IPersistableModel<ToolDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ToolDefinition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeToolDefinition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ToolDefinition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ToolDefinition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ToolDefinition FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeToolDefinition(document.RootElement);
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
