// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ActivityEntityQueryTemplatePropertiesQueryDefinitions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Query))
            {
                writer.WritePropertyName("query");
                writer.WriteStringValue(Query);
            }
            if (Optional.IsDefined(SummarizeBy))
            {
                writer.WritePropertyName("summarizeBy");
                writer.WriteStringValue(SummarizeBy);
            }
            writer.WriteEndObject();
        }

        internal static ActivityEntityQueryTemplatePropertiesQueryDefinitions DeserializeActivityEntityQueryTemplatePropertiesQueryDefinitions(JsonElement element)
        {
            Optional<string> query = default;
            Optional<string> summarizeBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("summarizeBy"))
                {
                    summarizeBy = property.Value.GetString();
                    continue;
                }
            }
            return new ActivityEntityQueryTemplatePropertiesQueryDefinitions(query.Value, summarizeBy.Value);
        }
    }
}
