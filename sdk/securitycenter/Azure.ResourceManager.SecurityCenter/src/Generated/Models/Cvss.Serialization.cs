// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class Cvss
    {
        internal static Cvss DeserializeCvss(JsonElement element)
        {
            Optional<float> @base = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("base"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    @base = property.Value.GetSingle();
                    continue;
                }
            }
            return new Cvss(Optional.ToNullable(@base));
        }
    }
}
