// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class ManagedClusterSecurityProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureDefender))
            {
                writer.WritePropertyName("azureDefender");
                writer.WriteObjectValue(AzureDefender);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterSecurityProfile DeserializeManagedClusterSecurityProfile(JsonElement element)
        {
            Optional<ManagedClusterSecurityProfileAzureDefender> azureDefender = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureDefender"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureDefender = ManagedClusterSecurityProfileAzureDefender.DeserializeManagedClusterSecurityProfileAzureDefender(property.Value);
                    continue;
                }
            }
            return new ManagedClusterSecurityProfile(azureDefender.Value);
        }
    }
}
