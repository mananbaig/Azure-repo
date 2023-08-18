// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ClusterVersion))
            {
                writer.WritePropertyName("clusterVersion"u8);
                writer.WriteStringValue(ClusterVersion);
            }
            if (Core.Optional.IsDefined(ClusterHdpVersion))
            {
                writer.WritePropertyName("clusterHdpVersion"u8);
                writer.WriteStringValue(ClusterHdpVersion);
            }
            if (Core.Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Core.Optional.IsDefined(Tier))
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToString());
            }
            if (Core.Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId"u8);
                writer.WriteStringValue(ClusterId);
            }
            writer.WritePropertyName("clusterDefinition"u8);
            writer.WriteObjectValue(ClusterDefinition);
            if (Core.Optional.IsDefined(KafkaRestProperties))
            {
                writer.WritePropertyName("kafkaRestProperties"u8);
                writer.WriteObjectValue(KafkaRestProperties);
            }
            if (Core.Optional.IsDefined(SecurityProfile))
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (Core.Optional.IsDefined(ComputeProfile))
            {
                writer.WritePropertyName("computeProfile"u8);
                writer.WriteObjectValue(ComputeProfile);
            }
            if (Core.Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Core.Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Core.Optional.IsDefined(ClusterState))
            {
                writer.WritePropertyName("clusterState"u8);
                writer.WriteStringValue(ClusterState);
            }
            if (Core.Optional.IsDefined(QuotaInfo))
            {
                writer.WritePropertyName("quotaInfo"u8);
                writer.WriteObjectValue(QuotaInfo);
            }
            if (Core.Optional.IsCollectionDefined(Errors))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(ConnectivityEndpoints))
            {
                writer.WritePropertyName("connectivityEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectivityEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(DiskEncryptionProperties))
            {
                writer.WritePropertyName("diskEncryptionProperties"u8);
                writer.WriteObjectValue(DiskEncryptionProperties);
            }
            if (Core.Optional.IsDefined(EncryptionInTransitProperties))
            {
                writer.WritePropertyName("encryptionInTransitProperties"u8);
                writer.WriteObjectValue(EncryptionInTransitProperties);
            }
            if (Core.Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            if (Core.Optional.IsDefined(MinSupportedTlsVersion))
            {
                writer.WritePropertyName("minSupportedTlsVersion"u8);
                writer.WriteStringValue(MinSupportedTlsVersion);
            }
            if (Core.Optional.IsDefined(ExcludedServicesConfig))
            {
                writer.WritePropertyName("excludedServicesConfig"u8);
                writer.WriteObjectValue(ExcludedServicesConfig);
            }
            if (Core.Optional.IsDefined(NetworkProperties))
            {
                writer.WritePropertyName("networkProperties"u8);
                writer.WriteObjectValue(NetworkProperties);
            }
            if (Core.Optional.IsDefined(ComputeIsolationProperties))
            {
                writer.WritePropertyName("computeIsolationProperties"u8);
                writer.WriteObjectValue(ComputeIsolationProperties);
            }
            if (Core.Optional.IsCollectionDefined(PrivateLinkConfigurations))
            {
                writer.WritePropertyName("privateLinkConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateLinkConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static HDInsightClusterProperties DeserializeHDInsightClusterProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> clusterVersion = default;
            Core.Optional<string> clusterHdpVersion = default;
            Core.Optional<HDInsightOSType> osType = default;
            Core.Optional<HDInsightTier> tier = default;
            Core.Optional<string> clusterId = default;
            HDInsightClusterDefinition clusterDefinition = default;
            Core.Optional<KafkaRestProperties> kafkaRestProperties = default;
            Core.Optional<HDInsightSecurityProfile> securityProfile = default;
            Core.Optional<ComputeProfile> computeProfile = default;
            Core.Optional<HDInsightClusterProvisioningState> provisioningState = default;
            Core.Optional<DateTimeOffset> createdDate = default;
            Core.Optional<string> clusterState = default;
            Core.Optional<QuotaInfo> quotaInfo = default;
            Core.Optional<IList<ResponseError>> errors = default;
            Core.Optional<IList<ConnectivityEndpoint>> connectivityEndpoints = default;
            Core.Optional<HDInsightDiskEncryptionProperties> diskEncryptionProperties = default;
            Core.Optional<EncryptionInTransitProperties> encryptionInTransitProperties = default;
            Core.Optional<StorageProfile> storageProfile = default;
            Core.Optional<string> minSupportedTlsVersion = default;
            Core.Optional<ExcludedServicesConfig> excludedServicesConfig = default;
            Core.Optional<HDInsightClusterNetworkProperties> networkProperties = default;
            Core.Optional<HDInsightComputeIsolationProperties> computeIsolationProperties = default;
            Core.Optional<IList<HDInsightPrivateLinkConfiguration>> privateLinkConfigurations = default;
            Core.Optional<IReadOnlyList<HDInsightPrivateEndpointConnectionData>> privateEndpointConnections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterVersion"u8))
                {
                    clusterVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterHdpVersion"u8))
                {
                    clusterHdpVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = new HDInsightOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = new HDInsightTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clusterId"u8))
                {
                    clusterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterDefinition"u8))
                {
                    clusterDefinition = HDInsightClusterDefinition.DeserializeHDInsightClusterDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("kafkaRestProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kafkaRestProperties = KafkaRestProperties.DeserializeKafkaRestProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("securityProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityProfile = HDInsightSecurityProfile.DeserializeHDInsightSecurityProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("computeProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeProfile = ComputeProfile.DeserializeComputeProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new HDInsightClusterProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("clusterState"u8))
                {
                    clusterState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quotaInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quotaInfo = QuotaInfo.DeserializeQuotaInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("connectivityEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectivityEndpoint> array = new List<ConnectivityEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectivityEndpoint.DeserializeConnectivityEndpoint(item));
                    }
                    connectivityEndpoints = array;
                    continue;
                }
                if (property.NameEquals("diskEncryptionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionProperties = HDInsightDiskEncryptionProperties.DeserializeHDInsightDiskEncryptionProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("encryptionInTransitProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionInTransitProperties = EncryptionInTransitProperties.DeserializeEncryptionInTransitProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = StorageProfile.DeserializeStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("minSupportedTlsVersion"u8))
                {
                    minSupportedTlsVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludedServicesConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludedServicesConfig = ExcludedServicesConfig.DeserializeExcludedServicesConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("networkProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkProperties = HDInsightClusterNetworkProperties.DeserializeHDInsightClusterNetworkProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("computeIsolationProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    computeIsolationProperties = HDInsightComputeIsolationProperties.DeserializeHDInsightComputeIsolationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("privateLinkConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightPrivateLinkConfiguration> array = new List<HDInsightPrivateLinkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightPrivateLinkConfiguration.DeserializeHDInsightPrivateLinkConfiguration(item));
                    }
                    privateLinkConfigurations = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightPrivateEndpointConnectionData> array = new List<HDInsightPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightPrivateEndpointConnectionData.DeserializeHDInsightPrivateEndpointConnectionData(item));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
            }
            return new HDInsightClusterProperties(clusterVersion.Value, clusterHdpVersion.Value, Core.Optional.ToNullable(osType), Core.Optional.ToNullable(tier), clusterId.Value, clusterDefinition, kafkaRestProperties.Value, securityProfile.Value, computeProfile.Value, Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(createdDate), clusterState.Value, quotaInfo.Value, Core.Optional.ToList(errors), Core.Optional.ToList(connectivityEndpoints), diskEncryptionProperties.Value, encryptionInTransitProperties.Value, storageProfile.Value, minSupportedTlsVersion.Value, excludedServicesConfig.Value, networkProperties.Value, computeIsolationProperties.Value, Core.Optional.ToList(privateLinkConfigurations), Core.Optional.ToList(privateEndpointConnections));
        }
    }
}
