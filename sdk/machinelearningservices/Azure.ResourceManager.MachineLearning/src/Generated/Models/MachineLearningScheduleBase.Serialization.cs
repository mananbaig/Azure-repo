// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningScheduleBase
    {
        internal static MachineLearningScheduleBase DeserializeMachineLearningScheduleBase(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> id = default;
            Core.Optional<MachineLearningScheduleProvisioningState> provisioningStatus = default;
            Core.Optional<MachineLearningScheduleStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatus = new MachineLearningScheduleProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MachineLearningScheduleStatus(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningScheduleBase(id.Value, Core.Optional.ToNullable(provisioningStatus), Core.Optional.ToNullable(status));
        }
    }
}
