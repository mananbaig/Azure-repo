// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceEncryptionProtectorListResult
    {
        internal static ManagedInstanceEncryptionProtectorListResult DeserializeManagedInstanceEncryptionProtectorListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ManagedInstanceEncryptionProtector>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ManagedInstanceEncryptionProtector> array = new List<ManagedInstanceEncryptionProtector>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceEncryptionProtector.DeserializeManagedInstanceEncryptionProtector(item));
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
            return new ManagedInstanceEncryptionProtectorListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
