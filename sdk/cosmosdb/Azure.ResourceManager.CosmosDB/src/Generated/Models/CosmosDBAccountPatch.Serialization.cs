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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountPatch : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBAccountPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBAccountPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBAccountPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
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
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConsistencyPolicy))
            {
                writer.WritePropertyName("consistencyPolicy"u8);
                writer.WriteObjectValue(ConsistencyPolicy);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsVirtualNetworkFilterEnabled))
            {
                writer.WritePropertyName("isVirtualNetworkFilterEnabled"u8);
                writer.WriteBooleanValue(IsVirtualNetworkFilterEnabled.Value);
            }
            if (Optional.IsDefined(EnableAutomaticFailover))
            {
                writer.WritePropertyName("enableAutomaticFailover"u8);
                writer.WriteBooleanValue(EnableAutomaticFailover.Value);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
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
            if (Optional.IsDefined(EnableMultipleWriteLocations))
            {
                writer.WritePropertyName("enableMultipleWriteLocations"u8);
                writer.WriteBooleanValue(EnableMultipleWriteLocations.Value);
            }
            if (Optional.IsDefined(EnableCassandraConnector))
            {
                writer.WritePropertyName("enableCassandraConnector"u8);
                writer.WriteBooleanValue(EnableCassandraConnector.Value);
            }
            if (Optional.IsDefined(ConnectorOffer))
            {
                writer.WritePropertyName("connectorOffer"u8);
                writer.WriteStringValue(ConnectorOffer.Value.ToString());
            }
            if (Optional.IsDefined(DisableKeyBasedMetadataWriteAccess))
            {
                writer.WritePropertyName("disableKeyBasedMetadataWriteAccess"u8);
                writer.WriteBooleanValue(DisableKeyBasedMetadataWriteAccess.Value);
            }
            if (Optional.IsDefined(KeyVaultKeyUri))
            {
                writer.WritePropertyName("keyVaultKeyUri"u8);
                writer.WriteStringValue(KeyVaultKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DefaultIdentity))
            {
                writer.WritePropertyName("defaultIdentity"u8);
                writer.WriteStringValue(DefaultIdentity);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(IsFreeTierEnabled))
            {
                writer.WritePropertyName("enableFreeTier"u8);
                writer.WriteBooleanValue(IsFreeTierEnabled.Value);
            }
            if (Optional.IsDefined(ApiProperties))
            {
                writer.WritePropertyName("apiProperties"u8);
                writer.WriteObjectValue(ApiProperties);
            }
            if (Optional.IsDefined(IsAnalyticalStorageEnabled))
            {
                writer.WritePropertyName("enableAnalyticalStorage"u8);
                writer.WriteBooleanValue(IsAnalyticalStorageEnabled.Value);
            }
            if (Optional.IsDefined(AnalyticalStorageConfiguration))
            {
                writer.WritePropertyName("analyticalStorageConfiguration"u8);
                writer.WriteObjectValue(AnalyticalStorageConfiguration);
            }
            if (Optional.IsDefined(BackupPolicy))
            {
                writer.WritePropertyName("backupPolicy"u8);
                writer.WriteObjectValue(BackupPolicy);
            }
            if (Optional.IsCollectionDefined(Cors))
            {
                writer.WritePropertyName("cors"u8);
                writer.WriteStartArray();
                foreach (var item in Cors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NetworkAclBypass))
            {
                writer.WritePropertyName("networkAclBypass"u8);
                writer.WriteStringValue(NetworkAclBypass.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(NetworkAclBypassResourceIds))
            {
                writer.WritePropertyName("networkAclBypassResourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkAclBypassResourceIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DiagnosticLogSettings))
            {
                writer.WritePropertyName("diagnosticLogSettings"u8);
                writer.WriteObjectValue(DiagnosticLogSettings);
            }
            if (Optional.IsDefined(DisableLocalAuth))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
            }
            if (Optional.IsDefined(EnableMaterializedViews))
            {
                writer.WritePropertyName("enableMaterializedViews"u8);
                writer.WriteBooleanValue(EnableMaterializedViews.Value);
            }
            if (Optional.IsDefined(EnablePartitionMerge))
            {
                writer.WritePropertyName("enablePartitionMerge"u8);
                writer.WriteBooleanValue(EnablePartitionMerge.Value);
            }
            if (Optional.IsDefined(EnableBurstCapacity))
            {
                writer.WritePropertyName("enableBurstCapacity"u8);
                writer.WriteBooleanValue(EnableBurstCapacity.Value);
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion.Value.ToString());
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

        internal static CosmosDBAccountPatch DeserializeCosmosDBAccountPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<AzureLocation> location = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ConsistencyPolicy> consistencyPolicy = default;
            Optional<IList<CosmosDBAccountLocation>> locations = default;
            Optional<IList<CosmosDBIPAddressOrRange>> ipRules = default;
            Optional<bool> isVirtualNetworkFilterEnabled = default;
            Optional<bool> enableAutomaticFailover = default;
            Optional<IList<CosmosDBAccountCapability>> capabilities = default;
            Optional<IList<CosmosDBVirtualNetworkRule>> virtualNetworkRules = default;
            Optional<bool> enableMultipleWriteLocations = default;
            Optional<bool> enableCassandraConnector = default;
            Optional<ConnectorOffer> connectorOffer = default;
            Optional<bool> disableKeyBasedMetadataWriteAccess = default;
            Optional<Uri> keyVaultKeyUri = default;
            Optional<string> defaultIdentity = default;
            Optional<CosmosDBPublicNetworkAccess> publicNetworkAccess = default;
            Optional<bool> enableFreeTier = default;
            Optional<ApiProperties> apiProperties = default;
            Optional<bool> enableAnalyticalStorage = default;
            Optional<AnalyticalStorageConfiguration> analyticalStorageConfiguration = default;
            Optional<CosmosDBAccountBackupPolicy> backupPolicy = default;
            Optional<IList<CosmosDBAccountCorsPolicy>> cors = default;
            Optional<NetworkAclBypass> networkAclBypass = default;
            Optional<IList<ResourceIdentifier>> networkAclBypassResourceIds = default;
            Optional<DiagnosticLogSettings> diagnosticLogSettings = default;
            Optional<bool> disableLocalAuth = default;
            Optional<CosmosDBAccountCapacity> capacity = default;
            Optional<bool> enableMaterializedViews = default;
            Optional<DatabaseAccountKeysMetadata> keysMetadata = default;
            Optional<bool> enablePartitionMerge = default;
            Optional<bool> enableBurstCapacity = default;
            Optional<CosmosDBMinimalTlsVersion> minimalTlsVersion = default;
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
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("consistencyPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            consistencyPolicy = ConsistencyPolicy.DeserializeConsistencyPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("locations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBAccountLocation> array = new List<CosmosDBAccountLocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountLocation.DeserializeCosmosDBAccountLocation(item));
                            }
                            locations = array;
                            continue;
                        }
                        if (property0.NameEquals("ipRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBIPAddressOrRange> array = new List<CosmosDBIPAddressOrRange>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBIPAddressOrRange.DeserializeCosmosDBIPAddressOrRange(item));
                            }
                            ipRules = array;
                            continue;
                        }
                        if (property0.NameEquals("isVirtualNetworkFilterEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isVirtualNetworkFilterEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAutomaticFailover"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAutomaticFailover = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("capabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBAccountCapability> array = new List<CosmosDBAccountCapability>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountCapability.DeserializeCosmosDBAccountCapability(item));
                            }
                            capabilities = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBVirtualNetworkRule> array = new List<CosmosDBVirtualNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBVirtualNetworkRule.DeserializeCosmosDBVirtualNetworkRule(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("enableMultipleWriteLocations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableMultipleWriteLocations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableCassandraConnector"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableCassandraConnector = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("connectorOffer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectorOffer = new ConnectorOffer(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disableKeyBasedMetadataWriteAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableKeyBasedMetadataWriteAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultKeyUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultKeyUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("defaultIdentity"u8))
                        {
                            defaultIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new CosmosDBPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enableFreeTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableFreeTier = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiProperties = ApiProperties.DeserializeApiProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableAnalyticalStorage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAnalyticalStorage = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("analyticalStorageConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            analyticalStorageConfiguration = AnalyticalStorageConfiguration.DeserializeAnalyticalStorageConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backupPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backupPolicy = CosmosDBAccountBackupPolicy.DeserializeCosmosDBAccountBackupPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("cors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CosmosDBAccountCorsPolicy> array = new List<CosmosDBAccountCorsPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CosmosDBAccountCorsPolicy.DeserializeCosmosDBAccountCorsPolicy(item));
                            }
                            cors = array;
                            continue;
                        }
                        if (property0.NameEquals("networkAclBypass"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAclBypass = property0.Value.GetString().ToNetworkAclBypass();
                            continue;
                        }
                        if (property0.NameEquals("networkAclBypassResourceIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            networkAclBypassResourceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("diagnosticLogSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnosticLogSettings = DiagnosticLogSettings.DeserializeDiagnosticLogSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("capacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacity = CosmosDBAccountCapacity.DeserializeCosmosDBAccountCapacity(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enableMaterializedViews"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableMaterializedViews = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("keysMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keysMetadata = DatabaseAccountKeysMetadata.DeserializeDatabaseAccountKeysMetadata(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("enablePartitionMerge"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePartitionMerge = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableBurstCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBurstCapacity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("minimalTlsVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimalTlsVersion = new CosmosDBMinimalTlsVersion(property0.Value.GetString());
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
            return new CosmosDBAccountPatch(Optional.ToDictionary(tags), Optional.ToNullable(location), identity, consistencyPolicy.Value, Optional.ToList(locations), Optional.ToList(ipRules), Optional.ToNullable(isVirtualNetworkFilterEnabled), Optional.ToNullable(enableAutomaticFailover), Optional.ToList(capabilities), Optional.ToList(virtualNetworkRules), Optional.ToNullable(enableMultipleWriteLocations), Optional.ToNullable(enableCassandraConnector), Optional.ToNullable(connectorOffer), Optional.ToNullable(disableKeyBasedMetadataWriteAccess), keyVaultKeyUri.Value, defaultIdentity.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(enableFreeTier), apiProperties.Value, Optional.ToNullable(enableAnalyticalStorage), analyticalStorageConfiguration.Value, backupPolicy.Value, Optional.ToList(cors), Optional.ToNullable(networkAclBypass), Optional.ToList(networkAclBypassResourceIds), diagnosticLogSettings.Value, Optional.ToNullable(disableLocalAuth), capacity.Value, Optional.ToNullable(enableMaterializedViews), keysMetadata.Value, Optional.ToNullable(enablePartitionMerge), Optional.ToNullable(enableBurstCapacity), Optional.ToNullable(minimalTlsVersion), rawData);
        }

        CosmosDBAccountPatch IModelJsonSerializable<CosmosDBAccountPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBAccountPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBAccountPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBAccountPatch IModelSerializable<CosmosDBAccountPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBAccountPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CosmosDBAccountPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CosmosDBAccountPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBAccountPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
