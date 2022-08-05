// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automanage;

namespace Azure.ResourceManager.Automanage.Models
{
    internal partial class ServicePrincipalListResult
    {
        internal static ServicePrincipalListResult DeserializeServicePrincipalListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ServicePrincipalData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServicePrincipalData> array = new List<ServicePrincipalData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServicePrincipalData.DeserializeServicePrincipalData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ServicePrincipalListResult(Optional.ToList(value));
        }
    }
}
