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
    [JsonConverter(typeof(FarmBeatsTillageDataChangedEventDataConverter))]
    public partial class FarmBeatsTillageDataChangedEventData
    {
        internal static FarmBeatsTillageDataChangedEventData DeserializeFarmBeatsTillageDataChangedEventData(JsonElement element)
        {
            Optional<ResourceActionType> actionType = default;
            Optional<string> farmerId = default;
            Optional<string> status = default;
            Optional<string> source = default;
            Optional<DateTimeOffset> modifiedDateTime = default;
            Optional<string> eTag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<IReadOnlyDictionary<string, object>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actionType = new ResourceActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("farmerId"))
                {
                    farmerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modifiedDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    properties = dictionary;
                    continue;
                }
            }
            return new FarmBeatsTillageDataChangedEventData(Optional.ToNullable(actionType), farmerId.Value, status.Value, source.Value, Optional.ToNullable(modifiedDateTime), eTag.Value, id.Value, name.Value, description.Value, Optional.ToNullable(createdDateTime), Optional.ToDictionary(properties));
        }

        internal partial class FarmBeatsTillageDataChangedEventDataConverter : JsonConverter<FarmBeatsTillageDataChangedEventData>
        {
            public override void Write(Utf8JsonWriter writer, FarmBeatsTillageDataChangedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override FarmBeatsTillageDataChangedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeFarmBeatsTillageDataChangedEventData(document.RootElement);
            }
        }
    }
}
