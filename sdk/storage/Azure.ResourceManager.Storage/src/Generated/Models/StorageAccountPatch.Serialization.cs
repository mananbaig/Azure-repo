// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountPatch : IUtf8JsonSerializable, IJsonModel<StorageAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageAccountPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
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
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomDomain))
            {
                writer.WritePropertyName("customDomain"u8);
                writer.WriteObjectValue(CustomDomain, options);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption, options);
            }
            if (Optional.IsDefined(SasPolicy))
            {
                writer.WritePropertyName("sasPolicy"u8);
                writer.WriteObjectValue(SasPolicy, options);
            }
            if (Optional.IsDefined(KeyPolicy))
            {
                writer.WritePropertyName("keyPolicy"u8);
                writer.WriteObjectValue(KeyPolicy, options);
            }
            if (Optional.IsDefined(AccessTier))
            {
                writer.WritePropertyName("accessTier"u8);
                writer.WriteStringValue(AccessTier.Value.ToSerialString());
            }
            if (Optional.IsDefined(AzureFilesIdentityBasedAuthentication))
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication"u8);
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication, options);
            }
            if (Optional.IsDefined(EnableHttpsTrafficOnly))
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly"u8);
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (Optional.IsDefined(IsSftpEnabled))
            {
                writer.WritePropertyName("isSftpEnabled"u8);
                writer.WriteBooleanValue(IsSftpEnabled.Value);
            }
            if (Optional.IsDefined(IsLocalUserEnabled))
            {
                writer.WritePropertyName("isLocalUserEnabled"u8);
                writer.WriteBooleanValue(IsLocalUserEnabled.Value);
            }
            if (Optional.IsDefined(IsExtendedGroupEnabled))
            {
                writer.WritePropertyName("enableExtendedGroups"u8);
                writer.WriteBooleanValue(IsExtendedGroupEnabled.Value);
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkAcls"u8);
                writer.WriteObjectValue(NetworkRuleSet, options);
            }
            if (Optional.IsDefined(LargeFileSharesState))
            {
                writer.WritePropertyName("largeFileSharesState"u8);
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (Optional.IsDefined(RoutingPreference))
            {
                writer.WritePropertyName("routingPreference"u8);
                writer.WriteObjectValue(RoutingPreference, options);
            }
            if (Optional.IsDefined(AllowBlobPublicAccess))
            {
                writer.WritePropertyName("allowBlobPublicAccess"u8);
                writer.WriteBooleanValue(AllowBlobPublicAccess.Value);
            }
            if (Optional.IsDefined(MinimumTlsVersion))
            {
                writer.WritePropertyName("minimumTlsVersion"u8);
                writer.WriteStringValue(MinimumTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(AllowSharedKeyAccess))
            {
                writer.WritePropertyName("allowSharedKeyAccess"u8);
                writer.WriteBooleanValue(AllowSharedKeyAccess.Value);
            }
            if (Optional.IsDefined(AllowCrossTenantReplication))
            {
                writer.WritePropertyName("allowCrossTenantReplication"u8);
                writer.WriteBooleanValue(AllowCrossTenantReplication.Value);
            }
            if (Optional.IsDefined(IsDefaultToOAuthAuthentication))
            {
                writer.WritePropertyName("defaultToOAuthAuthentication"u8);
                writer.WriteBooleanValue(IsDefaultToOAuthAuthentication.Value);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(ImmutableStorageWithVersioning))
            {
                writer.WritePropertyName("immutableStorageWithVersioning"u8);
                writer.WriteObjectValue(ImmutableStorageWithVersioning, options);
            }
            if (Optional.IsDefined(AllowedCopyScope))
            {
                writer.WritePropertyName("allowedCopyScope"u8);
                writer.WriteStringValue(AllowedCopyScope.Value.ToString());
            }
            if (Optional.IsDefined(DnsEndpointType))
            {
                writer.WritePropertyName("dnsEndpointType"u8);
                writer.WriteStringValue(DnsEndpointType.Value.ToString());
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        StorageAccountPatch IJsonModel<StorageAccountPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountPatch(document.RootElement, options);
        }

        internal static StorageAccountPatch DeserializeStorageAccountPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageSku sku = default;
            IDictionary<string, string> tags = default;
            ManagedServiceIdentity identity = default;
            StorageKind? kind = default;
            StorageCustomDomain customDomain = default;
            StorageAccountEncryption encryption = default;
            StorageAccountSasPolicy sasPolicy = default;
            StorageAccountKeyPolicy keyPolicy = default;
            StorageAccountAccessTier? accessTier = default;
            FilesIdentityBasedAuthentication azureFilesIdentityBasedAuthentication = default;
            bool? supportsHttpsTrafficOnly = default;
            bool? isSftpEnabled = default;
            bool? isLocalUserEnabled = default;
            bool? enableExtendedGroups = default;
            StorageAccountNetworkRuleSet networkAcls = default;
            LargeFileSharesState? largeFileSharesState = default;
            StorageRoutingPreference routingPreference = default;
            bool? allowBlobPublicAccess = default;
            StorageMinimumTlsVersion? minimumTlsVersion = default;
            bool? allowSharedKeyAccess = default;
            bool? allowCrossTenantReplication = default;
            bool? defaultToOAuthAuthentication = default;
            StoragePublicNetworkAccess? publicNetworkAccess = default;
            ImmutableStorageAccount immutableStorageWithVersioning = default;
            AllowedCopyScope? allowedCopyScope = default;
            StorageDnsEndpointType? dnsEndpointType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageSku.DeserializeStorageSku(property.Value, options);
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
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new StorageKind(property.Value.GetString());
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
                        if (property0.NameEquals("customDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            customDomain = StorageCustomDomain.DeserializeStorageCustomDomain(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = StorageAccountEncryption.DeserializeStorageAccountEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sasPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasPolicy = StorageAccountSasPolicy.DeserializeStorageAccountSasPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("keyPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyPolicy = StorageAccountKeyPolicy.DeserializeStorageAccountKeyPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("accessTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessTier = property0.Value.GetString().ToStorageAccountAccessTier();
                            continue;
                        }
                        if (property0.NameEquals("azureFilesIdentityBasedAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            azureFilesIdentityBasedAuthentication = FilesIdentityBasedAuthentication.DeserializeFilesIdentityBasedAuthentication(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("supportsHttpsTrafficOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsHttpsTrafficOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isSftpEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSftpEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isLocalUserEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isLocalUserEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableExtendedGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableExtendedGroups = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAcls = StorageAccountNetworkRuleSet.DeserializeStorageAccountNetworkRuleSet(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("largeFileSharesState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            largeFileSharesState = new LargeFileSharesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("routingPreference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingPreference = StorageRoutingPreference.DeserializeStorageRoutingPreference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("allowBlobPublicAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowBlobPublicAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersion = new StorageMinimumTlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("allowSharedKeyAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowSharedKeyAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("allowCrossTenantReplication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowCrossTenantReplication = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultToOAuthAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultToOAuthAuthentication = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new StoragePublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("immutableStorageWithVersioning"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            immutableStorageWithVersioning = ImmutableStorageAccount.DeserializeImmutableStorageAccount(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("allowedCopyScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowedCopyScope = new AllowedCopyScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dnsEndpointType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dnsEndpointType = new StorageDnsEndpointType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageAccountPatch(
                sku,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                identity,
                kind,
                customDomain,
                encryption,
                sasPolicy,
                keyPolicy,
                accessTier,
                azureFilesIdentityBasedAuthentication,
                supportsHttpsTrafficOnly,
                isSftpEnabled,
                isLocalUserEnabled,
                enableExtendedGroups,
                networkAcls,
                largeFileSharesState,
                routingPreference,
                allowBlobPublicAccess,
                minimumTlsVersion,
                allowSharedKeyAccess,
                allowCrossTenantReplication,
                defaultToOAuthAuthentication,
                publicNetworkAccess,
                immutableStorageWithVersioning,
                allowedCopyScope,
                dnsEndpointType,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageAccountPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountPatch)} does not support writing '{options.Format}' format.");
            }
        }

        StorageAccountPatch IPersistableModel<StorageAccountPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageAccountPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
