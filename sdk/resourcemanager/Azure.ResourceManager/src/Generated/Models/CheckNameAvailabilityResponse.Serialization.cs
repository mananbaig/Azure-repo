// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(CheckNameAvailabilityResponseConverter))]
    public partial class CheckNameAvailabilityResponse
    {
        internal static CheckNameAvailabilityResponse DeserializeCheckNameAvailabilityResponse(JsonElement element)
        {
            Optional<bool> nameAvailable = default;
            Optional<CheckNameAvailabilityReason> reason = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reason = new CheckNameAvailabilityReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new CheckNameAvailabilityResponse(Optional.ToNullable(nameAvailable), Optional.ToNullable(reason), message.Value);
        }

        internal partial class CheckNameAvailabilityResponseConverter : JsonConverter<CheckNameAvailabilityResponse>
        {
            public override void Write(Utf8JsonWriter writer, CheckNameAvailabilityResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override CheckNameAvailabilityResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCheckNameAvailabilityResponse(document.RootElement);
            }
        }
    }
}
