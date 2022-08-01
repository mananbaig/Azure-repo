// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppMajorVersion
    {
        internal static FunctionAppMajorVersion DeserializeFunctionAppMajorVersion(JsonElement element)
        {
            Optional<string> displayText = default;
            Optional<string> value = default;
            Optional<IReadOnlyList<FunctionAppMinorVersion>> minorVersions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minorVersions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FunctionAppMinorVersion> array = new List<FunctionAppMinorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FunctionAppMinorVersion.DeserializeFunctionAppMinorVersion(item));
                    }
                    minorVersions = array;
                    continue;
                }
            }
            return new FunctionAppMajorVersion(displayText.Value, value.Value, Optional.ToList(minorVersions));
        }
    }
}
