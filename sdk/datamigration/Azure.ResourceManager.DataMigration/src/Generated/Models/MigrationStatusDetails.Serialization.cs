// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrationStatusDetails : IUtf8JsonSerializable, IModelJsonSerializable<MigrationStatusDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigrationStatusDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigrationStatusDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static MigrationStatusDetails DeserializeMigrationStatusDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> migrationState = default;
            Optional<SqlBackupSetInfo> fullBackupSetInfo = default;
            Optional<SqlBackupSetInfo> lastRestoredBackupSetInfo = default;
            Optional<IReadOnlyList<SqlBackupSetInfo>> activeBackupSets = default;
            Optional<IReadOnlyList<string>> invalidFiles = default;
            Optional<string> blobContainerName = default;
            Optional<bool> isFullBackupRestored = default;
            Optional<string> restoreBlockingReason = default;
            Optional<string> completeRestoreErrorMessage = default;
            Optional<IReadOnlyList<string>> fileUploadBlockingErrors = default;
            Optional<string> currentRestoringFilename = default;
            Optional<string> lastRestoredFilename = default;
            Optional<int> pendingLogBackupsCount = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("migrationState"u8))
                {
                    migrationState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fullBackupSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullBackupSetInfo = SqlBackupSetInfo.DeserializeSqlBackupSetInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("lastRestoredBackupSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRestoredBackupSetInfo = SqlBackupSetInfo.DeserializeSqlBackupSetInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("activeBackupSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlBackupSetInfo> array = new List<SqlBackupSetInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlBackupSetInfo.DeserializeSqlBackupSetInfo(item));
                    }
                    activeBackupSets = array;
                    continue;
                }
                if (property.NameEquals("invalidFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    invalidFiles = array;
                    continue;
                }
                if (property.NameEquals("blobContainerName"u8))
                {
                    blobContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isFullBackupRestored"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isFullBackupRestored = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("restoreBlockingReason"u8))
                {
                    restoreBlockingReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("completeRestoreErrorMessage"u8))
                {
                    completeRestoreErrorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileUploadBlockingErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fileUploadBlockingErrors = array;
                    continue;
                }
                if (property.NameEquals("currentRestoringFilename"u8))
                {
                    currentRestoringFilename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastRestoredFilename"u8))
                {
                    lastRestoredFilename = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pendingLogBackupsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingLogBackupsCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigrationStatusDetails(migrationState.Value, fullBackupSetInfo.Value, lastRestoredBackupSetInfo.Value, Optional.ToList(activeBackupSets), Optional.ToList(invalidFiles), blobContainerName.Value, Optional.ToNullable(isFullBackupRestored), restoreBlockingReason.Value, completeRestoreErrorMessage.Value, Optional.ToList(fileUploadBlockingErrors), currentRestoringFilename.Value, lastRestoredFilename.Value, Optional.ToNullable(pendingLogBackupsCount), rawData);
        }

        MigrationStatusDetails IModelJsonSerializable<MigrationStatusDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrationStatusDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigrationStatusDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigrationStatusDetails IModelSerializable<MigrationStatusDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigrationStatusDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigrationStatusDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigrationStatusDetails"/> to convert. </param>
        public static implicit operator RequestContent(MigrationStatusDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigrationStatusDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigrationStatusDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigrationStatusDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
