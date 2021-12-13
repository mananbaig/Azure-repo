// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Administration.Models
{
    public partial class AttributeRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(DnfCondition))
            {
                writer.WritePropertyName("dnfCondition");
                writer.WriteStartArray();
                foreach (var item in DnfCondition)
                {
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AttributeRule DeserializeAttributeRule(JsonElement element)
        {
            Optional<Kind> kind = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<IList<IList<AttributeMatcher>>> dnfCondition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kind = new Kind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnfCondition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IList<AttributeMatcher>> array = new List<IList<AttributeMatcher>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<AttributeMatcher> array0 = new List<AttributeMatcher>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(AttributeMatcher.DeserializeAttributeMatcher(item0));
                        }
                        array.Add(array0);
                    }
                    dnfCondition = array;
                    continue;
                }
            }
            return new AttributeRule(Optional.ToNullable(kind), id.Value, name.Value, Optional.ToList(dnfCondition));
        }
    }
}
