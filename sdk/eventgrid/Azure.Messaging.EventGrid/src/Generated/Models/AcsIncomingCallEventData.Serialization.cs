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
    [JsonConverter(typeof(AcsIncomingCallEventDataConverter))]
    public partial class AcsIncomingCallEventData : IUtf8JsonSerializable, IModelJsonSerializable<AcsIncomingCallEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AcsIncomingCallEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AcsIncomingCallEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsIncomingCallEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ToCommunicationIdentifier))
            {
                writer.WritePropertyName("to"u8);
                if (ToCommunicationIdentifier is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationIdentifierModel>)ToCommunicationIdentifier).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(FromCommunicationIdentifier))
            {
                writer.WritePropertyName("from"u8);
                if (FromCommunicationIdentifier is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CommunicationIdentifierModel>)FromCommunicationIdentifier).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ServerCallId))
            {
                writer.WritePropertyName("serverCallId"u8);
                writer.WriteStringValue(ServerCallId);
            }
            if (Optional.IsDefined(CallerDisplayName))
            {
                writer.WritePropertyName("callerDisplayName"u8);
                writer.WriteStringValue(CallerDisplayName);
            }
            if (Optional.IsDefined(CustomContext))
            {
                writer.WritePropertyName("customContext"u8);
                if (CustomContext is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AcsIncomingCallCustomContext>)CustomContext).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IncomingCallContext))
            {
                writer.WritePropertyName("incomingCallContext"u8);
                writer.WriteStringValue(IncomingCallContext);
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
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

        internal static AcsIncomingCallEventData DeserializeAcsIncomingCallEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CommunicationIdentifierModel> to = default;
            Optional<CommunicationIdentifierModel> @from = default;
            Optional<string> serverCallId = default;
            Optional<string> callerDisplayName = default;
            Optional<AcsIncomingCallCustomContext> customContext = default;
            Optional<string> incomingCallContext = default;
            Optional<string> correlationId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("to"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    to = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("from"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @from = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callerDisplayName"u8))
                {
                    callerDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customContext"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customContext = AcsIncomingCallCustomContext.DeserializeAcsIncomingCallCustomContext(property.Value);
                    continue;
                }
                if (property.NameEquals("incomingCallContext"u8))
                {
                    incomingCallContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AcsIncomingCallEventData(to.Value, @from.Value, serverCallId.Value, callerDisplayName.Value, customContext.Value, incomingCallContext.Value, correlationId.Value, serializedAdditionalRawData);
        }

        AcsIncomingCallEventData IModelJsonSerializable<AcsIncomingCallEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsIncomingCallEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsIncomingCallEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AcsIncomingCallEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsIncomingCallEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AcsIncomingCallEventData IModelSerializable<AcsIncomingCallEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AcsIncomingCallEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAcsIncomingCallEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AcsIncomingCallEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AcsIncomingCallEventData"/> to convert. </param>
        public static implicit operator RequestContent(AcsIncomingCallEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AcsIncomingCallEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AcsIncomingCallEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAcsIncomingCallEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class AcsIncomingCallEventDataConverter : JsonConverter<AcsIncomingCallEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsIncomingCallEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsIncomingCallEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsIncomingCallEventData(document.RootElement);
            }
        }
    }
}
