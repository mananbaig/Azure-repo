// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class ApiKeyAuthentication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("in");
            writer.WriteStringValue(In.ToSerialString());
            writer.WritePropertyName("value");
            writer.WriteStringValue(Value);
            writer.WritePropertyName("type");
            writer.WriteStringValue(AuthType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static ApiKeyAuthentication DeserializeApiKeyAuthentication(JsonElement element)
        {
            string name = default;
            RestAuthLocation @in = default;
            string value = default;
            RestAuthType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("in"))
                {
                    @in = property.Value.GetString().ToRestAuthLocation();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToRestAuthType();
                    continue;
                }
            }
            return new ApiKeyAuthentication(type, name, @in, value);
        }
    }
}
