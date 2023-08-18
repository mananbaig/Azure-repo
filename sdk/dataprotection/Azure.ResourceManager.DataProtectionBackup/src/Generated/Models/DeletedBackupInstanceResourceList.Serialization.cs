// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class DeletedBackupInstanceResourceList
    {
        internal static DeletedBackupInstanceResourceList DeserializeDeletedBackupInstanceResourceList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DeletedDataProtectionBackupInstanceData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeletedDataProtectionBackupInstanceData> array = new List<DeletedDataProtectionBackupInstanceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeletedDataProtectionBackupInstanceData.DeserializeDeletedDataProtectionBackupInstanceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DeletedBackupInstanceResourceList(nextLink.Value, Core.Optional.ToList(value));
        }
    }
}
