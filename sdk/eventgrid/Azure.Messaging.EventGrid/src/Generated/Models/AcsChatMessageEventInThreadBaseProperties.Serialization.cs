// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsChatMessageEventInThreadBaseProperties
    {
        internal static AcsChatMessageEventInThreadBaseProperties DeserializeAcsChatMessageEventInThreadBaseProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
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
            return new AcsChatMessageEventInThreadBaseProperties(transactionId.Value, threadId.Value, messageId.Value, senderCommunicationIdentifier.Value, senderDisplayName.Value, Core.Optional.ToNullable(composeTime), type.Value, Core.Optional.ToNullable(version));
        }
    }
}
