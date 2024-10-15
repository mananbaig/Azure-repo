// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    internal partial class SiteDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("siteId"u8);
            writer.WriteStringValue(SiteId);
            writer.WriteEndObject();
        }

        internal static SiteDetails DeserializeSiteDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string siteId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("siteId"u8))
                {
                    siteId = property.Value.GetString();
                    continue;
                }
            }
            return new SiteDetails(siteId);
        }
    }
}
