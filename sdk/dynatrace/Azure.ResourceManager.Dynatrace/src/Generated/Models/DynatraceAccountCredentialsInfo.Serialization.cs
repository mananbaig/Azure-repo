// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceAccountCredentialsInfo
    {
        internal static DynatraceAccountCredentialsInfo DeserializeDynatraceAccountCredentialsInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> accountId = default;
            Core.Optional<string> apiKey = default;
            Core.Optional<string> regionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountId"u8))
                {
                    accountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"u8))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regionId"u8))
                {
                    regionId = property.Value.GetString();
                    continue;
                }
            }
            return new DynatraceAccountCredentialsInfo(accountId.Value, apiKey.Value, regionId.Value);
        }
    }
}
