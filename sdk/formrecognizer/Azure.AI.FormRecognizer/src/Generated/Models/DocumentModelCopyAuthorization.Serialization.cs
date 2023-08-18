// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentModelCopyAuthorization : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId"u8);
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("targetResourceRegion"u8);
            writer.WriteStringValue(TargetResourceRegion);
            writer.WritePropertyName("targetModelId"u8);
            writer.WriteStringValue(TargetModelId);
            writer.WritePropertyName("targetModelLocation"u8);
            writer.WriteStringValue(TargetModelLocation.AbsoluteUri);
            writer.WritePropertyName("accessToken"u8);
            writer.WriteStringValue(AccessToken);
            writer.WritePropertyName("expirationDateTime"u8);
            writer.WriteStringValue(ExpiresOn, "O");
            writer.WriteEndObject();
        }

        internal static DocumentModelCopyAuthorization DeserializeDocumentModelCopyAuthorization(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetResourceId = default;
            string targetResourceRegion = default;
            string targetModelId = default;
            Uri targetModelLocation = default;
            string accessToken = default;
            DateTimeOffset expirationDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetResourceId"u8))
                {
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceRegion"u8))
                {
                    targetResourceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetModelId"u8))
                {
                    targetModelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetModelLocation"u8))
                {
                    targetModelLocation = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("accessToken"u8))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new DocumentModelCopyAuthorization(targetResourceId, targetResourceRegion, targetModelId, targetModelLocation, accessToken, expirationDateTime);
        }
    }
}
