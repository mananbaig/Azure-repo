// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class RequestReportRecordContract
    {
        internal static RequestReportRecordContract DeserializeRequestReportRecordContract(JsonElement element)
        {
            Optional<string> apiId = default;
            Optional<string> operationId = default;
            Optional<string> productId = default;
            Optional<string> userId = default;
            Optional<RequestMethod> method = default;
            Optional<Uri> uri = default;
            Optional<IPAddress> ipAddress = default;
            Optional<string> backendResponseCode = default;
            Optional<int> responseCode = default;
            Optional<int> responseSize = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> cache = default;
            Optional<double> apiTime = default;
            Optional<double> serviceTime = default;
            Optional<string> apiRegion = default;
            Optional<ResourceIdentifier> subscriptionId = default;
            Optional<string> requestId = default;
            Optional<int> requestSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiId"))
                {
                    apiId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productId"))
                {
                    productId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    method = new RequestMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backendResponseCode"))
                {
                    backendResponseCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("responseCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    responseCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("responseSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    responseSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cache"))
                {
                    cache = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    apiTime = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("serviceTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serviceTime = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("apiRegion"))
                {
                    apiRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    subscriptionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestId"))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    requestSize = property.Value.GetInt32();
                    continue;
                }
            }
            return new RequestReportRecordContract(apiId.Value, operationId.Value, productId.Value, userId.Value, Optional.ToNullable(method), uri.Value, ipAddress.Value, backendResponseCode.Value, Optional.ToNullable(responseCode), Optional.ToNullable(responseSize), Optional.ToNullable(timestamp), cache.Value, Optional.ToNullable(apiTime), Optional.ToNullable(serviceTime), apiRegion.Value, subscriptionId.Value, requestId.Value, Optional.ToNullable(requestSize));
        }
    }
}
