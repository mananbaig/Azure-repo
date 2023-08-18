// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupVaultSoftDeleteSettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Core.Optional.IsDefined(RetentionDurationInDays))
            {
                writer.WritePropertyName("retentionDurationInDays"u8);
                writer.WriteNumberValue(RetentionDurationInDays.Value);
            }
            writer.WriteEndObject();
        }

        internal static BackupVaultSoftDeleteSettings DeserializeBackupVaultSoftDeleteSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<BackupVaultSoftDeleteState> state = default;
            Core.Optional<double> retentionDurationInDays = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new BackupVaultSoftDeleteState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("retentionDurationInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionDurationInDays = property.Value.GetDouble();
                    continue;
                }
            }
            return new BackupVaultSoftDeleteSettings(Core.Optional.ToNullable(state), Core.Optional.ToNullable(retentionDurationInDays));
        }
    }
}
