// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class WorkloadNetworkDnsServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(DnsServiceIP))
            {
                writer.WritePropertyName("dnsServiceIp");
                writer.WriteStringValue(DnsServiceIP.ToString());
            }
            if (Optional.IsDefined(DefaultDnsZone))
            {
                writer.WritePropertyName("defaultDnsZone");
                writer.WriteStringValue(DefaultDnsZone);
            }
            if (Optional.IsCollectionDefined(FqdnZones))
            {
                writer.WritePropertyName("fqdnZones");
                writer.WriteStartArray();
                foreach (var item in FqdnZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(LogLevel))
            {
                writer.WritePropertyName("logLevel");
                writer.WriteStringValue(LogLevel.Value.ToString());
            }
            if (Optional.IsDefined(Revision))
            {
                writer.WritePropertyName("revision");
                writer.WriteNumberValue(Revision.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WorkloadNetworkDnsServiceData DeserializeWorkloadNetworkDnsServiceData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<IPAddress> dnsServiceIP = default;
            Optional<string> defaultDnsZone = default;
            Optional<IList<string>> fqdnZones = default;
            Optional<DnsServiceLogLevel> logLevel = default;
            Optional<DnsServiceStatus> status = default;
            Optional<WorkloadNetworkDnsServiceProvisioningState> provisioningState = default;
            Optional<long> revision = default;
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
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
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsServiceIp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            dnsServiceIP = IPAddress.Parse(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("defaultDnsZone"))
                        {
                            defaultDnsZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fqdnZones"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            fqdnZones = array;
                            continue;
                        }
                        if (property0.NameEquals("logLevel"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            logLevel = new DnsServiceLogLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new DnsServiceStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new WorkloadNetworkDnsServiceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("revision"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            revision = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WorkloadNetworkDnsServiceData(id, name, type, systemData.Value, displayName.Value, dnsServiceIP.Value, defaultDnsZone.Value, Optional.ToList(fqdnZones), Optional.ToNullable(logLevel), Optional.ToNullable(status), Optional.ToNullable(provisioningState), Optional.ToNullable(revision));
        }
    }
}
