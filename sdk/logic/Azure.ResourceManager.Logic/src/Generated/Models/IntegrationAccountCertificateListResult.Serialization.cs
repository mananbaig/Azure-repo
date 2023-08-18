// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class IntegrationAccountCertificateListResult
    {
        internal static IntegrationAccountCertificateListResult DeserializeIntegrationAccountCertificateListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<IntegrationAccountCertificateData>> value = default;
            Core.Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IntegrationAccountCertificateData> array = new List<IntegrationAccountCertificateData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IntegrationAccountCertificateData.DeserializeIntegrationAccountCertificateData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new IntegrationAccountCertificateListResult(Core.Optional.ToList(value), nextLink.Value);
        }
    }
}
