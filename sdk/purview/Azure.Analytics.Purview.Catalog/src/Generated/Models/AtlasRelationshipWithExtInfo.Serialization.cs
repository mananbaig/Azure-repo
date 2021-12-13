// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Catalog.Models
{
    public partial class AtlasRelationshipWithExtInfo
    {
        internal static AtlasRelationshipWithExtInfo DeserializeAtlasRelationshipWithExtInfo(JsonElement element)
        {
            Optional<IReadOnlyDictionary<string, AtlasEntityHeader>> referredEntities = default;
            Optional<AtlasRelationship> relationship = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("referredEntities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, AtlasEntityHeader> dictionary = new Dictionary<string, AtlasEntityHeader>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, AtlasEntityHeader.DeserializeAtlasEntityHeader(property0.Value));
                    }
                    referredEntities = dictionary;
                    continue;
                }
                if (property.NameEquals("relationship"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    relationship = AtlasRelationship.DeserializeAtlasRelationship(property.Value);
                    continue;
                }
            }
            return new AtlasRelationshipWithExtInfo(Optional.ToDictionary(referredEntities), relationship.Value);
        }
    }
}
