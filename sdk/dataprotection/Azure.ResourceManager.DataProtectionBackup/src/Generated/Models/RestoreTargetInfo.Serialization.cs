// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class RestoreTargetInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("datasourceInfo"u8);
            writer.WriteObjectValue(DataSourceInfo);
            if (Core.Optional.IsDefined(DataSourceSetInfo))
            {
                writer.WritePropertyName("datasourceSetInfo"u8);
                writer.WriteObjectValue(DataSourceSetInfo);
            }
            if (Core.Optional.IsDefined(DataSourceAuthCredentials))
            {
                writer.WritePropertyName("datasourceAuthCredentials"u8);
                writer.WriteObjectValue(DataSourceAuthCredentials);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WritePropertyName("recoveryOption"u8);
            writer.WriteStringValue(RecoverySetting.ToString());
            if (Core.Optional.IsDefined(RestoreLocation))
            {
                writer.WritePropertyName("restoreLocation"u8);
                writer.WriteStringValue(RestoreLocation.Value);
            }
            writer.WriteEndObject();
        }
    }
}
