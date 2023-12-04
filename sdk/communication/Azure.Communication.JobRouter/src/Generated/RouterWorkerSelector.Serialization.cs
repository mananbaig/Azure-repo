// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RouterWorkerSelector : IUtf8JsonSerializable, IJsonModel<RouterWorkerSelector>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouterWorkerSelector>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RouterWorkerSelector>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorkerSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RouterWorkerSelector)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key);
            writer.WritePropertyName("labelOperator"u8);
            writer.WriteStringValue(LabelOperator.ToString());
            if (Optional.IsDefined(_value))
            {
                writer.WritePropertyName("value"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(_value);
#else
                using (JsonDocument document = JsonDocument.Parse(_value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(_expiresAfterSeconds))
            {
                writer.WritePropertyName("expiresAfterSeconds"u8);
                writer.WriteNumberValue(_expiresAfterSeconds.Value);
            }
            if (Optional.IsDefined(Expedite))
            {
                writer.WritePropertyName("expedite"u8);
                writer.WriteBooleanValue(Expedite.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ExpiresAt))
            {
                writer.WritePropertyName("expiresAt"u8);
                writer.WriteStringValue(ExpiresAt.Value, "O");
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

        RouterWorkerSelector IJsonModel<RouterWorkerSelector>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorkerSelector>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RouterWorkerSelector)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouterWorkerSelector(document.RootElement, options);
        }

        internal static RouterWorkerSelector DeserializeRouterWorkerSelector(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            LabelOperator labelOperator = default;
            Optional<BinaryData> value = default;
            Optional<double> expiresAfterSeconds = default;
            Optional<bool> expedite = default;
            Optional<RouterWorkerSelectorStatus> status = default;
            Optional<DateTimeOffset> expiresAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelOperator"u8))
                {
                    labelOperator = new LabelOperator(property.Value.GetString());
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
                if (property.NameEquals("expiresAfterSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresAfterSeconds = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("expedite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expedite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new RouterWorkerSelectorStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiresAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiresAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RouterWorkerSelector(key, labelOperator, value.Value, Optional.ToNullable(expiresAfterSeconds), Optional.ToNullable(expedite), Optional.ToNullable(status), Optional.ToNullable(expiresAt), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouterWorkerSelector>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorkerSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RouterWorkerSelector)} does not support '{options.Format}' format.");
            }
        }

        RouterWorkerSelector IPersistableModel<RouterWorkerSelector>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouterWorkerSelector>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouterWorkerSelector(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RouterWorkerSelector)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouterWorkerSelector>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RouterWorkerSelector FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterWorkerSelector(document.RootElement);
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
