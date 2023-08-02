// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorWorkspaceMetricProperties
    {
        internal static MonitorWorkspaceMetricProperties DeserializeMonitorWorkspaceMetricProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> prometheusQueryEndpoint = default;
            Optional<string> internalId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("prometheusQueryEndpoint"u8))
                {
                    prometheusQueryEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("internalId"u8))
                {
                    internalId = property.Value.GetString();
                    continue;
                }
            }
            return new MonitorWorkspaceMetricProperties(prometheusQueryEndpoint.Value, internalId.Value);
        }
    }
}
