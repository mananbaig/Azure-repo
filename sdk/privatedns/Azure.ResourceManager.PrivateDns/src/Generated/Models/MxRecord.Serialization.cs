// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns.Models
{
    public partial class MxRecord : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Preference))
            {
                writer.WritePropertyName("preference");
                writer.WriteNumberValue(Preference.Value);
            }
            if (Optional.IsDefined(Exchange))
            {
                writer.WritePropertyName("exchange");
                writer.WriteStringValue(Exchange);
            }
            writer.WriteEndObject();
        }

        internal static MxRecord DeserializeMxRecord(JsonElement element)
        {
            Optional<int> preference = default;
            Optional<string> exchange = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preference = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exchange"))
                {
                    exchange = property.Value.GetString();
                    continue;
                }
            }
            return new MxRecord(Optional.ToNullable(preference), exchange.Value);
        }
    }
}
