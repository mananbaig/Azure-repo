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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SyncGroupData : IUtf8JsonSerializable, IModelJsonSerializable<SyncGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SyncGroupData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SyncGroupData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SyncGroupData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SqlSku>)Sku).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Interval))
            {
                writer.WritePropertyName("interval"u8);
                writer.WriteNumberValue(Interval.Value);
            }
            if (Optional.IsDefined(ConflictResolutionPolicy))
            {
                writer.WritePropertyName("conflictResolutionPolicy"u8);
                writer.WriteStringValue(ConflictResolutionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SyncDatabaseId))
            {
                writer.WritePropertyName("syncDatabaseId"u8);
                writer.WriteStringValue(SyncDatabaseId);
            }
            if (Optional.IsDefined(HubDatabaseUserName))
            {
                writer.WritePropertyName("hubDatabaseUserName"u8);
                writer.WriteStringValue(HubDatabaseUserName);
            }
            if (Optional.IsDefined(HubDatabasePassword))
            {
                writer.WritePropertyName("hubDatabasePassword"u8);
                writer.WriteStringValue(HubDatabasePassword);
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                if (Schema is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SyncGroupSchema>)Schema).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(IsConflictLoggingEnabled))
            {
                writer.WritePropertyName("enableConflictLogging"u8);
                writer.WriteBooleanValue(IsConflictLoggingEnabled.Value);
            }
            if (Optional.IsDefined(ConflictLoggingRetentionInDays))
            {
                writer.WritePropertyName("conflictLoggingRetentionInDays"u8);
                writer.WriteNumberValue(ConflictLoggingRetentionInDays.Value);
            }
            if (Optional.IsDefined(UsePrivateLinkConnection))
            {
                writer.WritePropertyName("usePrivateLinkConnection"u8);
                writer.WriteBooleanValue(UsePrivateLinkConnection.Value);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static SyncGroupData DeserializeSyncGroupData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlSku> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> interval = default;
            Optional<DateTimeOffset> lastSyncTime = default;
            Optional<SyncConflictResolutionPolicy> conflictResolutionPolicy = default;
            Optional<ResourceIdentifier> syncDatabaseId = default;
            Optional<string> hubDatabaseUserName = default;
            Optional<string> hubDatabasePassword = default;
            Optional<SyncGroupState> syncState = default;
            Optional<SyncGroupSchema> schema = default;
            Optional<bool> enableConflictLogging = default;
            Optional<int> conflictLoggingRetentionInDays = default;
            Optional<bool> usePrivateLinkConnection = default;
            Optional<string> privateEndpointName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("interval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            interval = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("lastSyncTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSyncTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("conflictResolutionPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            conflictResolutionPolicy = new SyncConflictResolutionPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("syncDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("hubDatabaseUserName"u8))
                        {
                            hubDatabaseUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hubDatabasePassword"u8))
                        {
                            hubDatabasePassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("syncState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncState = new SyncGroupState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("schema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            schema = SyncGroupSchema.DeserializeSyncGroupSchema(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableConflictLogging"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableConflictLogging = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("conflictLoggingRetentionInDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            conflictLoggingRetentionInDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("usePrivateLinkConnection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePrivateLinkConnection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointName"u8))
                        {
                            privateEndpointName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SyncGroupData(id, name, type, systemData.Value, sku.Value, Optional.ToNullable(interval), Optional.ToNullable(lastSyncTime), Optional.ToNullable(conflictResolutionPolicy), syncDatabaseId.Value, hubDatabaseUserName.Value, hubDatabasePassword.Value, Optional.ToNullable(syncState), schema.Value, Optional.ToNullable(enableConflictLogging), Optional.ToNullable(conflictLoggingRetentionInDays), Optional.ToNullable(usePrivateLinkConnection), privateEndpointName.Value, serializedAdditionalRawData);
        }

        SyncGroupData IModelJsonSerializable<SyncGroupData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SyncGroupData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSyncGroupData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SyncGroupData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SyncGroupData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SyncGroupData IModelSerializable<SyncGroupData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SyncGroupData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSyncGroupData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SyncGroupData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SyncGroupData"/> to convert. </param>
        public static implicit operator RequestContent(SyncGroupData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SyncGroupData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SyncGroupData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSyncGroupData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
