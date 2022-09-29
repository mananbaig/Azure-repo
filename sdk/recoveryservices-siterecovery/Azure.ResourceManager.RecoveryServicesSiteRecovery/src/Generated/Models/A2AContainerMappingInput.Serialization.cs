// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AContainerMappingInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AgentAutoUpdateStatus))
            {
                writer.WritePropertyName("agentAutoUpdateStatus");
                writer.WriteStringValue(AgentAutoUpdateStatus.Value.ToString());
            }
            if (Optional.IsDefined(AutomationAccountArmId))
            {
                writer.WritePropertyName("automationAccountArmId");
                writer.WriteStringValue(AutomationAccountArmId);
            }
            if (Optional.IsDefined(AutomationAccountAuthenticationType))
            {
                writer.WritePropertyName("automationAccountAuthenticationType");
                writer.WriteStringValue(AutomationAccountAuthenticationType.Value.ToString());
            }
            writer.WritePropertyName("instanceType");
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
