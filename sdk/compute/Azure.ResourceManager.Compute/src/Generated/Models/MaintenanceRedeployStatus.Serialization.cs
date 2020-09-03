// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class MaintenanceRedeployStatus
    {
        internal static MaintenanceRedeployStatus DeserializeMaintenanceRedeployStatus(JsonElement element)
        {
            Optional<bool> isCustomerInitiatedMaintenanceAllowed = default;
            Optional<DateTimeOffset> preMaintenanceWindowStartTime = default;
            Optional<DateTimeOffset> preMaintenanceWindowEndTime = default;
            Optional<DateTimeOffset> maintenanceWindowStartTime = default;
            Optional<DateTimeOffset> maintenanceWindowEndTime = default;
            Optional<MaintenanceOperationResultCodeTypes> lastOperationResultCode = default;
            Optional<string> lastOperationMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isCustomerInitiatedMaintenanceAllowed"))
                {
                    isCustomerInitiatedMaintenanceAllowed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("preMaintenanceWindowStartTime"))
                {
                    preMaintenanceWindowStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("preMaintenanceWindowEndTime"))
                {
                    preMaintenanceWindowEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("maintenanceWindowStartTime"))
                {
                    maintenanceWindowStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("maintenanceWindowEndTime"))
                {
                    maintenanceWindowEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastOperationResultCode"))
                {
                    lastOperationResultCode = property.Value.GetString().ToMaintenanceOperationResultCodeTypes();
                    continue;
                }
                if (property.NameEquals("lastOperationMessage"))
                {
                    lastOperationMessage = property.Value.GetString();
                    continue;
                }
            }
            return new MaintenanceRedeployStatus(Optional.ToNullable(isCustomerInitiatedMaintenanceAllowed), Optional.ToNullable(preMaintenanceWindowStartTime), Optional.ToNullable(preMaintenanceWindowEndTime), Optional.ToNullable(maintenanceWindowStartTime), Optional.ToNullable(maintenanceWindowEndTime), Optional.ToNullable(lastOperationResultCode), lastOperationMessage.Value);
        }
    }
}
