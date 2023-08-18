// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationAccountAssemblyProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("assemblyName"u8);
            writer.WriteStringValue(AssemblyName);
            if (Core.Optional.IsDefined(AssemblyVersion))
            {
                writer.WritePropertyName("assemblyVersion"u8);
                writer.WriteStringValue(AssemblyVersion);
            }
            if (Core.Optional.IsDefined(AssemblyCulture))
            {
                writer.WritePropertyName("assemblyCulture"u8);
                writer.WriteStringValue(AssemblyCulture);
            }
            if (Core.Optional.IsDefined(AssemblyPublicKeyToken))
            {
                writer.WritePropertyName("assemblyPublicKeyToken"u8);
                writer.WriteStringValue(AssemblyPublicKeyToken);
            }
            if (Core.Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Content);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Content.ToString()).RootElement);
#endif
            }
            if (Core.Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType.Value.ToString());
            }
            if (Core.Optional.IsDefined(ContentLink))
            {
                writer.WritePropertyName("contentLink"u8);
                writer.WriteObjectValue(ContentLink);
            }
            if (Core.Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Core.Optional.IsDefined(ChangedOn))
            {
                writer.WritePropertyName("changedTime"u8);
                writer.WriteStringValue(ChangedOn.Value, "O");
            }
            if (Core.Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Metadata.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static IntegrationAccountAssemblyProperties DeserializeIntegrationAccountAssemblyProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string assemblyName = default;
            Core.Optional<string> assemblyVersion = default;
            Core.Optional<string> assemblyCulture = default;
            Core.Optional<string> assemblyPublicKeyToken = default;
            Core.Optional<BinaryData> content = default;
            Core.Optional<ContentType> contentType = default;
            Core.Optional<LogicContentLink> contentLink = default;
            Core.Optional<DateTimeOffset> createdTime = default;
            Core.Optional<DateTimeOffset> changedTime = default;
            Core.Optional<BinaryData> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assemblyName"u8))
                {
                    assemblyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyVersion"u8))
                {
                    assemblyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyCulture"u8))
                {
                    assemblyCulture = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assemblyPublicKeyToken"u8))
                {
                    assemblyPublicKeyToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentType = new ContentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("contentLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentLink = LogicContentLink.DeserializeLogicContentLink(property.Value);
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("changedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new IntegrationAccountAssemblyProperties(Core.Optional.ToNullable(createdTime), Core.Optional.ToNullable(changedTime), metadata.Value, content.Value, Core.Optional.ToNullable(contentType), contentLink.Value, assemblyName, assemblyVersion.Value, assemblyCulture.Value, assemblyPublicKeyToken.Value);
        }
    }
}
