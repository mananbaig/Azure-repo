// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureApplicationInsightsParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (AzureCloud != null)
            {
                writer.WritePropertyName("azureCloud");
                writer.WriteStringValue(AzureCloud);
            }
            else
            {
                writer.WriteNull("azureCloud");
            }
            if (ApplicationId != null)
            {
                writer.WritePropertyName("applicationId");
                writer.WriteStringValue(ApplicationId);
            }
            else
            {
                writer.WriteNull("applicationId");
            }
            if (ApiKey != null)
            {
                writer.WritePropertyName("apiKey");
                writer.WriteStringValue(ApiKey);
            }
            else
            {
                writer.WriteNull("apiKey");
            }
            if (Query != null)
            {
                writer.WritePropertyName("query");
                writer.WriteStringValue(Query);
            }
            else
            {
                writer.WriteNull("query");
            }
            writer.WriteEndObject();
        }

        internal static AzureApplicationInsightsParameter DeserializeAzureApplicationInsightsParameter(JsonElement element)
        {
            string azureCloud = default;
            string applicationId = default;
            string apiKey = default;
            string query = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureCloud"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        azureCloud = null;
                        continue;
                    }
                    azureCloud = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("applicationId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        applicationId = null;
                        continue;
                    }
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        apiKey = null;
                        continue;
                    }
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("query"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        query = null;
                        continue;
                    }
                    query = property.Value.GetString();
                    continue;
                }
            }
            return new AzureApplicationInsightsParameter(azureCloud, applicationId, apiKey, query);
        }
    }
}
