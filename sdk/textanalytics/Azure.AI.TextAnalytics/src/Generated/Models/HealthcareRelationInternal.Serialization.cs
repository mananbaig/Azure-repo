// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    internal partial class HealthcareRelationInternal
    {
        internal static HealthcareRelationInternal DeserializeHealthcareRelationInternal(JsonElement element)
        {
            RelationType relationType = default;
            IReadOnlyList<HealthcareRelationEntity> entities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relationType"))
                {
                    relationType = new RelationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("entities"))
                {
                    List<HealthcareRelationEntity> array = new List<HealthcareRelationEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareRelationEntity.DeserializeHealthcareRelationEntity(item));
                    }
                    entities = array;
                    continue;
                }
            }
            return new HealthcareRelationInternal(relationType, entities);
        }
    }
}
