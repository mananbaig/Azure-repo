// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    public partial class SuggestResultValue
    {
        internal static SuggestResultValue DeserializeSuggestResultValue(JsonElement element)
        {
            Optional<float> searchScore = default;
            Optional<string> searchText = default;
            Optional<string> description = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> owner = default;
            Optional<string> qualifiedName = default;
            Optional<string> entityType = default;
            Optional<IReadOnlyList<string>> classification = default;
            Optional<IReadOnlyList<string>> label = default;
            Optional<IReadOnlyList<TermSearchResultValue>> term = default;
            Optional<IReadOnlyList<ContactSearchResultValue>> contact = default;
            Optional<IReadOnlyList<string>> assetType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.score"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    searchScore = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("@search.text"))
                {
                    searchText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
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
                if (property.NameEquals("owner"))
                {
                    owner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityType"))
                {
                    entityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("classification"))
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
                    classification = array;
                    continue;
                }
                if (property.NameEquals("label"))
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
                    label = array;
                    continue;
                }
                if (property.NameEquals("term"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TermSearchResultValue> array = new List<TermSearchResultValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TermSearchResultValue.DeserializeTermSearchResultValue(item));
                    }
                    term = array;
                    continue;
                }
                if (property.NameEquals("contact"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ContactSearchResultValue> array = new List<ContactSearchResultValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContactSearchResultValue.DeserializeContactSearchResultValue(item));
                    }
                    contact = array;
                    continue;
                }
                if (property.NameEquals("assetType"))
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
                    assetType = array;
                    continue;
                }
            }
            return new SuggestResultValue(Optional.ToNullable(searchScore), searchText.Value, description.Value, id.Value, name.Value, owner.Value, qualifiedName.Value, entityType.Value, Optional.ToList(classification), Optional.ToList(label), Optional.ToList(term), Optional.ToList(contact), Optional.ToList(assetType));
        }
    }
}
