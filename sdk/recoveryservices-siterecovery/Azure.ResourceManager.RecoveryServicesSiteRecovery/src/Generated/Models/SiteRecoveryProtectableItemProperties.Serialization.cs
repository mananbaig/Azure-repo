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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryProtectableItemProperties : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryProtectableItemProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryProtectableItemProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryProtectableItemProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryProtectableItemProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionStatus))
            {
                writer.WritePropertyName("protectionStatus"u8);
                writer.WriteStringValue(ProtectionStatus);
            }
            if (Optional.IsDefined(ReplicationProtectedItemId))
            {
                writer.WritePropertyName("replicationProtectedItemId"u8);
                writer.WriteStringValue(ReplicationProtectedItemId);
            }
            if (Optional.IsDefined(RecoveryServicesProviderId))
            {
                writer.WritePropertyName("recoveryServicesProviderId"u8);
                writer.WriteStringValue(RecoveryServicesProviderId);
            }
            if (Optional.IsCollectionDefined(ProtectionReadinessErrors))
            {
                writer.WritePropertyName("protectionReadinessErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectionReadinessErrors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedReplicationProviders))
            {
                writer.WritePropertyName("supportedReplicationProviders"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedReplicationProviders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CustomDetails))
            {
                writer.WritePropertyName("customDetails"u8);
                if (CustomDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryReplicationProviderSettings>)CustomDetails).Serialize(writer, options);
                }
            }
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

        internal static SiteRecoveryProtectableItemProperties DeserializeSiteRecoveryProtectableItemProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> friendlyName = default;
            Optional<string> protectionStatus = default;
            Optional<ResourceIdentifier> replicationProtectedItemId = default;
            Optional<ResourceIdentifier> recoveryServicesProviderId = default;
            Optional<IReadOnlyList<string>> protectionReadinessErrors = default;
            Optional<IReadOnlyList<string>> supportedReplicationProviders = default;
            Optional<SiteRecoveryReplicationProviderSettings> customDetails = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionStatus"u8))
                {
                    protectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationProtectedItemId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationProtectedItemId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryServicesProviderId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryServicesProviderId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectionReadinessErrors"u8))
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
                    protectionReadinessErrors = array;
                    continue;
                }
                if (property.NameEquals("supportedReplicationProviders"u8))
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
                    supportedReplicationProviders = array;
                    continue;
                }
                if (property.NameEquals("customDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDetails = SiteRecoveryReplicationProviderSettings.DeserializeSiteRecoveryReplicationProviderSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryProtectableItemProperties(friendlyName.Value, protectionStatus.Value, replicationProtectedItemId.Value, recoveryServicesProviderId.Value, Optional.ToList(protectionReadinessErrors), Optional.ToList(supportedReplicationProviders), customDetails.Value, serializedAdditionalRawData);
        }

        SiteRecoveryProtectableItemProperties IModelJsonSerializable<SiteRecoveryProtectableItemProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryProtectableItemProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryProtectableItemProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryProtectableItemProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryProtectableItemProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryProtectableItemProperties IModelSerializable<SiteRecoveryProtectableItemProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteRecoveryProtectableItemProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryProtectableItemProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryProtectableItemProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryProtectableItemProperties"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryProtectableItemProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryProtectableItemProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryProtectableItemProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryProtectableItemProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
