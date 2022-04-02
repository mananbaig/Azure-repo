// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    internal partial class SecurityPolicyWebApplicationFirewallParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WafPolicy))
            {
                writer.WritePropertyName("wafPolicy");
                JsonSerializer.Serialize(writer, WafPolicy);
            }
            if (Optional.IsCollectionDefined(Associations))
            {
                writer.WritePropertyName("associations");
                writer.WriteStartArray();
                foreach (var item in Associations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(SecurityPolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static SecurityPolicyWebApplicationFirewallParameters DeserializeSecurityPolicyWebApplicationFirewallParameters(JsonElement element)
        {
            Optional<WritableSubResource> wafPolicy = default;
            Optional<IList<SecurityPolicyWebApplicationFirewallAssociation>> associations = default;
            SecurityPolicyType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("wafPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    wafPolicy = JsonSerializer.Deserialize<WritableSubResource>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("associations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SecurityPolicyWebApplicationFirewallAssociation> array = new List<SecurityPolicyWebApplicationFirewallAssociation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityPolicyWebApplicationFirewallAssociation.DeserializeSecurityPolicyWebApplicationFirewallAssociation(item));
                    }
                    associations = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new SecurityPolicyType(property.Value.GetString());
                    continue;
                }
            }
            return new SecurityPolicyWebApplicationFirewallParameters(type, wafPolicy, Optional.ToList(associations));
        }
    }
}
