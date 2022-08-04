// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class TenantAccessInfoCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId");
                writer.WriteStringValue(PrincipalId);
            }
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey");
                writer.WriteStringValue(PrimaryKey);
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey");
                writer.WriteStringValue(SecondaryKey);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
