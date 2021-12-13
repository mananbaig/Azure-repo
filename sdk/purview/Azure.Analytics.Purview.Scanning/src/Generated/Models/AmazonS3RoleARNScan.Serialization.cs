// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class AmazonS3RoleARNScan : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WriteEndObject();
        }

        internal static AmazonS3RoleARNScan DeserializeAmazonS3RoleARNScan(JsonElement element)
        {
            Optional<AmazonS3RoleARNScanPropertiesAutoGenerated> properties = default;
            ScanAuthorizationType kind = default;
            Optional<IReadOnlyList<ScanResult>> scanResults = default;
            Optional<string> id = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = AmazonS3RoleARNScanPropertiesAutoGenerated.DeserializeAmazonS3RoleARNScanPropertiesAutoGenerated(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = new ScanAuthorizationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scanResults"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ScanResult> array = new List<ScanResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScanResult.DeserializeScanResult(item));
                    }
                    scanResults = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new AmazonS3RoleARNScan(id.Value, name.Value, kind, Optional.ToList(scanResults), properties.Value);
        }
    }
}
