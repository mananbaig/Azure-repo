// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiLicenseInformation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static ApiLicenseInformation DeserializeApiLicenseInformation(JsonElement element)
        {
            Optional<string> name = default;
            Optional<Uri> uri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new ApiLicenseInformation(name.Value, uri.Value);
        }
    }
}
