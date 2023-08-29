// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DeletedDataProtectionBackupInstanceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            writer.WritePropertyName("dataSourceInfo"u8);
            writer.WriteObjectValue(DataSourceInfo);
            if (Optional.IsDefined(DataSourceSetInfo))
            {
                writer.WritePropertyName("dataSourceSetInfo"u8);
                writer.WriteObjectValue(DataSourceSetInfo);
            }
            writer.WritePropertyName("policyInfo"u8);
            writer.WriteObjectValue(PolicyInfo);
            if (Optional.IsDefined(DataSourceAuthCredentials))
            {
                writer.WritePropertyName("datasourceAuthCredentials"u8);
                writer.WriteObjectValue(DataSourceAuthCredentials);
            }
            if (Optional.IsDefined(ValidationType))
            {
                writer.WritePropertyName("validationType"u8);
                writer.WriteStringValue(ValidationType.Value.ToString());
            }
            if (Optional.IsDefined(IdentityDetails))
            {
                writer.WritePropertyName("identityDetails"u8);
                writer.WriteObjectValue(IdentityDetails);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static DeletedDataProtectionBackupInstanceProperties DeserializeDeletedDataProtectionBackupInstanceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BackupInstanceDeletionInfo> deletionInfo = default;
            Optional<string> friendlyName = default;
            DataSourceInfo dataSourceInfo = default;
            Optional<DataSourceSetInfo> dataSourceSetInfo = default;
            BackupInstancePolicyInfo policyInfo = default;
            Optional<BackupInstanceProtectionStatusDetails> protectionStatus = default;
            Optional<CurrentProtectionState> currentProtectionState = default;
            Optional<ResponseError> protectionErrorDetails = default;
            Optional<string> provisioningState = default;
            Optional<DataProtectionBackupAuthCredentials> datasourceAuthCredentials = default;
            Optional<BackupValidationType> validationType = default;
            Optional<IdentityDetails> identityDetails = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deletionInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionInfo = BackupInstanceDeletionInfo.DeserializeBackupInstanceDeletionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSourceInfo"u8))
                {
                    dataSourceInfo = DataSourceInfo.DeserializeDataSourceInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("dataSourceSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSourceSetInfo = DataSourceSetInfo.DeserializeDataSourceSetInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("policyInfo"u8))
                {
                    policyInfo = BackupInstancePolicyInfo.DeserializeBackupInstancePolicyInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionStatus = BackupInstanceProtectionStatusDetails.DeserializeBackupInstanceProtectionStatusDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("currentProtectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentProtectionState = new CurrentProtectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionErrorDetails = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasourceAuthCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasourceAuthCredentials = DataProtectionBackupAuthCredentials.DeserializeDataProtectionBackupAuthCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationType = new BackupValidationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identityDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityDetails = IdentityDetails.DeserializeIdentityDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new DeletedDataProtectionBackupInstanceProperties(friendlyName.Value, dataSourceInfo, dataSourceSetInfo.Value, policyInfo, protectionStatus.Value, Optional.ToNullable(currentProtectionState), protectionErrorDetails.Value, provisioningState.Value, datasourceAuthCredentials.Value, Optional.ToNullable(validationType), identityDetails.Value, objectType, deletionInfo.Value);
        }
    }
}
