// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class OutputFile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filePattern"u8);
            writer.WriteStringValue(FilePattern);
            writer.WritePropertyName("destination"u8);
            writer.WriteObjectValue(Destination);
            writer.WritePropertyName("uploadOptions"u8);
            writer.WriteObjectValue(UploadOptions);
            writer.WriteEndObject();
        }

        internal static OutputFile DeserializeOutputFile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string filePattern = default;
            OutputFileDestination destination = default;
            OutputFileUploadOptions uploadOptions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filePattern"u8))
                {
                    filePattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = OutputFileDestination.DeserializeOutputFileDestination(property.Value);
                    continue;
                }
                if (property.NameEquals("uploadOptions"u8))
                {
                    uploadOptions = OutputFileUploadOptions.DeserializeOutputFileUploadOptions(property.Value);
                    continue;
                }
            }
            return new OutputFile(filePattern, destination, uploadOptions);
        }
    }
}
