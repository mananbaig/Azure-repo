// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class HttpRequestParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Url != null)
            {
                writer.WritePropertyName("url");
                writer.WriteStringValue(Url);
            }
            else
            {
                writer.WriteNull("url");
            }
            if (HttpHeader != null)
            {
                writer.WritePropertyName("httpHeader");
                writer.WriteStringValue(HttpHeader);
            }
            else
            {
                writer.WriteNull("httpHeader");
            }
            if (HttpMethod != null)
            {
                writer.WritePropertyName("httpMethod");
                writer.WriteStringValue(HttpMethod);
            }
            else
            {
                writer.WriteNull("httpMethod");
            }
            if (Payload != null)
            {
                writer.WritePropertyName("payload");
                writer.WriteStringValue(Payload);
            }
            else
            {
                writer.WriteNull("payload");
            }
            writer.WriteEndObject();
        }

        internal static HttpRequestParameter DeserializeHttpRequestParameter(JsonElement element)
        {
            string url = default;
            string httpHeader = default;
            string httpMethod = default;
            string payload = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpHeader"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpHeader = null;
                        continue;
                    }
                    httpHeader = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpMethod"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpMethod = null;
                        continue;
                    }
                    httpMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("payload"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        payload = null;
                        continue;
                    }
                    payload = property.Value.GetString();
                    continue;
                }
            }
            return new HttpRequestParameter(url, httpHeader, httpMethod, payload);
        }
    }
}
