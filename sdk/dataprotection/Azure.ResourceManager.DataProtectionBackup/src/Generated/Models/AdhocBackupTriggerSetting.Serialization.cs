// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    internal partial class AdhocBackupTriggerSetting : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(RetentionTagOverride))
            {
                writer.WritePropertyName("retentionTagOverride"u8);
                writer.WriteStringValue(RetentionTagOverride);
            }
            writer.WriteEndObject();
        }
    }
}
