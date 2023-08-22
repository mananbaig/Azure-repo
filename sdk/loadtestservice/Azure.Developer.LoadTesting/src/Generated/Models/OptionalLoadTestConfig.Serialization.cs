// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class OptionalLoadTestConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointUrl))
            {
                writer.WritePropertyName("endpointUrl"u8);
                writer.WriteStringValue(EndpointUrl.AbsoluteUri);
            }
            if (Optional.IsDefined(VirtualUsers))
            {
                writer.WritePropertyName("virtualUsers"u8);
                writer.WriteNumberValue(VirtualUsers.Value);
            }
            if (Optional.IsDefined(RampUpTime))
            {
                writer.WritePropertyName("rampUpTime"u8);
                writer.WriteNumberValue(RampUpTime.Value);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteNumberValue(Duration.Value);
            }
            writer.WriteEndObject();
        }

        internal static OptionalLoadTestConfig DeserializeOptionalLoadTestConfig(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> endpointUrl = default;
            Optional<int> virtualUsers = default;
            Optional<int> rampUpTime = default;
            Optional<int> duration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualUsers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualUsers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rampUpTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rampUpTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetInt32();
                    continue;
                }
            }
            return new OptionalLoadTestConfig(endpointUrl.Value, Optional.ToNullable(virtualUsers), Optional.ToNullable(rampUpTime), Optional.ToNullable(duration));
        }
    }
}
