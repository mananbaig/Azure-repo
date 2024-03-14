// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ApiCenterApiDefinitionUpdatedEventDataConverter))]
    public partial class ApiCenterApiDefinitionUpdatedEventData
    {
        internal static ApiCenterApiDefinitionUpdatedEventData DeserializeApiCenterApiDefinitionUpdatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string title = default;
            string description = default;
            ApiCenterApiSpecification specification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("specification"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    specification = ApiCenterApiSpecification.DeserializeApiCenterApiSpecification(property.Value);
                    continue;
                }
            }
            return new ApiCenterApiDefinitionUpdatedEventData(title, description, specification);
        }

        internal partial class ApiCenterApiDefinitionUpdatedEventDataConverter : JsonConverter<ApiCenterApiDefinitionUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiCenterApiDefinitionUpdatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ApiCenterApiDefinitionUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiCenterApiDefinitionUpdatedEventData(document.RootElement);
            }
        }
    }
}
