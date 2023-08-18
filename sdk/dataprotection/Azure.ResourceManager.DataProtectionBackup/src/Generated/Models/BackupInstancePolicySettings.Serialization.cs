// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class BackupInstancePolicySettings : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(DataStoreParametersList))
            {
                writer.WritePropertyName("dataStoreParametersList"u8);
                writer.WriteStartArray();
                foreach (var item in DataStoreParametersList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(BackupDataSourceParametersList))
            {
                writer.WritePropertyName("backupDatasourceParametersList"u8);
                writer.WriteStartArray();
                foreach (var item in BackupDataSourceParametersList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static BackupInstancePolicySettings DeserializeBackupInstancePolicySettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<DataStoreSettings>> dataStoreParametersList = default;
            Core.Optional<IList<BackupDataSourceSettings>> backupDatasourceParametersList = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataStoreParametersList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataStoreSettings> array = new List<DataStoreSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataStoreSettings.DeserializeDataStoreSettings(item));
                    }
                    dataStoreParametersList = array;
                    continue;
                }
                if (property.NameEquals("backupDatasourceParametersList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupDataSourceSettings> array = new List<BackupDataSourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupDataSourceSettings.DeserializeBackupDataSourceSettings(item));
                    }
                    backupDatasourceParametersList = array;
                    continue;
                }
            }
            return new BackupInstancePolicySettings(Core.Optional.ToList(dataStoreParametersList), Core.Optional.ToList(backupDatasourceParametersList));
        }
    }
}
