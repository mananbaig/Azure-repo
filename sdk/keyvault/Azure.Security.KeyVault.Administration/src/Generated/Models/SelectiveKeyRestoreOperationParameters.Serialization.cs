// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class SelectiveKeyRestoreOperationParameters : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sasTokenParameters"u8);
            writer.WriteObjectValue(SasTokenParameters);
            writer.WritePropertyName("folder"u8);
            writer.WriteStringValue(Folder);
            writer.WriteEndObject();
        }
    }
}
