// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureFilesIdentityBasedAuthentication))
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication");
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (Optional.IsDefined(EnableHttpsTrafficOnly))
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly");
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (Optional.IsDefined(IsHnsEnabled))
            {
                writer.WritePropertyName("isHnsEnabled");
                writer.WriteBooleanValue(IsHnsEnabled.Value);
            }
            if (Optional.IsDefined(LargeFileSharesState))
            {
                writer.WritePropertyName("largeFileSharesState");
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (Optional.IsDefined(RoutingPreference))
            {
                writer.WritePropertyName("routingPreference");
                writer.WriteObjectValue(RoutingPreference);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageAccount DeserializeStorageAccount(JsonElement element)
        {
            Optional<Sku> sku = default;
            Optional<Kind> kind = default;
            Optional<Identity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            string location = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<Endpoints> primaryEndpoints = default;
            Optional<string> primaryLocation = default;
            Optional<AccountStatus> statusOfPrimary = default;
            Optional<DateTimeOffset> lastGeoFailoverTime = default;
            Optional<string> secondaryLocation = default;
            Optional<AccountStatus> statusOfSecondary = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<CustomDomain> customDomain = default;
            Optional<Endpoints> secondaryEndpoints = default;
            Optional<Encryption> encryption = default;
            Optional<AccessTier> accessTier = default;
            Optional<AzureFilesIdentityBasedAuthentication> azureFilesIdentityBasedAuthentication = default;
            Optional<bool> supportsHttpsTrafficOnly = default;
            Optional<NetworkRuleSet> networkAcls = default;
            Optional<bool> isHnsEnabled = default;
            Optional<GeoReplicationStats> geoReplicationStats = default;
            Optional<bool> failoverInProgress = default;
            Optional<LargeFileSharesState> largeFileSharesState = default;
            Optional<IReadOnlyList<PrivateEndpointConnection>> privateEndpointConnections = default;
            Optional<RoutingPreference> routingPreference = default;
            Optional<BlobRestoreStatus> blobRestoreStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new Kind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = Identity.DeserializeIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString().ToProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("primaryEndpoints"))
                        {
                            primaryEndpoints = Endpoints.DeserializeEndpoints(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("primaryLocation"))
                        {
                            primaryLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statusOfPrimary"))
                        {
                            statusOfPrimary = property0.Value.GetString().ToAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("lastGeoFailoverTime"))
                        {
                            lastGeoFailoverTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("secondaryLocation"))
                        {
                            secondaryLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("statusOfSecondary"))
                        {
                            statusOfSecondary = property0.Value.GetString().ToAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"))
                        {
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("customDomain"))
                        {
                            customDomain = CustomDomain.DeserializeCustomDomain(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("secondaryEndpoints"))
                        {
                            secondaryEndpoints = Endpoints.DeserializeEndpoints(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryption"))
                        {
                            encryption = Encryption.DeserializeEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("accessTier"))
                        {
                            accessTier = property0.Value.GetString().ToAccessTier();
                            continue;
                        }
                        if (property0.NameEquals("azureFilesIdentityBasedAuthentication"))
                        {
                            azureFilesIdentityBasedAuthentication = AzureFilesIdentityBasedAuthentication.DeserializeAzureFilesIdentityBasedAuthentication(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("supportsHttpsTrafficOnly"))
                        {
                            supportsHttpsTrafficOnly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("networkAcls"))
                        {
                            networkAcls = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isHnsEnabled"))
                        {
                            isHnsEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("geoReplicationStats"))
                        {
                            geoReplicationStats = GeoReplicationStats.DeserializeGeoReplicationStats(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("failoverInProgress"))
                        {
                            failoverInProgress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("largeFileSharesState"))
                        {
                            largeFileSharesState = new LargeFileSharesState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            List<PrivateEndpointConnection> array = new List<PrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointConnection.DeserializePrivateEndpointConnection(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("routingPreference"))
                        {
                            routingPreference = RoutingPreference.DeserializeRoutingPreference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("blobRestoreStatus"))
                        {
                            blobRestoreStatus = BlobRestoreStatus.DeserializeBlobRestoreStatus(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageAccount(id.Value, name.Value, type.Value, Optional.ToDictionary(tags), location, sku.Value, Optional.ToNullable(kind), identity.Value, Optional.ToNullable(provisioningState), primaryEndpoints.Value, primaryLocation.Value, Optional.ToNullable(statusOfPrimary), Optional.ToNullable(lastGeoFailoverTime), secondaryLocation.Value, Optional.ToNullable(statusOfSecondary), Optional.ToNullable(creationTime), customDomain.Value, secondaryEndpoints.Value, encryption.Value, Optional.ToNullable(accessTier), azureFilesIdentityBasedAuthentication.Value, Optional.ToNullable(supportsHttpsTrafficOnly), networkAcls.Value, Optional.ToNullable(isHnsEnabled), geoReplicationStats.Value, Optional.ToNullable(failoverInProgress), Optional.ToNullable(largeFileSharesState), Optional.ToList(privateEndpointConnections), routingPreference.Value, blobRestoreStatus.Value);
        }
    }
}
