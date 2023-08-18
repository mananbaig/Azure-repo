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
    [JsonConverter(typeof(ApiManagementGatewayUpdatedEventDataConverter))]
    public partial class ApiManagementGatewayUpdatedEventData
    {
        internal static ApiManagementGatewayUpdatedEventData DeserializeApiManagementGatewayUpdatedEventData(JsonElement element)
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
            return new ApiManagementGatewayUpdatedEventData(resourceUri.Value);
        }

        internal partial class ApiManagementGatewayUpdatedEventDataConverter : JsonConverter<ApiManagementGatewayUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementGatewayUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ApiManagementGatewayUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementGatewayUpdatedEventData(document.RootElement);
            }
        }
    }
}
