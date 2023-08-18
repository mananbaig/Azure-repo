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
    [JsonConverter(typeof(MediaJobCancelingEventDataConverter))]
    public partial class MediaJobCancelingEventData
    {
        internal static MediaJobCancelingEventData DeserializeMediaJobCancelingEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<MediaJobState> previousState = default;
            Core.Optional<MediaJobState> state = default;
            Core.Optional<IReadOnlyDictionary<string, string>> correlationData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("correlationData"u8))
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
                    correlationData = dictionary;
                    continue;
                }
            }
            return new MediaJobCancelingEventData(Core.Optional.ToNullable(previousState), Core.Optional.ToNullable(state), Core.Optional.ToDictionary(correlationData));
        }

        internal partial class MediaJobCancelingEventDataConverter : JsonConverter<MediaJobCancelingEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobCancelingEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MediaJobCancelingEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobCancelingEventData(document.RootElement);
            }
        }
    }
}
