// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownSparkJobEntry : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sparkJobEntryType"u8);
            writer.WriteStringValue(SparkJobEntryType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownSparkJobEntry DeserializeUnknownSparkJobEntry(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SparkJobEntryType sparkJobEntryType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sparkJobEntryType"u8))
                {
                    sparkJobEntryType = new SparkJobEntryType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSparkJobEntry(sparkJobEntryType);
        }
    }
}
