// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ContainerServiceCustomProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("orchestrator");
            writer.WriteStringValue(Orchestrator);
            writer.WriteEndObject();
        }

        internal static ContainerServiceCustomProfile DeserializeContainerServiceCustomProfile(JsonElement element)
        {
            string orchestrator = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("orchestrator"))
                {
                    orchestrator = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceCustomProfile(orchestrator);
        }
    }
}
