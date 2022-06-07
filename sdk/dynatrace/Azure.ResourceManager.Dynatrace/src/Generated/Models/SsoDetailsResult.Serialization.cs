// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class SsoDetailsResult
    {
        internal static SsoDetailsResult DeserializeSsoDetailsResult(JsonElement element)
        {
            Optional<SsoStatus> isSsoEnabled = default;
            Optional<Uri> metadataUrl = default;
            Optional<Uri> singleSignOnUrl = default;
            Optional<IReadOnlyList<string>> aadDomains = default;
            Optional<IReadOnlyList<string>> adminUsers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSsoEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isSsoEnabled = new SsoStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metadataUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        metadataUrl = null;
                        continue;
                    }
                    metadataUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("singleSignOnUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        singleSignOnUrl = null;
                        continue;
                    }
                    singleSignOnUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadDomains"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    aadDomains = array;
                    continue;
                }
                if (property.NameEquals("adminUsers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    adminUsers = array;
                    continue;
                }
            }
            return new SsoDetailsResult(Optional.ToNullable(isSsoEnabled), metadataUrl.Value, singleSignOnUrl.Value, Optional.ToList(aadDomains), Optional.ToList(adminUsers));
        }
    }
}
