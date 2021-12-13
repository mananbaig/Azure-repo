// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    public partial class ContactBasic : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Info))
            {
                writer.WritePropertyName("info");
                writer.WriteStringValue(Info);
            }
            writer.WriteEndObject();
        }

        internal static ContactBasic DeserializeContactBasic(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> info = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"))
                {
                    info = property.Value.GetString();
                    continue;
                }
            }
            return new ContactBasic(id.Value, info.Value);
        }
    }
}
