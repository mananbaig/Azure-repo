// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubNetworkRuleSetProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            writer.WritePropertyName("applyToBuiltInEventHubEndpoint"u8);
            writer.WriteBooleanValue(ApplyToBuiltInEventHubEndpoint);
            writer.WritePropertyName("ipRules"u8);
            writer.WriteStartArray();
            foreach (var item in IPRules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static IotHubNetworkRuleSetProperties DeserializeIotHubNetworkRuleSetProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IotHubNetworkRuleSetDefaultAction> defaultAction = default;
            bool applyToBuiltInEventHubEndpoint = default;
            IList<NetworkRuleSetIPRule> ipRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultAction = new IotHubNetworkRuleSetDefaultAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applyToBuiltInEventHubEndpoint"u8))
                {
                    applyToBuiltInEventHubEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ipRules"u8))
                {
                    List<NetworkRuleSetIPRule> array = new List<NetworkRuleSetIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkRuleSetIPRule.DeserializeNetworkRuleSetIPRule(item));
                    }
                    ipRules = array;
                    continue;
                }
            }
            return new IotHubNetworkRuleSetProperties(Optional.ToNullable(defaultAction), applyToBuiltInEventHubEndpoint, ipRules);
        }
    }
}
