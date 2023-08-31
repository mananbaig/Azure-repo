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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ContinuousModeBackupPolicy : IUtf8JsonSerializable, IModelJsonSerializable<ContinuousModeBackupPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContinuousModeBackupPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContinuousModeBackupPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContinuousModeBackupPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ContinuousModeProperties))
            {
                writer.WritePropertyName("continuousModeProperties"u8);
                writer.WriteObjectValue(ContinuousModeProperties);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(BackupPolicyType.ToString());
            if (Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteObjectValue(MigrationState);
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

        internal static ContinuousModeBackupPolicy DeserializeContinuousModeBackupPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContinuousModeProperties> continuousModeProperties = default;
            BackupPolicyType type = default;
            Optional<BackupPolicyMigrationState> migrationState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("continuousModeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    continuousModeProperties = ContinuousModeProperties.DeserializeContinuousModeProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new BackupPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = BackupPolicyMigrationState.DeserializeBackupPolicyMigrationState(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContinuousModeBackupPolicy(type, migrationState.Value, continuousModeProperties.Value, rawData);
        }

        ContinuousModeBackupPolicy IModelJsonSerializable<ContinuousModeBackupPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContinuousModeBackupPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContinuousModeBackupPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContinuousModeBackupPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContinuousModeBackupPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContinuousModeBackupPolicy IModelSerializable<ContinuousModeBackupPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContinuousModeBackupPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContinuousModeBackupPolicy(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContinuousModeBackupPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContinuousModeBackupPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContinuousModeBackupPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
