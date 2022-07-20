// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    internal partial class LogFileListResult
    {
        internal static LogFileListResult DeserializeLogFileListResult(JsonElement element)
        {
            Optional<IReadOnlyList<LogFile>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LogFile> array = new List<LogFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogFile.DeserializeLogFile(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LogFileListResult(Optional.ToList(value));
        }
    }
}
