// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            writer.WritePropertyName("firewallMode");
            writer.WriteStringValue(FirewallMode.ToString());
            writer.WritePropertyName("ruleSetType");
            writer.WriteStringValue(RuleSetType);
            writer.WritePropertyName("ruleSetVersion");
            writer.WriteStringValue(RuleSetVersion);
            if (DisabledRuleGroups != null)
            {
                writer.WritePropertyName("disabledRuleGroups");
                writer.WriteStartArray();
                foreach (var item in DisabledRuleGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (RequestBodyCheck != null)
            {
                writer.WritePropertyName("requestBodyCheck");
                writer.WriteBooleanValue(RequestBodyCheck.Value);
            }
            if (MaxRequestBodySize != null)
            {
                writer.WritePropertyName("maxRequestBodySize");
                writer.WriteNumberValue(MaxRequestBodySize.Value);
            }
            if (MaxRequestBodySizeInKb != null)
            {
                writer.WritePropertyName("maxRequestBodySizeInKb");
                writer.WriteNumberValue(MaxRequestBodySizeInKb.Value);
            }
            if (FileUploadLimitInMb != null)
            {
                writer.WritePropertyName("fileUploadLimitInMb");
                writer.WriteNumberValue(FileUploadLimitInMb.Value);
            }
            if (Exclusions != null)
            {
                writer.WritePropertyName("exclusions");
                writer.WriteStartArray();
                foreach (var item in Exclusions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewayWebApplicationFirewallConfiguration DeserializeApplicationGatewayWebApplicationFirewallConfiguration(JsonElement element)
        {
            bool enabled = default;
            ApplicationGatewayFirewallMode firewallMode = default;
            string ruleSetType = default;
            string ruleSetVersion = default;
            IList<ApplicationGatewayFirewallDisabledRuleGroup> disabledRuleGroups = default;
            bool? requestBodyCheck = default;
            int? maxRequestBodySize = default;
            int? maxRequestBodySizeInKb = default;
            int? fileUploadLimitInMb = default;
            IList<ApplicationGatewayFirewallExclusion> exclusions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("firewallMode"))
                {
                    firewallMode = new ApplicationGatewayFirewallMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ruleSetType"))
                {
                    ruleSetType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleSetVersion"))
                {
                    ruleSetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disabledRuleGroups"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayFirewallDisabledRuleGroup> array = new List<ApplicationGatewayFirewallDisabledRuleGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ApplicationGatewayFirewallDisabledRuleGroup.DeserializeApplicationGatewayFirewallDisabledRuleGroup(item));
                        }
                    }
                    disabledRuleGroups = array;
                    continue;
                }
                if (property.NameEquals("requestBodyCheck"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBodyCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRequestBodySize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxRequestBodySizeInKb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRequestBodySizeInKb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fileUploadLimitInMb"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileUploadLimitInMb = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exclusions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewayFirewallExclusion> array = new List<ApplicationGatewayFirewallExclusion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ApplicationGatewayFirewallExclusion.DeserializeApplicationGatewayFirewallExclusion(item));
                        }
                    }
                    exclusions = array;
                    continue;
                }
            }
            return new ApplicationGatewayWebApplicationFirewallConfiguration(enabled, firewallMode, ruleSetType, ruleSetVersion, disabledRuleGroups, requestBodyCheck, maxRequestBodySize, maxRequestBodySizeInKb, fileUploadLimitInMb, exclusions);
        }
    }
}
