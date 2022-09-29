// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFailbackReplicationDetails
    {
        internal static InMageRcmFailbackReplicationDetails DeserializeInMageRcmFailbackReplicationDetails(JsonElement element)
        {
            Optional<string> internalIdentifier = default;
            Optional<string> azureVirtualMachineId = default;
            Optional<string> multiVmGroupName = default;
            Optional<string> reprotectAgentId = default;
            Optional<string> reprotectAgentName = default;
            Optional<string> osType = default;
            Optional<string> logStorageAccountId = default;
            Optional<string> targetvCenterId = default;
            Optional<string> targetDataStoreName = default;
            Optional<string> targetVmName = default;
            Optional<int> initialReplicationProgressPercentage = default;
            Optional<long> initialReplicationProcessedBytes = default;
            Optional<long> initialReplicationTransferredBytes = default;
            Optional<VmReplicationProgressHealth> initialReplicationProgressHealth = default;
            Optional<int> resyncProgressPercentage = default;
            Optional<long> resyncProcessedBytes = default;
            Optional<long> resyncTransferredBytes = default;
            Optional<VmReplicationProgressHealth> resyncProgressHealth = default;
            Optional<string> resyncRequired = default;
            Optional<ResyncState> resyncState = default;
            Optional<IReadOnlyList<InMageRcmFailbackProtectedDiskDetails>> protectedDisks = default;
            Optional<InMageRcmFailbackMobilityAgentDetails> mobilityAgentDetails = default;
            Optional<IReadOnlyList<InMageRcmFailbackNicDetails>> vmNics = default;
            Optional<DateTimeOffset> lastPlannedFailoverStartTime = default;
            Optional<PlannedFailoverStatus> lastPlannedFailoverStatus = default;
            Optional<InMageRcmFailbackDiscoveredProtectedVmDetails> discoveredVmDetails = default;
            Optional<string> lastUsedPolicyId = default;
            Optional<string> lastUsedPolicyFriendlyName = default;
            Optional<bool> isAgentRegistrationSuccessfulAfterFailover = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("internalIdentifier"))
                {
                    internalIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureVirtualMachineId"))
                {
                    azureVirtualMachineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reprotectAgentId"))
                {
                    reprotectAgentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reprotectAgentName"))
                {
                    reprotectAgentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"))
                {
                    logStorageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetvCenterId"))
                {
                    targetvCenterId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDataStoreName"))
                {
                    targetDataStoreName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetVmName"))
                {
                    targetVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressPercentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialReplicationProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialReplicationProcessedBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialReplicationProcessedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initialReplicationTransferredBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialReplicationTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initialReplicationProgressHealth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialReplicationProgressHealth = new VmReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resyncProgressPercentage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resyncProgressPercentage = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resyncProcessedBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resyncProcessedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncTransferredBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resyncTransferredBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("resyncProgressHealth"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resyncProgressHealth = new VmReplicationProgressHealth(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resyncRequired"))
                {
                    resyncRequired = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resyncState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resyncState = new ResyncState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protectedDisks"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InMageRcmFailbackProtectedDiskDetails> array = new List<InMageRcmFailbackProtectedDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmFailbackProtectedDiskDetails.DeserializeInMageRcmFailbackProtectedDiskDetails(item));
                    }
                    protectedDisks = array;
                    continue;
                }
                if (property.NameEquals("mobilityAgentDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mobilityAgentDetails = InMageRcmFailbackMobilityAgentDetails.DeserializeInMageRcmFailbackMobilityAgentDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("vmNics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InMageRcmFailbackNicDetails> array = new List<InMageRcmFailbackNicDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageRcmFailbackNicDetails.DeserializeInMageRcmFailbackNicDetails(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("lastPlannedFailoverStartTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastPlannedFailoverStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastPlannedFailoverStatus"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastPlannedFailoverStatus = new PlannedFailoverStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("discoveredVmDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    discoveredVmDetails = InMageRcmFailbackDiscoveredProtectedVmDetails.DeserializeInMageRcmFailbackDiscoveredProtectedVmDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUsedPolicyId"))
                {
                    lastUsedPolicyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUsedPolicyFriendlyName"))
                {
                    lastUsedPolicyFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAgentRegistrationSuccessfulAfterFailover"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isAgentRegistrationSuccessfulAfterFailover = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new InMageRcmFailbackReplicationDetails(instanceType, internalIdentifier.Value, azureVirtualMachineId.Value, multiVmGroupName.Value, reprotectAgentId.Value, reprotectAgentName.Value, osType.Value, logStorageAccountId.Value, targetvCenterId.Value, targetDataStoreName.Value, targetVmName.Value, Optional.ToNullable(initialReplicationProgressPercentage), Optional.ToNullable(initialReplicationProcessedBytes), Optional.ToNullable(initialReplicationTransferredBytes), Optional.ToNullable(initialReplicationProgressHealth), Optional.ToNullable(resyncProgressPercentage), Optional.ToNullable(resyncProcessedBytes), Optional.ToNullable(resyncTransferredBytes), Optional.ToNullable(resyncProgressHealth), resyncRequired.Value, Optional.ToNullable(resyncState), Optional.ToList(protectedDisks), mobilityAgentDetails.Value, Optional.ToList(vmNics), Optional.ToNullable(lastPlannedFailoverStartTime), Optional.ToNullable(lastPlannedFailoverStatus), discoveredVmDetails.Value, lastUsedPolicyId.Value, lastUsedPolicyFriendlyName.Value, Optional.ToNullable(isAgentRegistrationSuccessfulAfterFailover));
        }
    }
}
