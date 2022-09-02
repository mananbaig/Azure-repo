// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeBackupDetail
    {
        internal static NetAppVolumeBackupDetail DeserializeNetAppVolumeBackupDetail(JsonElement element)
        {
            Optional<string> volumeName = default;
            Optional<int> backupsCount = default;
            Optional<bool> policyEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeName"))
                {
                    volumeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("policyEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policyEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new NetAppVolumeBackupDetail(volumeName.Value, Optional.ToNullable(backupsCount), Optional.ToNullable(policyEnabled));
        }
    }
}
