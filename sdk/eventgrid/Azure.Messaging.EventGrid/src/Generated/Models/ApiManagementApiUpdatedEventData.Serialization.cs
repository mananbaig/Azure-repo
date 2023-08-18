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
    [JsonConverter(typeof(ApiManagementApiUpdatedEventDataConverter))]
    public partial class ApiManagementApiUpdatedEventData
    {
        internal static ApiManagementApiUpdatedEventData DeserializeApiManagementApiUpdatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> resourceUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
            }
            return new ApiManagementApiUpdatedEventData(resourceUri.Value);
        }

        internal partial class ApiManagementApiUpdatedEventDataConverter : JsonConverter<ApiManagementApiUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementApiUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ApiManagementApiUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementApiUpdatedEventData(document.RootElement);
            }
        }
    }
}
