// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class ResourceRequests : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Cpu))
            {
                writer.WritePropertyName("cpu");
                writer.WriteStringValue(Cpu);
            }
            if (Optional.IsDefined(Memory))
            {
                writer.WritePropertyName("memory");
                writer.WriteStringValue(Memory);
            }
            writer.WriteEndObject();
        }

        internal static ResourceRequests DeserializeResourceRequests(JsonElement element)
        {
            Optional<string> cpu = default;
            Optional<string> memory = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cpu"))
                {
                    cpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memory"))
                {
                    memory = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceRequests(cpu.Value, memory.Value);
        }
    }
}
