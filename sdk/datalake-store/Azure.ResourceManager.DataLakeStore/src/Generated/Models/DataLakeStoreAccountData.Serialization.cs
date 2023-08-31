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
using Azure.ResourceManager.DataLakeStore.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    public partial class DataLakeStoreAccountData : IUtf8JsonSerializable, IModelJsonSerializable<DataLakeStoreAccountData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataLakeStoreAccountData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataLakeStoreAccountData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
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

        internal static DataLakeStoreAccountData DeserializeDataLakeStoreAccountData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> accountId = default;
            Optional<DataLakeStoreAccountStatus> provisioningState = default;
            Optional<DataLakeStoreAccountState> state = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> endpoint = default;
            Optional<string> defaultGroup = default;
            Optional<DataLakeStoreAccountEncryptionConfig> encryptionConfig = default;
            Optional<DataLakeStoreEncryptionState> encryptionState = default;
            Optional<DataLakeStoreEncryptionProvisioningState> encryptionProvisioningState = default;
            Optional<IReadOnlyList<DataLakeStoreFirewallRuleData>> firewallRules = default;
            Optional<IReadOnlyList<DataLakeStoreVirtualNetworkRuleData>> virtualNetworkRules = default;
            Optional<DataLakeStoreFirewallState> firewallState = default;
            Optional<DataLakeStoreFirewallAllowAzureIPsState> firewallAllowAzureIPs = default;
            Optional<IReadOnlyList<DataLakeStoreTrustedIdProviderData>> trustedIdProviders = default;
            Optional<DataLakeStoreTrustedIdProviderState> trustedIdProviderState = default;
            Optional<DataLakeStoreCommitmentTierType> newTier = default;
            Optional<DataLakeStoreCommitmentTierType> currentTier = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("accountId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accountId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToDataLakeStoreAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToDataLakeStoreAccountState();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultGroup"u8))
                        {
                            defaultGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionConfig = DataLakeStoreAccountEncryptionConfig.DeserializeDataLakeStoreAccountEncryptionConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryptionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionState = property0.Value.GetString().ToDataLakeStoreEncryptionState();
                            continue;
                        }
                        if (property0.NameEquals("encryptionProvisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionProvisioningState = property0.Value.GetString().ToDataLakeStoreEncryptionProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreFirewallRuleData> array = new List<DataLakeStoreFirewallRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreFirewallRuleData.DeserializeDataLakeStoreFirewallRuleData(item));
                            }
                            firewallRules = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreVirtualNetworkRuleData> array = new List<DataLakeStoreVirtualNetworkRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreVirtualNetworkRuleData.DeserializeDataLakeStoreVirtualNetworkRuleData(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallState = property0.Value.GetString().ToDataLakeStoreFirewallState();
                            continue;
                        }
                        if (property0.NameEquals("firewallAllowAzureIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallAllowAzureIPs = property0.Value.GetString().ToDataLakeStoreFirewallAllowAzureIPsState();
                            continue;
                        }
                        if (property0.NameEquals("trustedIdProviders"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreTrustedIdProviderData> array = new List<DataLakeStoreTrustedIdProviderData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreTrustedIdProviderData.DeserializeDataLakeStoreTrustedIdProviderData(item));
                            }
                            trustedIdProviders = array;
                            continue;
                        }
                        if (property0.NameEquals("trustedIdProviderState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedIdProviderState = property0.Value.GetString().ToDataLakeStoreTrustedIdProviderState();
                            continue;
                        }
                        if (property0.NameEquals("newTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newTier = property0.Value.GetString().ToDataLakeStoreCommitmentTierType();
                            continue;
                        }
                        if (property0.NameEquals("currentTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentTier = property0.Value.GetString().ToDataLakeStoreCommitmentTierType();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataLakeStoreAccountData(id, name, type, systemData.Value, identity, Optional.ToNullable(accountId), Optional.ToNullable(provisioningState), Optional.ToNullable(state), Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), endpoint.Value, defaultGroup.Value, encryptionConfig.Value, Optional.ToNullable(encryptionState), Optional.ToNullable(encryptionProvisioningState), Optional.ToList(firewallRules), Optional.ToList(virtualNetworkRules), Optional.ToNullable(firewallState), Optional.ToNullable(firewallAllowAzureIPs), Optional.ToList(trustedIdProviders), Optional.ToNullable(trustedIdProviderState), Optional.ToNullable(newTier), Optional.ToNullable(currentTier), Optional.ToNullable(location), Optional.ToDictionary(tags), rawData);
        }

        DataLakeStoreAccountData IModelJsonSerializable<DataLakeStoreAccountData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreAccountData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataLakeStoreAccountData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataLakeStoreAccountData IModelSerializable<DataLakeStoreAccountData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataLakeStoreAccountData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataLakeStoreAccountData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataLakeStoreAccountData"/> to convert. </param>
        public static implicit operator RequestContent(DataLakeStoreAccountData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataLakeStoreAccountData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataLakeStoreAccountData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataLakeStoreAccountData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
