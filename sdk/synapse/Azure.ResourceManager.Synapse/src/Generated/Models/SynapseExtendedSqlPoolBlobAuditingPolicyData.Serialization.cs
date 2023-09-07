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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseExtendedSqlPoolBlobAuditingPolicyData : IUtf8JsonSerializable, IModelJsonSerializable<SynapseExtendedSqlPoolBlobAuditingPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseExtendedSqlPoolBlobAuditingPolicyData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseExtendedSqlPoolBlobAuditingPolicyData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseExtendedSqlPoolBlobAuditingPolicyData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PredicateExpression))
            {
                writer.WritePropertyName("predicateExpression"u8);
                writer.WriteStringValue(PredicateExpression);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StorageEndpoint))
            {
                writer.WritePropertyName("storageEndpoint"u8);
                writer.WriteStringValue(StorageEndpoint);
            }
            if (Optional.IsDefined(StorageAccountAccessKey))
            {
                writer.WritePropertyName("storageAccountAccessKey"u8);
                writer.WriteStringValue(StorageAccountAccessKey);
            }
            if (Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays"u8);
                writer.WriteNumberValue(RetentionDays.Value);
            }
            if (Optional.IsCollectionDefined(AuditActionsAndGroups))
            {
                writer.WritePropertyName("auditActionsAndGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AuditActionsAndGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StorageAccountSubscriptionId))
            {
                writer.WritePropertyName("storageAccountSubscriptionId"u8);
                writer.WriteStringValue(StorageAccountSubscriptionId.Value);
            }
            if (Optional.IsDefined(IsStorageSecondaryKeyInUse))
            {
                writer.WritePropertyName("isStorageSecondaryKeyInUse"u8);
                writer.WriteBooleanValue(IsStorageSecondaryKeyInUse.Value);
            }
            if (Optional.IsDefined(IsAzureMonitorTargetEnabled))
            {
                writer.WritePropertyName("isAzureMonitorTargetEnabled"u8);
                writer.WriteBooleanValue(IsAzureMonitorTargetEnabled.Value);
            }
            if (Optional.IsDefined(QueueDelayMs))
            {
                writer.WritePropertyName("queueDelayMs"u8);
                writer.WriteNumberValue(QueueDelayMs.Value);
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

        internal static SynapseExtendedSqlPoolBlobAuditingPolicyData DeserializeSynapseExtendedSqlPoolBlobAuditingPolicyData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> predicateExpression = default;
            Optional<SynapseBlobAuditingPolicyState> state = default;
            Optional<string> storageEndpoint = default;
            Optional<string> storageAccountAccessKey = default;
            Optional<int> retentionDays = default;
            Optional<IList<string>> auditActionsAndGroups = default;
            Optional<Guid> storageAccountSubscriptionId = default;
            Optional<bool> isStorageSecondaryKeyInUse = default;
            Optional<bool> isAzureMonitorTargetEnabled = default;
            Optional<int> queueDelayMs = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("predicateExpression"u8))
                        {
                            predicateExpression = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToSynapseBlobAuditingPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("storageEndpoint"u8))
                        {
                            storageEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountAccessKey"u8))
                        {
                            storageAccountAccessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("retentionDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("auditActionsAndGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            auditActionsAndGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAccountSubscriptionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountSubscriptionId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("isStorageSecondaryKeyInUse"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isStorageSecondaryKeyInUse = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAzureMonitorTargetEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAzureMonitorTargetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("queueDelayMs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queueDelayMs = property0.Value.GetInt32();
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
            return new SynapseExtendedSqlPoolBlobAuditingPolicyData(id, name, type, systemData.Value, predicateExpression.Value, Optional.ToNullable(state), storageEndpoint.Value, storageAccountAccessKey.Value, Optional.ToNullable(retentionDays), Optional.ToList(auditActionsAndGroups), Optional.ToNullable(storageAccountSubscriptionId), Optional.ToNullable(isStorageSecondaryKeyInUse), Optional.ToNullable(isAzureMonitorTargetEnabled), Optional.ToNullable(queueDelayMs), serializedAdditionalRawData);
        }

        SynapseExtendedSqlPoolBlobAuditingPolicyData IModelJsonSerializable<SynapseExtendedSqlPoolBlobAuditingPolicyData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseExtendedSqlPoolBlobAuditingPolicyData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseExtendedSqlPoolBlobAuditingPolicyData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseExtendedSqlPoolBlobAuditingPolicyData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseExtendedSqlPoolBlobAuditingPolicyData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseExtendedSqlPoolBlobAuditingPolicyData IModelSerializable<SynapseExtendedSqlPoolBlobAuditingPolicyData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseExtendedSqlPoolBlobAuditingPolicyData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseExtendedSqlPoolBlobAuditingPolicyData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseExtendedSqlPoolBlobAuditingPolicyData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseExtendedSqlPoolBlobAuditingPolicyData"/> to convert. </param>
        public static implicit operator RequestContent(SynapseExtendedSqlPoolBlobAuditingPolicyData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseExtendedSqlPoolBlobAuditingPolicyData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseExtendedSqlPoolBlobAuditingPolicyData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseExtendedSqlPoolBlobAuditingPolicyData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
