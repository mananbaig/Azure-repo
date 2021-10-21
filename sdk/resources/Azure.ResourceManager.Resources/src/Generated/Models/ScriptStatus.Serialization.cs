// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ScriptStatus
    {
        internal static ScriptStatus DeserializeScriptStatus(JsonElement element)
        {
            Optional<string> containerInstanceId = default;
            Optional<string> storageAccountId = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<DateTimeOffset> expirationTime = default;
            Optional<ErrorDetail> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerInstanceId"))
                {
                    containerInstanceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccountId"))
                {
                    storageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ErrorDetail>(property.Value.ToString());
                    continue;
                }
            }
            return new ScriptStatus(containerInstanceId.Value, storageAccountId.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(expirationTime), error);
        }
    }
}
