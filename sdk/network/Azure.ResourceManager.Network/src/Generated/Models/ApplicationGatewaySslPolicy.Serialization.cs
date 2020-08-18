// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewaySslPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DisabledSslProtocols))
            {
                writer.WritePropertyName("disabledSslProtocols");
                writer.WriteStartArray();
                foreach (var item in DisabledSslProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PolicyType))
            {
                writer.WritePropertyName("policyType");
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (Optional.IsDefined(PolicyName))
            {
                writer.WritePropertyName("policyName");
                writer.WriteStringValue(PolicyName.Value.ToString());
            }
            if (Optional.IsCollectionDefined(CipherSuites))
            {
                writer.WritePropertyName("cipherSuites");
                writer.WriteStartArray();
                foreach (var item in CipherSuites)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinProtocolVersion))
            {
                writer.WritePropertyName("minProtocolVersion");
                writer.WriteStringValue(MinProtocolVersion.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewaySslPolicy DeserializeApplicationGatewaySslPolicy(JsonElement element)
        {
            Optional<IList<ApplicationGatewaySslProtocol>> disabledSslProtocols = default;
            Optional<ApplicationGatewaySslPolicyType> policyType = default;
            Optional<ApplicationGatewaySslPolicyName> policyName = default;
            Optional<IList<ApplicationGatewaySslCipherSuite>> cipherSuites = default;
            Optional<ApplicationGatewaySslProtocol> minProtocolVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disabledSslProtocols"))
                {
                    List<ApplicationGatewaySslProtocol> array = new List<ApplicationGatewaySslProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ApplicationGatewaySslProtocol(item.GetString()));
                    }
                    disabledSslProtocols = array;
                    continue;
                }
                if (property.NameEquals("policyType"))
                {
                    policyType = new ApplicationGatewaySslPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyName"))
                {
                    policyName = new ApplicationGatewaySslPolicyName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cipherSuites"))
                {
                    List<ApplicationGatewaySslCipherSuite> array = new List<ApplicationGatewaySslCipherSuite>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ApplicationGatewaySslCipherSuite(item.GetString()));
                    }
                    cipherSuites = array;
                    continue;
                }
                if (property.NameEquals("minProtocolVersion"))
                {
                    minProtocolVersion = new ApplicationGatewaySslProtocol(property.Value.GetString());
                    continue;
                }
            }
            return new ApplicationGatewaySslPolicy(Optional.ToList(disabledSslProtocols), Optional.ToNullable(policyType), Optional.ToNullable(policyName), Optional.ToList(cipherSuites), Optional.ToNullable(minProtocolVersion));
        }
    }
}
