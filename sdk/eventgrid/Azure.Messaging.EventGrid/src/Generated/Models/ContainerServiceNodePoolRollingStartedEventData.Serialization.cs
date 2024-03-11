// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerServiceNodePoolRollingStartedEventDataConverter))]
    public partial class ContainerServiceNodePoolRollingStartedEventData
    {
        internal static ContainerServiceNodePoolRollingStartedEventData DeserializeContainerServiceNodePoolRollingStartedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nodePoolName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodePoolName"u8))
                {
                    nodePoolName = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceNodePoolRollingStartedEventData(nodePoolName);
        }

        internal partial class ContainerServiceNodePoolRollingStartedEventDataConverter : JsonConverter<ContainerServiceNodePoolRollingStartedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerServiceNodePoolRollingStartedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ContainerServiceNodePoolRollingStartedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerServiceNodePoolRollingStartedEventData(document.RootElement);
            }
        }
    }
}
