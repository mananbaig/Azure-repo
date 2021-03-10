// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(DatasetDebugResourceConverter))]
    public partial class DatasetDebugResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteObjectValue(Properties);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WriteEndObject();
        }

        internal static DatasetDebugResource DeserializeDatasetDebugResource(JsonElement element)
        {
            Dataset properties = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    properties = Dataset.DeserializeDataset(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new DatasetDebugResource(name.Value, properties);
        }

        internal partial class DatasetDebugResourceConverter : JsonConverter<DatasetDebugResource>
        {
            public override void Write(Utf8JsonWriter writer, DatasetDebugResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DatasetDebugResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDatasetDebugResource(document.RootElement);
            }
        }
    }
}
