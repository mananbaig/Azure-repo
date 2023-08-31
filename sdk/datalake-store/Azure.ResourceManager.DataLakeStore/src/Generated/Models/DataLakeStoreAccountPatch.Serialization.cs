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

namespace Azure.ResourceManager.DataLakeStore.Models
{
    public partial class DataLakeStoreAccountPatch : IUtf8JsonSerializable, IModelJsonSerializable<DataLakeStoreAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataLakeStoreAccountPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataLakeStoreAccountPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultGroup))
            {
                writer.WritePropertyName("defaultGroup"u8);
                writer.WriteStringValue(DefaultGroup);
            }
            if (Optional.IsDefined(EncryptionConfig))
            {
                writer.WritePropertyName("encryptionConfig"u8);
                writer.WriteObjectValue(EncryptionConfig);
            }
            if (Optional.IsCollectionDefined(FirewallRules))
            {
                writer.WritePropertyName("firewallRules"u8);
                writer.WriteStartArray();
                foreach (var item in FirewallRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FirewallState))
            {
                writer.WritePropertyName("firewallState"u8);
                writer.WriteStringValue(FirewallState.Value.ToSerialString());
            }
            if (Optional.IsDefined(FirewallAllowAzureIPs))
            {
                writer.WritePropertyName("firewallAllowAzureIps"u8);
                writer.WriteStringValue(FirewallAllowAzureIPs.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(TrustedIdProviders))
            {
                writer.WritePropertyName("trustedIdProviders"u8);
                writer.WriteStartArray();
                foreach (var item in TrustedIdProviders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TrustedIdProviderState))
            {
                writer.WritePropertyName("trustedIdProviderState"u8);
                writer.WriteStringValue(TrustedIdProviderState.Value.ToSerialString());
            }
            if (Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier"u8);
                writer.WriteStringValue(NewTier.Value.ToSerialString());
            }
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

        internal static DataLakeStoreAccountPatch DeserializeDataLakeStoreAccountPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> defaultGroup = default;
            Optional<UpdateEncryptionConfig> encryptionConfig = default;
            Optional<IList<FirewallRuleForDataLakeStoreAccountUpdateContent>> firewallRules = default;
            Optional<IList<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent>> virtualNetworkRules = default;
            Optional<DataLakeStoreFirewallState> firewallState = default;
            Optional<DataLakeStoreFirewallAllowAzureIPsState> firewallAllowAzureIPs = default;
            Optional<IList<TrustedIdProviderForDataLakeStoreAccountUpdateContent>> trustedIdProviders = default;
            Optional<DataLakeStoreTrustedIdProviderState> trustedIdProviderState = default;
            Optional<DataLakeStoreCommitmentTierType> newTier = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
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
                            encryptionConfig = UpdateEncryptionConfig.DeserializeUpdateEncryptionConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FirewallRuleForDataLakeStoreAccountUpdateContent> array = new List<FirewallRuleForDataLakeStoreAccountUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FirewallRuleForDataLakeStoreAccountUpdateContent.DeserializeFirewallRuleForDataLakeStoreAccountUpdateContent(item));
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
                            List<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent> array = new List<VirtualNetworkRuleForDataLakeStoreAccountUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkRuleForDataLakeStoreAccountUpdateContent.DeserializeVirtualNetworkRuleForDataLakeStoreAccountUpdateContent(item));
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
                            List<TrustedIdProviderForDataLakeStoreAccountUpdateContent> array = new List<TrustedIdProviderForDataLakeStoreAccountUpdateContent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TrustedIdProviderForDataLakeStoreAccountUpdateContent.DeserializeTrustedIdProviderForDataLakeStoreAccountUpdateContent(item));
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
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataLakeStoreAccountPatch(Optional.ToDictionary(tags), defaultGroup.Value, encryptionConfig.Value, Optional.ToList(firewallRules), Optional.ToList(virtualNetworkRules), Optional.ToNullable(firewallState), Optional.ToNullable(firewallAllowAzureIPs), Optional.ToList(trustedIdProviders), Optional.ToNullable(trustedIdProviderState), Optional.ToNullable(newTier), rawData);
        }

        DataLakeStoreAccountPatch IModelJsonSerializable<DataLakeStoreAccountPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeStoreAccountPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataLakeStoreAccountPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataLakeStoreAccountPatch IModelSerializable<DataLakeStoreAccountPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataLakeStoreAccountPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataLakeStoreAccountPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataLakeStoreAccountPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataLakeStoreAccountPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
