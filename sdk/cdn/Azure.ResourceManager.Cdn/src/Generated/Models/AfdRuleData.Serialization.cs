// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    public partial class AfdRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order");
                writer.WriteNumberValue(Order.Value);
            }
            if (Optional.IsCollectionDefined(Conditions))
            {
                writer.WritePropertyName("conditions");
                writer.WriteStartArray();
                foreach (var item in Conditions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions");
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MatchProcessingBehavior))
            {
                writer.WritePropertyName("matchProcessingBehavior");
                writer.WriteStringValue(MatchProcessingBehavior.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AfdRuleData DeserializeAfdRuleData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            SystemData systemData = default;
            Optional<string> ruleSetName = default;
            Optional<int> order = default;
            Optional<IList<DeliveryRuleCondition>> conditions = default;
            Optional<IList<DeliveryRuleAction>> actions = default;
            Optional<MatchProcessingBehavior> matchProcessingBehavior = default;
            Optional<AfdProvisioningState> provisioningState = default;
            Optional<DeploymentStatus> deploymentStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = (Core.ResourceType)property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("ruleSetName"))
                        {
                            ruleSetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("order"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            order = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("conditions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DeliveryRuleCondition> array = new List<DeliveryRuleCondition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeliveryRuleCondition.DeserializeDeliveryRuleCondition(item));
                            }
                            conditions = array;
                            continue;
                        }
                        if (property0.NameEquals("actions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<DeliveryRuleAction> array = new List<DeliveryRuleAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeliveryRuleAction.DeserializeDeliveryRuleAction(item));
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("matchProcessingBehavior"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            matchProcessingBehavior = new MatchProcessingBehavior(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new AfdProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deploymentStatus = new DeploymentStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AfdRuleData(id, name, type, systemData, ruleSetName.Value, Optional.ToNullable(order), Optional.ToList(conditions), Optional.ToList(actions), Optional.ToNullable(matchProcessingBehavior), Optional.ToNullable(provisioningState), Optional.ToNullable(deploymentStatus));
        }
    }
}
