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
    [JsonConverter(typeof(DatasetFolderConverter))]
    public partial class DatasetFolder : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            writer.WriteEndObject();
        }

        internal static DatasetFolder DeserializeDatasetFolder(JsonElement element)
        {
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new DatasetFolder(name.Value);
        }

        internal partial class DatasetFolderConverter : JsonConverter<DatasetFolder>
        {
            public override void Write(Utf8JsonWriter writer, DatasetFolder model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DatasetFolder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDatasetFolder(document.RootElement);
            }
        }
    }
}
