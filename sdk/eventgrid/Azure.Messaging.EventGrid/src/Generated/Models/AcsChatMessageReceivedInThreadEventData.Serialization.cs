// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatMessageReceivedInThreadEventDataConverter))]
    public partial class AcsChatMessageReceivedInThreadEventData
    {
        internal static AcsChatMessageReceivedInThreadEventData DeserializeAcsChatMessageReceivedInThreadEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> messageBody = default;
            Core.Optional<IReadOnlyDictionary<string, string>> metadata = default;
            Core.Optional<string> messageId = default;
            Core.Optional<CommunicationIdentifierModel> senderCommunicationIdentifier = default;
            Core.Optional<string> senderDisplayName = default;
            Core.Optional<DateTimeOffset> composeTime = default;
            Core.Optional<string> type = default;
            Core.Optional<long> version = default;
            Core.Optional<string> transactionId = default;
            Core.Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("messageBody"u8))
                {
                    messageBody = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("senderCommunicationIdentifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    senderCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("senderDisplayName"u8))
                {
                    senderDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("composeTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    composeTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
            }
            return new AcsChatMessageReceivedInThreadEventData(transactionId.Value, threadId.Value, messageId.Value, senderCommunicationIdentifier.Value, senderDisplayName.Value, Core.Optional.ToNullable(composeTime), type.Value, Core.Optional.ToNullable(version), messageBody.Value, Core.Optional.ToDictionary(metadata));
        }

        internal partial class AcsChatMessageReceivedInThreadEventDataConverter : JsonConverter<AcsChatMessageReceivedInThreadEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatMessageReceivedInThreadEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsChatMessageReceivedInThreadEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatMessageReceivedInThreadEventData(document.RootElement);
            }
        }
    }
}
