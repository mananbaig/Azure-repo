// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatThreadCreatedWithUserEventDataConverter))]
    public partial class AcsChatThreadCreatedWithUserEventData : IUtf8JsonSerializable, IModelJsonSerializable<AcsChatThreadCreatedWithUserEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AcsChatThreadCreatedWithUserEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AcsChatThreadCreatedWithUserEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsChatThreadCreatedWithUserEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CreatedByCommunicationIdentifier))
            {
                writer.WritePropertyName("createdByCommunicationIdentifier"u8);
                if (CreatedByCommunicationIdentifier is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationIdentifierModel>)CreatedByCommunicationIdentifier).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
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
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Participants))
            {
                writer.WritePropertyName("participants"u8);
                writer.WriteStartArray();
                foreach (var item in Participants)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AcsChatThreadParticipantProperties>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CreateTime))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreateTime.Value, "O");
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(RecipientCommunicationIdentifier))
            {
                writer.WritePropertyName("recipientCommunicationIdentifier"u8);
                if (RecipientCommunicationIdentifier is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationIdentifierModel>)RecipientCommunicationIdentifier).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TransactionId))
            {
                writer.WritePropertyName("transactionId"u8);
                writer.WriteStringValue(TransactionId);
            }
            if (Optional.IsDefined(ThreadId))
            {
                writer.WritePropertyName("threadId"u8);
                writer.WriteStringValue(ThreadId);
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AcsChatThreadCreatedWithUserEventData DeserializeAcsChatThreadCreatedWithUserEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CommunicationIdentifierModel> createdByCommunicationIdentifier = default;
            Optional<IReadOnlyDictionary<string, object>> properties = default;
            Optional<IReadOnlyList<AcsChatThreadParticipantProperties>> participants = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<long> version = default;
            Optional<CommunicationIdentifierModel> recipientCommunicationIdentifier = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createdByCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("participants"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsChatThreadParticipantProperties> array = new List<AcsChatThreadParticipantProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AcsChatThreadParticipantProperties.DeserializeAcsChatThreadParticipantProperties(item));
                    }
                    participants = array;
                    continue;
                }
                if (property.NameEquals("createTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recipientCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AcsChatThreadCreatedWithUserEventData(recipientCommunicationIdentifier.Value, transactionId.Value, threadId.Value, Optional.ToNullable(createTime), Optional.ToNullable(version), createdByCommunicationIdentifier.Value, Optional.ToDictionary(properties), Optional.ToList(participants), serializedAdditionalRawData);
        }

        AcsChatThreadCreatedWithUserEventData IModelJsonSerializable<AcsChatThreadCreatedWithUserEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsChatThreadCreatedWithUserEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsChatThreadCreatedWithUserEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AcsChatThreadCreatedWithUserEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsChatThreadCreatedWithUserEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AcsChatThreadCreatedWithUserEventData IModelSerializable<AcsChatThreadCreatedWithUserEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsChatThreadCreatedWithUserEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAcsChatThreadCreatedWithUserEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AcsChatThreadCreatedWithUserEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AcsChatThreadCreatedWithUserEventData"/> to convert. </param>
        public static implicit operator RequestContent(AcsChatThreadCreatedWithUserEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AcsChatThreadCreatedWithUserEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AcsChatThreadCreatedWithUserEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAcsChatThreadCreatedWithUserEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AcsChatThreadCreatedWithUserEventDataConverter : JsonConverter<AcsChatThreadCreatedWithUserEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadCreatedWithUserEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsChatThreadCreatedWithUserEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadCreatedWithUserEventData(document.RootElement);
            }
        }
    }
}
