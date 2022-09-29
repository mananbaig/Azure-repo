// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class AzureWorkloadBackupRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BackupType))
            {
                writer.WritePropertyName("backupType");
                writer.WriteStringValue(BackupType.Value.ToString());
            }
            if (Optional.IsDefined(EnableCompression))
            {
                writer.WritePropertyName("enableCompression");
                writer.WriteBooleanValue(EnableCompression.Value);
            }
            if (Optional.IsDefined(RecoveryPointExpiryTimeInUTC))
            {
                writer.WritePropertyName("recoveryPointExpiryTimeInUTC");
                writer.WriteStringValue(RecoveryPointExpiryTimeInUTC.Value, "O");
            }
            writer.WritePropertyName("objectType");
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static AzureWorkloadBackupRequest DeserializeAzureWorkloadBackupRequest(JsonElement element)
        {
            Optional<BackupType> backupType = default;
            Optional<bool> enableCompression = default;
            Optional<DateTimeOffset> recoveryPointExpiryTimeInUTC = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backupType = new BackupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableCompression"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableCompression = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recoveryPointExpiryTimeInUTC"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recoveryPointExpiryTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new AzureWorkloadBackupRequest(objectType, Optional.ToNullable(backupType), Optional.ToNullable(enableCompression), Optional.ToNullable(recoveryPointExpiryTimeInUTC));
        }
    }
}
