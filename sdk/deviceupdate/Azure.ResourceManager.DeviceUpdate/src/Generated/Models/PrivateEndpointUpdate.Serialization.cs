// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class PrivateEndpointUpdate : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Core.Optional.IsDefined(ImmutableSubscriptionId))
            {
                writer.WritePropertyName("immutableSubscriptionId"u8);
                writer.WriteStringValue(ImmutableSubscriptionId);
            }
            if (Core.Optional.IsDefined(ImmutableResourceId))
            {
                writer.WritePropertyName("immutableResourceId"u8);
                writer.WriteStringValue(ImmutableResourceId);
            }
            if (Core.Optional.IsDefined(VnetTrafficTag))
            {
                writer.WritePropertyName("vnetTrafficTag"u8);
                writer.WriteStringValue(VnetTrafficTag);
            }
            writer.WriteEndObject();
        }
    }
}
