// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class ClientAuthenticationSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(AlternativeAuthenticationNameSources))
            {
                writer.WritePropertyName("alternativeAuthenticationNameSources"u8);
                writer.WriteStartArray();
                foreach (var item in AlternativeAuthenticationNameSources)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ClientAuthenticationSettings DeserializeClientAuthenticationSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<AlternativeAuthenticationNameSource>> alternativeAuthenticationNameSources = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alternativeAuthenticationNameSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlternativeAuthenticationNameSource> array = new List<AlternativeAuthenticationNameSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AlternativeAuthenticationNameSource(item.GetString()));
                    }
                    alternativeAuthenticationNameSources = array;
                    continue;
                }
            }
            return new ClientAuthenticationSettings(Core.Optional.ToList(alternativeAuthenticationNameSources));
        }
    }
}
