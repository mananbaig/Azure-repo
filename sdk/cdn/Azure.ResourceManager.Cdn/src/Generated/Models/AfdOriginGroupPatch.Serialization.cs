// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class AfdOriginGroupPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LoadBalancingSettings))
            {
                writer.WritePropertyName("loadBalancingSettings");
                writer.WriteObjectValue(LoadBalancingSettings);
            }
            if (Optional.IsDefined(HealthProbeSettings))
            {
                writer.WritePropertyName("healthProbeSettings");
                writer.WriteObjectValue(HealthProbeSettings);
            }
            if (Optional.IsDefined(TrafficRestorationTimeInMinutes))
            {
                if (TrafficRestorationTimeInMinutes != null)
                {
                    writer.WritePropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                    writer.WriteNumberValue(TrafficRestorationTimeInMinutes.Value);
                }
                else
                {
                    writer.WriteNull("trafficRestorationTimeToHealedOrNewEndpointsInMinutes");
                }
            }
            if (Optional.IsDefined(SessionAffinityState))
            {
                writer.WritePropertyName("sessionAffinityState");
                writer.WriteStringValue(SessionAffinityState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
