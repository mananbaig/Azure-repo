// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningServicePrincipalDatastoreCredentials : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AuthorityUri))
            {
                if (AuthorityUri != null)
                {
                    writer.WritePropertyName("authorityUrl"u8);
                    writer.WriteStringValue(AuthorityUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("authorityUrl");
                }
            }
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            if (Core.Optional.IsDefined(ResourceUri))
            {
                if (ResourceUri != null)
                {
                    writer.WritePropertyName("resourceUrl"u8);
                    writer.WriteStringValue(ResourceUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("resourceUrl");
                }
            }
            writer.WritePropertyName("secrets"u8);
            writer.WriteObjectValue(Secrets);
            writer.WritePropertyName("tenantId"u8);
            writer.WriteStringValue(TenantId);
            writer.WritePropertyName("credentialsType"u8);
            writer.WriteStringValue(CredentialsType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningServicePrincipalDatastoreCredentials DeserializeMachineLearningServicePrincipalDatastoreCredentials(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Uri> authorityUrl = default;
            Guid clientId = default;
            Core.Optional<Uri> resourceUrl = default;
            MachineLearningServicePrincipalDatastoreSecrets secrets = default;
            Guid tenantId = default;
            CredentialsType credentialsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorityUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        authorityUrl = null;
                        continue;
                    }
                    authorityUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceUrl = null;
                        continue;
                    }
                    resourceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secrets"u8))
                {
                    secrets = MachineLearningServicePrincipalDatastoreSecrets.DeserializeMachineLearningServicePrincipalDatastoreSecrets(property.Value);
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("credentialsType"u8))
                {
                    credentialsType = new CredentialsType(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningServicePrincipalDatastoreCredentials(credentialsType, authorityUrl.Value, clientId, resourceUrl.Value, secrets, tenantId);
        }
    }
}
