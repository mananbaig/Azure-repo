// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class FieldDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEncrypted))
            {
                writer.WritePropertyName("isEncrypted");
                writer.WriteBooleanValue(IsEncrypted.Value);
            }
            if (Optional.IsDefined(IsOptional))
            {
                writer.WritePropertyName("isOptional");
                writer.WriteBooleanValue(IsOptional.Value);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(FieldDefinitionType);
            writer.WriteEndObject();
        }

        internal static FieldDefinition DeserializeFieldDefinition(JsonElement element)
        {
            Optional<bool> isEncrypted = default;
            Optional<bool> isOptional = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isEncrypted"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isOptional"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isOptional = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new FieldDefinition(Optional.ToNullable(isEncrypted), Optional.ToNullable(isOptional), type);
        }
    }
}
