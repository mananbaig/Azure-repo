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
using Azure.ResourceManager.DataLakeAnalytics.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeAnalytics
{
    public partial class DataLakeAnalyticsAccountData : IUtf8JsonSerializable, IModelJsonSerializable<DataLakeAnalyticsAccountData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataLakeAnalyticsAccountData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataLakeAnalyticsAccountData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(PublicDataLakeStoreAccounts))
            {
                writer.WritePropertyName("publicDataLakeStoreAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in PublicDataLakeStoreAccounts)
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
            if (Optional.IsDefined(NewTier))
            {
                writer.WritePropertyName("newTier"u8);
                writer.WriteStringValue(NewTier.Value.ToSerialString());
            }
            if (Optional.IsDefined(MaxJobCount))
            {
                writer.WritePropertyName("maxJobCount"u8);
                writer.WriteNumberValue(MaxJobCount.Value);
            }
            if (Optional.IsDefined(MaxDegreeOfParallelism))
            {
                writer.WritePropertyName("maxDegreeOfParallelism"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelism.Value);
            }
            if (Optional.IsDefined(MaxDegreeOfParallelismPerJob))
            {
                writer.WritePropertyName("maxDegreeOfParallelismPerJob"u8);
                writer.WriteNumberValue(MaxDegreeOfParallelismPerJob.Value);
            }
            if (Optional.IsDefined(QueryStoreRetention))
            {
                writer.WritePropertyName("queryStoreRetention"u8);
                writer.WriteNumberValue(QueryStoreRetention.Value);
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

        internal static DataLakeAnalyticsAccountData DeserializeDataLakeAnalyticsAccountData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> accountId = default;
            Optional<DataLakeAnalyticsAccountStatus> provisioningState = default;
            Optional<DataLakeAnalyticsAccountState> state = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> endpoint = default;
            Optional<string> defaultDataLakeStoreAccount = default;
            Optional<IReadOnlyList<DataLakeStoreAccountInformationData>> dataLakeStoreAccounts = default;
            Optional<IReadOnlyList<DataLakeStoreAccountInformationData>> publicDataLakeStoreAccounts = default;
            Optional<IReadOnlyList<DataLakeAnalyticsStorageAccountInformationData>> storageAccounts = default;
            Optional<IReadOnlyList<DataLakeAnalyticsComputePolicyData>> computePolicies = default;
            Optional<IReadOnlyList<DataLakeAnalyticsHiveMetastore>> hiveMetastores = default;
            Optional<IReadOnlyList<DataLakeAnalyticsVirtualNetworkRule>> virtualNetworkRules = default;
            Optional<IReadOnlyList<DataLakeAnalyticsFirewallRuleData>> firewallRules = default;
            Optional<DataLakeAnalyticsFirewallState> firewallState = default;
            Optional<DataLakeAnalyticsFirewallAllowAzureIPsState> firewallAllowAzureIPs = default;
            Optional<DataLakeAnalyticsCommitmentTierType> newTier = default;
            Optional<DataLakeAnalyticsCommitmentTierType> currentTier = default;
            Optional<int> maxJobCount = default;
            Optional<int> maxActiveJobCountPerUser = default;
            Optional<int> maxQueuedJobCountPerUser = default;
            Optional<int> maxJobRunningTimeInMin = default;
            Optional<int> systemMaxJobCount = default;
            Optional<int> maxDegreeOfParallelism = default;
            Optional<int> systemMaxDegreeOfParallelism = default;
            Optional<int> maxDegreeOfParallelismPerJob = default;
            Optional<int> minPriorityPerJob = default;
            Optional<int> queryStoreRetention = default;
            Optional<DebugDataAccessLevel> debugDataAccessLevel = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                            provisioningState = property0.Value.GetString().ToDataLakeAnalyticsAccountStatus();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToDataLakeAnalyticsAccountState();
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
                        if (property0.NameEquals("defaultDataLakeStoreAccount"u8))
                        {
                            defaultDataLakeStoreAccount = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataLakeStoreAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreAccountInformationData> array = new List<DataLakeStoreAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(item));
                            }
                            dataLakeStoreAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("publicDataLakeStoreAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeStoreAccountInformationData> array = new List<DataLakeStoreAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeStoreAccountInformationData.DeserializeDataLakeStoreAccountInformationData(item));
                            }
                            publicDataLakeStoreAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("storageAccounts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsStorageAccountInformationData> array = new List<DataLakeAnalyticsStorageAccountInformationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsStorageAccountInformationData.DeserializeDataLakeAnalyticsStorageAccountInformationData(item));
                            }
                            storageAccounts = array;
                            continue;
                        }
                        if (property0.NameEquals("computePolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsComputePolicyData> array = new List<DataLakeAnalyticsComputePolicyData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsComputePolicyData.DeserializeDataLakeAnalyticsComputePolicyData(item));
                            }
                            computePolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("hiveMetastores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsHiveMetastore> array = new List<DataLakeAnalyticsHiveMetastore>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsHiveMetastore.DeserializeDataLakeAnalyticsHiveMetastore(item));
                            }
                            hiveMetastores = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsVirtualNetworkRule> array = new List<DataLakeAnalyticsVirtualNetworkRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsVirtualNetworkRule.DeserializeDataLakeAnalyticsVirtualNetworkRule(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLakeAnalyticsFirewallRuleData> array = new List<DataLakeAnalyticsFirewallRuleData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataLakeAnalyticsFirewallRuleData.DeserializeDataLakeAnalyticsFirewallRuleData(item));
                            }
                            firewallRules = array;
                            continue;
                        }
                        if (property0.NameEquals("firewallState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallState = property0.Value.GetString().ToDataLakeAnalyticsFirewallState();
                            continue;
                        }
                        if (property0.NameEquals("firewallAllowAzureIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallAllowAzureIPs = property0.Value.GetString().ToDataLakeAnalyticsFirewallAllowAzureIPsState();
                            continue;
                        }
                        if (property0.NameEquals("newTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newTier = property0.Value.GetString().ToDataLakeAnalyticsCommitmentTierType();
                            continue;
                        }
                        if (property0.NameEquals("currentTier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentTier = property0.Value.GetString().ToDataLakeAnalyticsCommitmentTierType();
                            continue;
                        }
                        if (property0.NameEquals("maxJobCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxJobCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxActiveJobCountPerUser"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxActiveJobCountPerUser = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxQueuedJobCountPerUser"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxQueuedJobCountPerUser = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxJobRunningTimeInMin"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxJobRunningTimeInMin = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("systemMaxJobCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemMaxJobCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelism"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDegreeOfParallelism = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("systemMaxDegreeOfParallelism"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemMaxDegreeOfParallelism = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxDegreeOfParallelismPerJob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDegreeOfParallelismPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("minPriorityPerJob"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minPriorityPerJob = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("queryStoreRetention"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryStoreRetention = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("debugDataAccessLevel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            debugDataAccessLevel = property0.Value.GetString().ToDebugDataAccessLevel();
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
            return new DataLakeAnalyticsAccountData(id, name, type, systemData.Value, Optional.ToNullable(accountId), Optional.ToNullable(provisioningState), Optional.ToNullable(state), Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), endpoint.Value, defaultDataLakeStoreAccount.Value, Optional.ToList(dataLakeStoreAccounts), Optional.ToList(publicDataLakeStoreAccounts), Optional.ToList(storageAccounts), Optional.ToList(computePolicies), Optional.ToList(hiveMetastores), Optional.ToList(virtualNetworkRules), Optional.ToList(firewallRules), Optional.ToNullable(firewallState), Optional.ToNullable(firewallAllowAzureIPs), Optional.ToNullable(newTier), Optional.ToNullable(currentTier), Optional.ToNullable(maxJobCount), Optional.ToNullable(maxActiveJobCountPerUser), Optional.ToNullable(maxQueuedJobCountPerUser), Optional.ToNullable(maxJobRunningTimeInMin), Optional.ToNullable(systemMaxJobCount), Optional.ToNullable(maxDegreeOfParallelism), Optional.ToNullable(systemMaxDegreeOfParallelism), Optional.ToNullable(maxDegreeOfParallelismPerJob), Optional.ToNullable(minPriorityPerJob), Optional.ToNullable(queryStoreRetention), Optional.ToNullable(debugDataAccessLevel), Optional.ToNullable(location), Optional.ToDictionary(tags), rawData);
        }

        DataLakeAnalyticsAccountData IModelJsonSerializable<DataLakeAnalyticsAccountData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataLakeAnalyticsAccountData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataLakeAnalyticsAccountData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataLakeAnalyticsAccountData IModelSerializable<DataLakeAnalyticsAccountData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataLakeAnalyticsAccountData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataLakeAnalyticsAccountData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataLakeAnalyticsAccountData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataLakeAnalyticsAccountData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
