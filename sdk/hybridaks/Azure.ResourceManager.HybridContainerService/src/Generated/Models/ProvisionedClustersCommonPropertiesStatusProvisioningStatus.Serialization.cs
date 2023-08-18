// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class ProvisionedClustersCommonPropertiesStatusProvisioningStatus
    {
        internal static ProvisionedClustersCommonPropertiesStatusProvisioningStatus DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ProvisionedClustersCommonPropertiesStatusProvisioningStatusError> error = default;
            Core.Optional<string> operationId = default;
            Core.Optional<string> phase = default;
            Core.Optional<string> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = ProvisionedClustersCommonPropertiesStatusProvisioningStatusError.DeserializeProvisionedClustersCommonPropertiesStatusProvisioningStatusError(property.Value);
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("phase"u8))
                {
                    phase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new ProvisionedClustersCommonPropertiesStatusProvisioningStatus(error.Value, operationId.Value, phase.Value, status.Value);
        }
    }
}
