// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class AutoUserSpecification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope.Value.ToSerialString());
            }
            if (Optional.IsDefined(ElevationLevel))
            {
                writer.WritePropertyName("elevationLevel"u8);
                writer.WriteStringValue(ElevationLevel.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static AutoUserSpecification DeserializeAutoUserSpecification(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AutoUserScope> scope = default;
            Optional<ElevationLevel> elevationLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = property.Value.GetString().ToAutoUserScope();
                    continue;
                }
                if (property.NameEquals("elevationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elevationLevel = property.Value.GetString().ToElevationLevel();
                    continue;
                }
            }
            return new AutoUserSpecification(Optional.ToNullable(scope), Optional.ToNullable(elevationLevel));
        }
    }
}
