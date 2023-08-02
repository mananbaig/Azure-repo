// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanGroupTaskDetails
    {
        internal static RecoveryPlanGroupTaskDetails DeserializeRecoveryPlanGroupTaskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "RecoveryPlanShutdownGroupTaskDetails": return RecoveryPlanShutdownGroupTaskDetails.DeserializeRecoveryPlanShutdownGroupTaskDetails(element);
                }
            }
            Optional<string> name = default;
            Optional<string> groupId = default;
            Optional<string> rpGroupType = default;
            string instanceType = "RecoveryPlanGroupTaskDetails";
            Optional<IReadOnlyList<AsrTask>> childTasks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rpGroupType"u8))
                {
                    rpGroupType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("childTasks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AsrTask> array = new List<AsrTask>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AsrTask.DeserializeAsrTask(item));
                    }
                    childTasks = array;
                    continue;
                }
            }
            return new RecoveryPlanGroupTaskDetails(instanceType, Optional.ToList(childTasks), name.Value, groupId.Value, rpGroupType.Value);
        }
    }
}
