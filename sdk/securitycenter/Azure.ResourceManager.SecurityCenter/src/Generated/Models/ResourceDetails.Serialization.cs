// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class ResourceDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("source");
            writer.WriteStringValue(Source.ToString());
            writer.WriteEndObject();
        }

        internal static ResourceDetails DeserializeResourceDetails(JsonElement element)
        {
            if (element.TryGetProperty("source", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Azure": return AzureResourceDetails.DeserializeAzureResourceDetails(element);
                    case "OnPremise": return OnPremiseResourceDetails.DeserializeOnPremiseResourceDetails(element);
                    case "OnPremiseSql": return OnPremiseSqlResourceDetails.DeserializeOnPremiseSqlResourceDetails(element);
                }
            }
            Source source = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"))
                {
                    source = new Source(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownResourceDetails(source);
        }
    }
}
