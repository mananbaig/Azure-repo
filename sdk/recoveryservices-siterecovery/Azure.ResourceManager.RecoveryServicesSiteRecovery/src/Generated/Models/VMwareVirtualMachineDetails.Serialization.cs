// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareVirtualMachineDetails
    {
        internal static VMwareVirtualMachineDetails DeserializeVMwareVirtualMachineDetails(JsonElement element)
        {
            Optional<string> agentGeneratedId = default;
            Optional<string> agentInstalled = default;
            Optional<string> osType = default;
            Optional<string> agentVersion = default;
            Optional<string> ipAddress = default;
            Optional<string> poweredOn = default;
            Optional<string> vCenterInfrastructureId = default;
            Optional<string> discoveryType = default;
            Optional<IReadOnlyList<InMageDiskDetails>> diskDetails = default;
            Optional<IReadOnlyList<HealthError>> validationErrors = default;
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentGeneratedId"))
                {
                    agentGeneratedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentInstalled"))
                {
                    agentInstalled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersion"))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poweredOn"))
                {
                    poweredOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCenterInfrastructureId"))
                {
                    vCenterInfrastructureId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discoveryType"))
                {
                    discoveryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskDetails"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<InMageDiskDetails> array = new List<InMageDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageDiskDetails.DeserializeInMageDiskDetails(item));
                    }
                    diskDetails = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HealthError> array = new List<HealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthError.DeserializeHealthError(item));
                    }
                    validationErrors = array;
                    continue;
                }
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new VMwareVirtualMachineDetails(instanceType, agentGeneratedId.Value, agentInstalled.Value, osType.Value, agentVersion.Value, ipAddress.Value, poweredOn.Value, vCenterInfrastructureId.Value, discoveryType.Value, Optional.ToList(diskDetails), Optional.ToList(validationErrors));
        }
    }
}
