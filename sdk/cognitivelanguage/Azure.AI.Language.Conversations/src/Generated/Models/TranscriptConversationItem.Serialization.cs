// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    public partial class TranscriptConversationItem : IUtf8JsonSerializable, IJsonModel<TranscriptConversationItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TranscriptConversationItem>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TranscriptConversationItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranscriptConversationItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranscriptConversationItem)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("participantId"u8);
            writer.WriteStringValue(ParticipantId);
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(Modality))
            {
                writer.WritePropertyName("modality"u8);
                writer.WriteStringValue(Modality.Value.ToString());
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToString());
            }
            writer.WritePropertyName("itn"u8);
            writer.WriteStringValue(InverseTextNormalized);
            writer.WritePropertyName("maskedItn"u8);
            writer.WriteStringValue(MaskedInverseTextNormalized);
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("lexical"u8);
            writer.WriteStringValue(Lexical);
            if (Optional.IsCollectionDefined(WordLevelTimings))
            {
                writer.WritePropertyName("wordLevelTimings"u8);
                writer.WriteStartArray();
                foreach (var item in WordLevelTimings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ConversationItemLevelTiming))
            {
                writer.WritePropertyName("conversationItemLevelTiming"u8);
                writer.WriteObjectValue(ConversationItemLevelTiming, options);
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
        }

        TranscriptConversationItem IJsonModel<TranscriptConversationItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranscriptConversationItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TranscriptConversationItem)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTranscriptConversationItem(document.RootElement, options);
        }

        internal static TranscriptConversationItem DeserializeTranscriptConversationItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string participantId = default;
            string language = default;
            InputModality? modality = default;
            ParticipantRole? role = default;
            string itn = default;
            string maskedItn = default;
            string text = default;
            string lexical = default;
            IList<WordLevelTiming> wordLevelTimings = default;
            ConversationItemLevelTiming conversationItemLevelTiming = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("participantId"u8))
                {
                    participantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modality"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modality = new InputModality(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    role = new ParticipantRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("itn"u8))
                {
                    itn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maskedItn"u8))
                {
                    maskedItn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lexical"u8))
                {
                    lexical = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wordLevelTimings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WordLevelTiming> array = new List<WordLevelTiming>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WordLevelTiming.DeserializeWordLevelTiming(item, options));
                    }
                    wordLevelTimings = array;
                    continue;
                }
                if (property.NameEquals("conversationItemLevelTiming"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conversationItemLevelTiming = ConversationItemLevelTiming.DeserializeConversationItemLevelTiming(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TranscriptConversationItem(
                id,
                participantId,
                language,
                modality,
                role,
                itn,
                maskedItn,
                text,
                lexical,
                wordLevelTimings ?? new ChangeTrackingList<WordLevelTiming>(),
                conversationItemLevelTiming,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TranscriptConversationItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranscriptConversationItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TranscriptConversationItem)} does not support writing '{options.Format}' format.");
            }
        }

        TranscriptConversationItem IPersistableModel<TranscriptConversationItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TranscriptConversationItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTranscriptConversationItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TranscriptConversationItem)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TranscriptConversationItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TranscriptConversationItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTranscriptConversationItem(document.RootElement);
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
