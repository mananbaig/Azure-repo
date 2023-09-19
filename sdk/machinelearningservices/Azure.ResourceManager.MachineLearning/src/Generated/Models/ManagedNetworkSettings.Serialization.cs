// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ManagedNetworkSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsolationMode))
            {
                writer.WritePropertyName("isolationMode"u8);
                writer.WriteStringValue(IsolationMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(OutboundRules))
            {
                if (OutboundRules != null)
                {
                    writer.WritePropertyName("outboundRules"u8);
                    writer.WriteStartObject();
                    foreach (var item in OutboundRules)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("outboundRules");
                }
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteObjectValue(Status);
            }
            writer.WriteEndObject();
        }

        internal static ManagedNetworkSettings DeserializeManagedNetworkSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IsolationMode> isolationMode = default;
            Optional<string> networkId = default;
            Optional<IDictionary<string, OutboundRule>> outboundRules = default;
            Optional<ManagedNetworkProvisionStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isolationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isolationMode = new IsolationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkId"u8))
                {
                    networkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("outboundRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        outboundRules = null;
                        continue;
                    }
                    Dictionary<string, OutboundRule> dictionary = new Dictionary<string, OutboundRule>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, OutboundRule.DeserializeOutboundRule(property0.Value));
                    }
                    outboundRules = dictionary;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = ManagedNetworkProvisionStatus.DeserializeManagedNetworkProvisionStatus(property.Value);
                    continue;
                }
            }
            return new ManagedNetworkSettings(Optional.ToNullable(isolationMode), networkId.Value, Optional.ToDictionary(outboundRules), status.Value);
        }
    }
}
