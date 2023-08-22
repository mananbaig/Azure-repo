// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class TestInputArtifacts
    {
        internal static TestInputArtifacts DeserializeTestInputArtifacts(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FileInfo> configFileInfo = default;
            Optional<FileInfo> testScriptFileInfo = default;
            Optional<FileInfo> userPropFileInfo = default;
            Optional<FileInfo> inputArtifactsZipFileInfo = default;
            Optional<IReadOnlyList<FileInfo>> additionalFileInfo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configFileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configFileInfo = FileInfo.DeserializeFileInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("testScriptFileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    testScriptFileInfo = FileInfo.DeserializeFileInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("userPropFileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userPropFileInfo = FileInfo.DeserializeFileInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("inputArtifactsZipFileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inputArtifactsZipFileInfo = FileInfo.DeserializeFileInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("additionalFileInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FileInfo> array = new List<FileInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FileInfo.DeserializeFileInfo(item));
                    }
                    additionalFileInfo = array;
                    continue;
                }
            }
            return new TestInputArtifacts(configFileInfo.Value, testScriptFileInfo.Value, userPropFileInfo.Value, inputArtifactsZipFileInfo.Value, Optional.ToList(additionalFileInfo));
        }
    }
}
