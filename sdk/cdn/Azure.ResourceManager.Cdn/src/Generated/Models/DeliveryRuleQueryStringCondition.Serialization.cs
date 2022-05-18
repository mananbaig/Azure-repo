// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class DeliveryRuleQueryStringCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("parameters");
            writer.WriteObjectValue(Parameters);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name.ToString());
            writer.WriteEndObject();
        }

        internal static DeliveryRuleQueryStringCondition DeserializeDeliveryRuleQueryStringCondition(JsonElement element)
        {
            QueryStringMatchConditionDefinition parameters = default;
            MatchVariable name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"))
                {
                    parameters = QueryStringMatchConditionDefinition.DeserializeQueryStringMatchConditionDefinition(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = new MatchVariable(property.Value.GetString());
                    continue;
                }
            }
            return new DeliveryRuleQueryStringCondition(name, parameters);
        }
    }
}
