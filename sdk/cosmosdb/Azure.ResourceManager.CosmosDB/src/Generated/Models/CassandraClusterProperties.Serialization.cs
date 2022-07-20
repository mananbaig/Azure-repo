// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(RestoreFromBackupId))
            {
                writer.WritePropertyName("restoreFromBackupId");
                writer.WriteStringValue(RestoreFromBackupId);
            }
            if (Optional.IsDefined(DelegatedManagementSubnetId))
            {
                writer.WritePropertyName("delegatedManagementSubnetId");
                writer.WriteStringValue(DelegatedManagementSubnetId);
            }
            if (Optional.IsDefined(CassandraVersion))
            {
                writer.WritePropertyName("cassandraVersion");
                writer.WriteStringValue(CassandraVersion);
            }
            if (Optional.IsDefined(ClusterNameOverride))
            {
                writer.WritePropertyName("clusterNameOverride");
                writer.WriteStringValue(ClusterNameOverride);
            }
            if (Optional.IsDefined(AuthenticationMethod))
            {
                writer.WritePropertyName("authenticationMethod");
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
            }
            if (Optional.IsDefined(InitialCassandraAdminPassword))
            {
                writer.WritePropertyName("initialCassandraAdminPassword");
                writer.WriteStringValue(InitialCassandraAdminPassword);
            }
            if (Optional.IsDefined(PrometheusEndpoint))
            {
                writer.WritePropertyName("prometheusEndpoint");
                writer.WriteObjectValue(PrometheusEndpoint);
            }
            if (Optional.IsDefined(IsRepairEnabled))
            {
                writer.WritePropertyName("repairEnabled");
                writer.WriteBooleanValue(IsRepairEnabled.Value);
            }
            if (Optional.IsCollectionDefined(ClientCertificates))
            {
                writer.WritePropertyName("clientCertificates");
                writer.WriteStartArray();
                foreach (var item in ClientCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalGossipCertificates))
            {
                writer.WritePropertyName("externalGossipCertificates");
                writer.WriteStartArray();
                foreach (var item in ExternalGossipCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExternalSeedNodes))
            {
                writer.WritePropertyName("externalSeedNodes");
                writer.WriteStartArray();
                foreach (var item in ExternalSeedNodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HoursBetweenBackups))
            {
                writer.WritePropertyName("hoursBetweenBackups");
                writer.WriteNumberValue(HoursBetweenBackups.Value);
            }
            if (Optional.IsDefined(IsDeallocated))
            {
                writer.WritePropertyName("deallocated");
                writer.WriteBooleanValue(IsDeallocated.Value);
            }
            if (Optional.IsDefined(IsCassandraAuditLoggingEnabled))
            {
                writer.WritePropertyName("cassandraAuditLoggingEnabled");
                writer.WriteBooleanValue(IsCassandraAuditLoggingEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static CassandraClusterProperties DeserializeCassandraClusterProperties(JsonElement element)
        {
            Optional<CassandraProvisioningState> provisioningState = default;
            Optional<string> restoreFromBackupId = default;
            Optional<ResourceIdentifier> delegatedManagementSubnetId = default;
            Optional<string> cassandraVersion = default;
            Optional<string> clusterNameOverride = default;
            Optional<CassandraAuthenticationMethod> authenticationMethod = default;
            Optional<string> initialCassandraAdminPassword = default;
            Optional<CassandraDataCenterSeedNode> prometheusEndpoint = default;
            Optional<bool> repairEnabled = default;
            Optional<IList<CassandraCertificate>> clientCertificates = default;
            Optional<IList<CassandraCertificate>> externalGossipCertificates = default;
            Optional<IReadOnlyList<CassandraCertificate>> gossipCertificates = default;
            Optional<IList<CassandraDataCenterSeedNode>> externalSeedNodes = default;
            Optional<IReadOnlyList<CassandraDataCenterSeedNode>> seedNodes = default;
            Optional<int> hoursBetweenBackups = default;
            Optional<bool> deallocated = default;
            Optional<bool> cassandraAuditLoggingEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new CassandraProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreFromBackupId"))
                {
                    restoreFromBackupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delegatedManagementSubnetId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    delegatedManagementSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cassandraVersion"))
                {
                    cassandraVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterNameOverride"))
                {
                    clusterNameOverride = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authenticationMethod = new CassandraAuthenticationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialCassandraAdminPassword"))
                {
                    initialCassandraAdminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prometheusEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    prometheusEndpoint = CassandraDataCenterSeedNode.DeserializeCassandraDataCenterSeedNode(property.Value);
                    continue;
                }
                if (property.NameEquals("repairEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    repairEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("clientCertificates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraCertificate> array = new List<CassandraCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraCertificate.DeserializeCassandraCertificate(item));
                    }
                    clientCertificates = array;
                    continue;
                }
                if (property.NameEquals("externalGossipCertificates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraCertificate> array = new List<CassandraCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraCertificate.DeserializeCassandraCertificate(item));
                    }
                    externalGossipCertificates = array;
                    continue;
                }
                if (property.NameEquals("gossipCertificates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraCertificate> array = new List<CassandraCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraCertificate.DeserializeCassandraCertificate(item));
                    }
                    gossipCertificates = array;
                    continue;
                }
                if (property.NameEquals("externalSeedNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraDataCenterSeedNode> array = new List<CassandraDataCenterSeedNode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraDataCenterSeedNode.DeserializeCassandraDataCenterSeedNode(item));
                    }
                    externalSeedNodes = array;
                    continue;
                }
                if (property.NameEquals("seedNodes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraDataCenterSeedNode> array = new List<CassandraDataCenterSeedNode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraDataCenterSeedNode.DeserializeCassandraDataCenterSeedNode(item));
                    }
                    seedNodes = array;
                    continue;
                }
                if (property.NameEquals("hoursBetweenBackups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hoursBetweenBackups = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deallocated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deallocated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cassandraAuditLoggingEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cassandraAuditLoggingEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CassandraClusterProperties(Optional.ToNullable(provisioningState), restoreFromBackupId.Value, delegatedManagementSubnetId.Value, cassandraVersion.Value, clusterNameOverride.Value, Optional.ToNullable(authenticationMethod), initialCassandraAdminPassword.Value, prometheusEndpoint.Value, Optional.ToNullable(repairEnabled), Optional.ToList(clientCertificates), Optional.ToList(externalGossipCertificates), Optional.ToList(gossipCertificates), Optional.ToList(externalSeedNodes), Optional.ToList(seedNodes), Optional.ToNullable(hoursBetweenBackups), Optional.ToNullable(deallocated), Optional.ToNullable(cassandraAuditLoggingEnabled));
        }
    }
}
