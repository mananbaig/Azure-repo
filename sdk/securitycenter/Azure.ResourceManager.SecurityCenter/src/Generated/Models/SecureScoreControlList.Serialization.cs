// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class SecureScoreControlList
    {
        internal static SecureScoreControlList DeserializeSecureScoreControlList(JsonElement element)
        {
            Optional<IReadOnlyList<SecureScoreControlDetails>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SecureScoreControlDetails> array = new List<SecureScoreControlDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecureScoreControlDetails.DeserializeSecureScoreControlDetails(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SecureScoreControlList(Optional.ToList(value), nextLink.Value);
        }
    }
}
