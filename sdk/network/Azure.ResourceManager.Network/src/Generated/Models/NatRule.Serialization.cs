// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NatRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPProtocols))
            {
                writer.WritePropertyName("ipProtocols");
                writer.WriteStartArray();
                foreach (var item in IPProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceAddresses))
            {
                writer.WritePropertyName("sourceAddresses");
                writer.WriteStartArray();
                foreach (var item in SourceAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationAddresses))
            {
                writer.WritePropertyName("destinationAddresses");
                writer.WriteStartArray();
                foreach (var item in DestinationAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPorts))
            {
                writer.WritePropertyName("destinationPorts");
                writer.WriteStartArray();
                foreach (var item in DestinationPorts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TranslatedAddress))
            {
                writer.WritePropertyName("translatedAddress");
                writer.WriteStringValue(TranslatedAddress);
            }
            if (Optional.IsDefined(TranslatedPort))
            {
                writer.WritePropertyName("translatedPort");
                writer.WriteStringValue(TranslatedPort);
            }
            if (Optional.IsCollectionDefined(SourceIPGroups))
            {
                writer.WritePropertyName("sourceIpGroups");
                writer.WriteStartArray();
                foreach (var item in SourceIPGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TranslatedFqdn))
            {
                writer.WritePropertyName("translatedFqdn");
                writer.WriteStringValue(TranslatedFqdn);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            writer.WriteEndObject();
        }

        internal static NatRule DeserializeNatRule(JsonElement element)
        {
            Optional<IList<FirewallPolicyRuleNetworkProtocol>> ipProtocols = default;
            Optional<IList<string>> sourceAddresses = default;
            Optional<IList<string>> destinationAddresses = default;
            Optional<IList<string>> destinationPorts = default;
            Optional<string> translatedAddress = default;
            Optional<string> translatedPort = default;
            Optional<IList<string>> sourceIPGroups = default;
            Optional<string> translatedFqdn = default;
            Optional<string> name = default;
            Optional<string> description = default;
            FirewallPolicyRuleType ruleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipProtocols"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<FirewallPolicyRuleNetworkProtocol> array = new List<FirewallPolicyRuleNetworkProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new FirewallPolicyRuleNetworkProtocol(item.GetString()));
                    }
                    ipProtocols = array;
                    continue;
                }
                if (property.NameEquals("sourceAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourceAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinationAddresses = array;
                    continue;
                }
                if (property.NameEquals("destinationPorts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    destinationPorts = array;
                    continue;
                }
                if (property.NameEquals("translatedAddress"))
                {
                    translatedAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translatedPort"))
                {
                    translatedPort = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceIpGroups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourceIPGroups = array;
                    continue;
                }
                if (property.NameEquals("translatedFqdn"))
                {
                    translatedFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleType"))
                {
                    ruleType = new FirewallPolicyRuleType(property.Value.GetString());
                    continue;
                }
            }
            return new NatRule(name.Value, description.Value, ruleType, Optional.ToList(ipProtocols), Optional.ToList(sourceAddresses), Optional.ToList(destinationAddresses), Optional.ToList(destinationPorts), translatedAddress.Value, translatedPort.Value, Optional.ToList(sourceIPGroups), translatedFqdn.Value);
        }
    }
}
