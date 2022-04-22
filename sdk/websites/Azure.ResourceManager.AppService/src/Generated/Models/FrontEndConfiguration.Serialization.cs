// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FrontEndConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static FrontEndConfiguration DeserializeFrontEndConfiguration(JsonElement element)
        {
            Optional<FrontEndServiceType> kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = property.Value.GetString().ToFrontEndServiceType();
                    continue;
                }
            }
            return new FrontEndConfiguration(Optional.ToNullable(kind));
        }
    }
}
