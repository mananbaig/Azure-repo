// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(DeviceTwinInfoPropertiesConverter))]
    public partial class DeviceTwinInfoProperties
    {
        internal static DeviceTwinInfoProperties DeserializeDeviceTwinInfoProperties(JsonElement element)
        {
            Optional<DeviceTwinProperties> desired = default;
            Optional<DeviceTwinProperties> reported = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("desired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    desired = DeviceTwinProperties.DeserializeDeviceTwinProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("reported"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    reported = DeviceTwinProperties.DeserializeDeviceTwinProperties(property.Value);
                    continue;
                }
            }
            return new DeviceTwinInfoProperties(desired.Value, reported.Value);
        }

        internal partial class DeviceTwinInfoPropertiesConverter : JsonConverter<DeviceTwinInfoProperties>
        {
            public override void Write(Utf8JsonWriter writer, DeviceTwinInfoProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DeviceTwinInfoProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDeviceTwinInfoProperties(document.RootElement);
            }
        }
    }
}
