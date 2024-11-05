// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsChatThreadPropertiesUpdatedPerUserEventData : IUtf8JsonSerializable, IJsonModel<AcsChatThreadPropertiesUpdatedPerUserEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsChatThreadPropertiesUpdatedPerUserEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AcsChatThreadPropertiesUpdatedPerUserEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatThreadPropertiesUpdatedPerUserEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsChatThreadPropertiesUpdatedPerUserEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("editedByCommunicationIdentifier"u8);
            writer.WriteObjectValue(EditedByCommunicationIdentifier, options);
            writer.WritePropertyName("editTime"u8);
            writer.WriteStringValue(EditTime, "O");
            writer.WritePropertyName("metadata"u8);
            writer.WriteStartObject();
            foreach (var item in Metadata)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            foreach (var item in Properties)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        AcsChatThreadPropertiesUpdatedPerUserEventData IJsonModel<AcsChatThreadPropertiesUpdatedPerUserEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatThreadPropertiesUpdatedPerUserEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AcsChatThreadPropertiesUpdatedPerUserEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsChatThreadPropertiesUpdatedPerUserEventData(document.RootElement, options);
        }

        internal static AcsChatThreadPropertiesUpdatedPerUserEventData DeserializeAcsChatThreadPropertiesUpdatedPerUserEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModel editedByCommunicationIdentifier = default;
            DateTimeOffset editTime = default;
            IReadOnlyDictionary<string, string> metadata = default;
            IReadOnlyDictionary<string, BinaryData> properties = default;
            DateTimeOffset createTime = default;
            long? version = default;
            CommunicationIdentifierModel recipientCommunicationIdentifier = default;
            string transactionId = default;
            string threadId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("editedByCommunicationIdentifier"u8))
                {
                    editedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value, options);
                    continue;
                }
                if (property.NameEquals("editTime"u8))
                {
                    editTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recipientCommunicationIdentifier"u8))
                {
                    recipientCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value, options);
                    continue;
                }
                if (property.NameEquals("transactionId"u8))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"u8))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AcsChatThreadPropertiesUpdatedPerUserEventData(
                recipientCommunicationIdentifier,
                transactionId,
                threadId,
                serializedAdditionalRawData,
                createTime,
                version,
                editedByCommunicationIdentifier,
                editTime,
                metadata,
                properties);
        }

        BinaryData IPersistableModel<AcsChatThreadPropertiesUpdatedPerUserEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatThreadPropertiesUpdatedPerUserEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AcsChatThreadPropertiesUpdatedPerUserEventData)} does not support writing '{options.Format}' format.");
            }
        }

        AcsChatThreadPropertiesUpdatedPerUserEventData IPersistableModel<AcsChatThreadPropertiesUpdatedPerUserEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsChatThreadPropertiesUpdatedPerUserEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAcsChatThreadPropertiesUpdatedPerUserEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AcsChatThreadPropertiesUpdatedPerUserEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsChatThreadPropertiesUpdatedPerUserEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AcsChatThreadPropertiesUpdatedPerUserEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAcsChatThreadPropertiesUpdatedPerUserEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
