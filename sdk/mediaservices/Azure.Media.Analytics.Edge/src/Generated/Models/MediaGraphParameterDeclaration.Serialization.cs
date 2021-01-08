// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.Analytics.Edge.Models
{
    public partial class MediaGraphParameterDeclaration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Default))
            {
                writer.WritePropertyName("default");
                writer.WriteStringValue(Default);
            }
            writer.WriteEndObject();
        }

        internal static MediaGraphParameterDeclaration DeserializeMediaGraphParameterDeclaration(JsonElement element)
        {
            string name = default;
            MediaGraphParameterType type = default;
            Optional<string> description = default;
            Optional<string> @default = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new MediaGraphParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("default"))
                {
                    @default = property.Value.GetString();
                    continue;
                }
            }
            return new MediaGraphParameterDeclaration(name, type, description.Value, @default.Value);
        }
    }
}
