// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesRegistrationAssignmentRegistrationProperties
    {
        internal static ManagedServicesRegistrationAssignmentRegistrationProperties DeserializeManagedServicesRegistrationAssignmentRegistrationProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> description = default;
            Core.Optional<IReadOnlyList<ManagedServicesAuthorization>> authorizations = default;
            Core.Optional<IReadOnlyList<ManagedServicesEligibleAuthorization>> eligibleAuthorizations = default;
            Core.Optional<string> registrationDefinitionName = default;
            Core.Optional<ManagedServicesProvisioningState> provisioningState = default;
            Core.Optional<Guid> manageeTenantId = default;
            Core.Optional<string> manageeTenantName = default;
            Core.Optional<Guid> managedByTenantId = default;
            Core.Optional<string> managedByTenantName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicesAuthorization> array = new List<ManagedServicesAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesAuthorization.DeserializeManagedServicesAuthorization(item));
                    }
                    authorizations = array;
                    continue;
                }
                if (property.NameEquals("eligibleAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicesEligibleAuthorization> array = new List<ManagedServicesEligibleAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesEligibleAuthorization.DeserializeManagedServicesEligibleAuthorization(item));
                    }
                    eligibleAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("registrationDefinitionName"u8))
                {
                    registrationDefinitionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ManagedServicesProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("manageeTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manageeTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("manageeTenantName"u8))
                {
                    manageeTenantName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedByTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedByTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("managedByTenantName"u8))
                {
                    managedByTenantName = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedServicesRegistrationAssignmentRegistrationProperties(description.Value, Core.Optional.ToList(authorizations), Core.Optional.ToList(eligibleAuthorizations), registrationDefinitionName.Value, Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(manageeTenantId), manageeTenantName.Value, Core.Optional.ToNullable(managedByTenantId), managedByTenantName.Value);
        }
    }
}
