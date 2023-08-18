// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class AzureActiveDirectoryApp : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ApplicationId))
            {
                writer.WritePropertyName("applicationId"u8);
                writer.WriteStringValue(ApplicationId);
            }
            if (Core.Optional.IsDefined(AppKey))
            {
                writer.WritePropertyName("appKey"u8);
                writer.WriteStringValue(AppKey);
            }
            if (Core.Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Core.Optional.IsDefined(IgnoreAzurePermissions))
            {
                writer.WritePropertyName("ignoreAzurePermissions"u8);
                writer.WriteBooleanValue(IgnoreAzurePermissions.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureActiveDirectoryApp DeserializeAzureActiveDirectoryApp(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> applicationId = default;
            Core.Optional<string> appKey = default;
            Core.Optional<Guid> tenantId = default;
            Core.Optional<bool> ignoreAzurePermissions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationId"u8))
                {
                    applicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appKey"u8))
                {
                    appKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("ignoreAzurePermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ignoreAzurePermissions = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AzureActiveDirectoryApp(applicationId.Value, appKey.Value, Core.Optional.ToNullable(tenantId), Core.Optional.ToNullable(ignoreAzurePermissions));
        }
    }
}
