// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceSortingCriteria : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ItemKey))
            {
                writer.WritePropertyName("itemKey");
                writer.WriteStringValue(ItemKey);
            }
            if (Optional.IsDefined(SortOrder))
            {
                writer.WritePropertyName("sortOrder");
                writer.WriteStringValue(SortOrder.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
