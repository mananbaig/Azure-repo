// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class UploadBatchServiceLogsResult
    {
        internal static UploadBatchServiceLogsResult DeserializeUploadBatchServiceLogsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string virtualDirectoryName = default;
            int numberOfFilesUploaded = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualDirectoryName"u8))
                {
                    virtualDirectoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfFilesUploaded"u8))
                {
                    numberOfFilesUploaded = property.Value.GetInt32();
                    continue;
                }
            }
            return new UploadBatchServiceLogsResult(virtualDirectoryName, numberOfFilesUploaded);
        }
    }
}
