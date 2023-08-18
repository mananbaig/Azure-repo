// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    internal partial class IotFhirDestinationCollection
    {
        internal static IotFhirDestinationCollection DeserializeIotFhirDestinationCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            Core.Optional<IReadOnlyList<HealthcareApisIotFhirDestinationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HealthcareApisIotFhirDestinationData> array = new List<HealthcareApisIotFhirDestinationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareApisIotFhirDestinationData.DeserializeHealthcareApisIotFhirDestinationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new IotFhirDestinationCollection(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
