// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class PropertyChangedConditionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConditionProperties))
            {
                writer.WritePropertyName("conditionProperties");
                writer.WriteObjectValue(ConditionProperties);
            }
            writer.WritePropertyName("conditionType");
            writer.WriteStringValue(ConditionType.ToString());
            writer.WriteEndObject();
        }

        internal static PropertyChangedConditionProperties DeserializePropertyChangedConditionProperties(JsonElement element)
        {
            Optional<AutomationRulePropertyValuesChangedCondition> conditionProperties = default;
            ConditionType conditionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conditionProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    conditionProperties = AutomationRulePropertyValuesChangedCondition.DeserializeAutomationRulePropertyValuesChangedCondition(property.Value);
                    continue;
                }
                if (property.NameEquals("conditionType"))
                {
                    conditionType = new ConditionType(property.Value.GetString());
                    continue;
                }
            }
            return new PropertyChangedConditionProperties(conditionType, conditionProperties.Value);
        }
    }
}
