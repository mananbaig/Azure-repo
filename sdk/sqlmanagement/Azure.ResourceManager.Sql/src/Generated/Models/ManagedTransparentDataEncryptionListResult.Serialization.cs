// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ManagedTransparentDataEncryptionListResult
    {
        internal static ManagedTransparentDataEncryptionListResult DeserializeManagedTransparentDataEncryptionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ManagedTransparentDataEncryption>> value = default;
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
                    List<ManagedTransparentDataEncryption> array = new List<ManagedTransparentDataEncryption>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedTransparentDataEncryption.DeserializeManagedTransparentDataEncryption(item));
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
            return new ManagedTransparentDataEncryptionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
