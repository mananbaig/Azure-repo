// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(StorageDirectoryRenamedEventDataConverter))]
    public partial class StorageDirectoryRenamedEventData
    {
        internal static StorageDirectoryRenamedEventData DeserializeStorageDirectoryRenamedEventData(JsonElement element)
        {
            Optional<string> api = default;
            Optional<string> clientRequestId = default;
            Optional<string> requestId = default;
            Optional<string> sourceUrl = default;
            Optional<string> destinationUrl = default;
            Optional<string> sequencer = default;
            Optional<string> identity = default;
            Optional<object> storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceUrl"))
                {
                    sourceUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationUrl"))
                {
                    destinationUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageDiagnostics = property.Value.GetObject();
                    continue;
                }
            }
            return new StorageDirectoryRenamedEventData(api.Value, clientRequestId.Value, requestId.Value, sourceUrl.Value, destinationUrl.Value, sequencer.Value, identity.Value, storageDiagnostics.Value);
        }

        internal partial class StorageDirectoryRenamedEventDataConverter : JsonConverter<StorageDirectoryRenamedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageDirectoryRenamedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override StorageDirectoryRenamedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageDirectoryRenamedEventData(document.RootElement);
            }
        }
    }
}
