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
    [JsonConverter(typeof(StorageDirectoryCreatedEventDataConverter))]
    public partial class StorageDirectoryCreatedEventData
    {
        internal static StorageDirectoryCreatedEventData DeserializeStorageDirectoryCreatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> api = default;
            Core.Optional<string> clientRequestId = default;
            Core.Optional<string> requestId = default;
            Core.Optional<string> eTag = default;
            Core.Optional<string> url = default;
            Core.Optional<string> sequencer = default;
            Core.Optional<string> identity = default;
            Core.Optional<object> storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"u8))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"u8))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageDiagnostics = property.Value.GetObject();
                    continue;
                }
            }
            return new StorageDirectoryCreatedEventData(api.Value, clientRequestId.Value, requestId.Value, eTag.Value, url.Value, sequencer.Value, identity.Value, storageDiagnostics.Value);
        }

        internal partial class StorageDirectoryCreatedEventDataConverter : JsonConverter<StorageDirectoryCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageDirectoryCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override StorageDirectoryCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageDirectoryCreatedEventData(document.RootElement);
            }
        }
    }
}
