// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class ExitCodeRangeMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("start"u8);
            writer.WriteNumberValue(Start);
            writer.WritePropertyName("end"u8);
            writer.WriteNumberValue(End);
            writer.WritePropertyName("exitOptions"u8);
            writer.WriteObjectValue(ExitOptions);
            writer.WriteEndObject();
        }

        internal static ExitCodeRangeMapping DeserializeExitCodeRangeMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int start = default;
            int end = default;
            ExitOptions exitOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exitOptions"u8))
                {
                    exitOptions = ExitOptions.DeserializeExitOptions(property.Value);
                    continue;
                }
            }
            return new ExitCodeRangeMapping(start, end, exitOptions);
        }
    }
}
