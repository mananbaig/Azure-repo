// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AzureBlobStorageHttpLogsConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SasUri))
            {
                writer.WritePropertyName("sasUrl");
                writer.WriteStringValue(SasUri);
            }
            if (Optional.IsDefined(RetentionInDays))
            {
                writer.WritePropertyName("retentionInDays");
                writer.WriteNumberValue(RetentionInDays.Value);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureBlobStorageHttpLogsConfig DeserializeAzureBlobStorageHttpLogsConfig(JsonElement element)
        {
            Optional<string> sasUrl = default;
            Optional<int> retentionInDays = default;
            Optional<bool> enabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUrl"))
                {
                    sasUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retentionInDays"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AzureBlobStorageHttpLogsConfig(sasUrl.Value, Optional.ToNullable(retentionInDays), Optional.ToNullable(enabled));
        }
    }
}
