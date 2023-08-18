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
    [JsonConverter(typeof(AcsChatThreadCreatedEventDataConverter))]
    public partial class AcsChatThreadCreatedEventData
    {
        internal static AcsChatThreadCreatedEventData DeserializeAcsChatThreadCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<CommunicationIdentifierModel> createdByCommunicationIdentifier = default;
            Core.Optional<IReadOnlyDictionary<string, object>> properties = default;
            Core.Optional<IReadOnlyList<AcsChatThreadParticipantProperties>> participants = default;
            Core.Optional<DateTimeOffset> createTime = default;
            Core.Optional<long> version = default;
            Core.Optional<string> transactionId = default;
            Core.Optional<string> threadId = default;
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
            return new AcsChatThreadCreatedEventData(transactionId.Value, threadId.Value, Core.Optional.ToNullable(createTime), Core.Optional.ToNullable(version), createdByCommunicationIdentifier.Value, Core.Optional.ToDictionary(properties), Core.Optional.ToList(participants));
        }

        internal partial class AcsChatThreadCreatedEventDataConverter : JsonConverter<AcsChatThreadCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsChatThreadCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadCreatedEventData(document.RootElement);
            }
        }
    }
}
