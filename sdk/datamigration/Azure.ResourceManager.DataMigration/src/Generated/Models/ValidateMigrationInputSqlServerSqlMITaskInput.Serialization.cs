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
    public partial class ValidateMigrationInputSqlServerSqlMITaskInput : IUtf8JsonSerializable, IModelJsonSerializable<ValidateMigrationInputSqlServerSqlMITaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ValidateMigrationInputSqlServerSqlMITaskInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ValidateMigrationInputSqlServerSqlMITaskInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceConnectionInfo"u8);
            if (SourceConnectionInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SqlConnectionInfo>)SourceConnectionInfo).Serialize(writer, options);
            }
            writer.WritePropertyName("targetConnectionInfo"u8);
            if (TargetConnectionInfo is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SqlConnectionInfo>)TargetConnectionInfo).Serialize(writer, options);
            }
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MigrateSqlServerSqlMIDatabaseInput>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(SelectedLogins))
            {
                writer.WritePropertyName("selectedLogins"u8);
                writer.WriteStartArray();
                foreach (var item in SelectedLogins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BackupFileShare))
            {
                writer.WritePropertyName("backupFileShare"u8);
                if (BackupFileShare is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FileShare>)BackupFileShare).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("backupBlobShare"u8);
            if (BackupBlobShare is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<BlobShare>)BackupBlobShare).Serialize(writer, options);
            }
            if (Optional.IsDefined(BackupMode))
            {
                writer.WritePropertyName("backupMode"u8);
                writer.WriteStringValue(BackupMode.Value.ToString());
            }
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

        internal static ValidateMigrationInputSqlServerSqlMITaskInput DeserializeValidateMigrationInputSqlServerSqlMITaskInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases = default;
            Optional<IList<string>> selectedLogins = default;
            Optional<FileShare> backupFileShare = default;
            BlobShare backupBlobShare = default;
            Optional<BackupMode> backupMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSqlServerSqlMIDatabaseInput> array = new List<MigrateSqlServerSqlMIDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlMIDatabaseInput.DeserializeMigrateSqlServerSqlMIDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("selectedLogins"u8))
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
                    selectedLogins = array;
                    continue;
                }
                if (property.NameEquals("backupFileShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFileShare = FileShare.DeserializeFileShare(property.Value);
                    continue;
                }
                if (property.NameEquals("backupBlobShare"u8))
                {
                    backupBlobShare = BlobShare.DeserializeBlobShare(property.Value);
                    continue;
                }
                if (property.NameEquals("backupMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupMode = new BackupMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ValidateMigrationInputSqlServerSqlMITaskInput(sourceConnectionInfo, targetConnectionInfo, selectedDatabases, Optional.ToList(selectedLogins), backupFileShare.Value, backupBlobShare, Optional.ToNullable(backupMode), rawData);
        }

        ValidateMigrationInputSqlServerSqlMITaskInput IModelJsonSerializable<ValidateMigrationInputSqlServerSqlMITaskInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeValidateMigrationInputSqlServerSqlMITaskInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ValidateMigrationInputSqlServerSqlMITaskInput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ValidateMigrationInputSqlServerSqlMITaskInput IModelSerializable<ValidateMigrationInputSqlServerSqlMITaskInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeValidateMigrationInputSqlServerSqlMITaskInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/> to convert. </param>
        public static implicit operator RequestContent(ValidateMigrationInputSqlServerSqlMITaskInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ValidateMigrationInputSqlServerSqlMITaskInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ValidateMigrationInputSqlServerSqlMITaskInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeValidateMigrationInputSqlServerSqlMITaskInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
