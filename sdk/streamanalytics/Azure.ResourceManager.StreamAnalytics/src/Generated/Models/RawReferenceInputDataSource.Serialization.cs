// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class RawReferenceInputDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(ReferenceInputDataSourceType);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Payload))
            {
                writer.WritePropertyName("payload");
                writer.WriteStringValue(Payload);
            }
            if (Optional.IsDefined(PayloadUri))
            {
                writer.WritePropertyName("payloadUri");
                writer.WriteStringValue(PayloadUri.AbsoluteUri);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RawReferenceInputDataSource DeserializeRawReferenceInputDataSource(JsonElement element)
        {
            string type = default;
            Optional<string> payload = default;
            Optional<Uri> payloadUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("payload"))
                        {
                            payload = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("payloadUri"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                payloadUri = null;
                                continue;
                            }
                            payloadUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RawReferenceInputDataSource(type, payload.Value, payloadUri.Value);
        }
    }
}
