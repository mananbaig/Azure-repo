// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.SipRouting.Models
{
    public partial class TrunkRoute : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("numberPattern");
            writer.WriteStringValue(NumberPattern);
            if (Optional.IsCollectionDefined(Trunks))
            {
                writer.WritePropertyName("trunks");
                writer.WriteStartArray();
                foreach (var item in Trunks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static TrunkRoute DeserializeTrunkRoute(JsonElement element)
        {
            Optional<string> description = default;
            string name = default;
            string numberPattern = default;
            Optional<IList<string>> trunks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberPattern"))
                {
                    numberPattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trunks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    trunks = array;
                    continue;
                }
            }
            return new TrunkRoute(description.Value, name, numberPattern, Optional.ToList(trunks));
        }
    }
}
