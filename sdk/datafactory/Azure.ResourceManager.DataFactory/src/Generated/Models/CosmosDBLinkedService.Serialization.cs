// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CosmosDBLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(LinkedServiceType);
            if (Optional.IsDefined(ConnectVia))
            {
                writer.WritePropertyName("connectVia");
                writer.WriteObjectValue(ConnectVia);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations");
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ConnectionString);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ConnectionString.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AccountEndpoint))
            {
                writer.WritePropertyName("accountEndpoint");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AccountEndpoint);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AccountEndpoint.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Database))
            {
                writer.WritePropertyName("database");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Database);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Database.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey");
                writer.WriteObjectValue(AccountKey);
            }
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ServicePrincipalId);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ServicePrincipalId.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ServicePrincipalCredentialType))
            {
                writer.WritePropertyName("servicePrincipalCredentialType");
                writer.WriteStringValue(ServicePrincipalCredentialType.Value.ToString());
            }
            if (Optional.IsDefined(ServicePrincipalCredential))
            {
                writer.WritePropertyName("servicePrincipalCredential");
                writer.WriteObjectValue(ServicePrincipalCredential);
            }
            if (Optional.IsDefined(Tenant))
            {
                writer.WritePropertyName("tenant");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Tenant);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Tenant.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AzureCloudType))
            {
                writer.WritePropertyName("azureCloudType");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AzureCloudType);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AzureCloudType.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ConnectionMode))
            {
                writer.WritePropertyName("connectionMode");
                writer.WriteStringValue(ConnectionMode.Value.ToString());
            }
            if (Optional.IsDefined(EncryptedCredential))
            {
                writer.WritePropertyName("encryptedCredential");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(EncryptedCredential);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(EncryptedCredential.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential");
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBLinkedService DeserializeCosmosDBLinkedService(JsonElement element)
        {
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<BinaryData> connectionString = default;
            Optional<BinaryData> accountEndpoint = default;
            Optional<BinaryData> database = default;
            Optional<FactorySecretBaseDefinition> accountKey = default;
            Optional<BinaryData> servicePrincipalId = default;
            Optional<CosmosDBServicePrincipalCredentialType> servicePrincipalCredentialType = default;
            Optional<FactorySecretBaseDefinition> servicePrincipalCredential = default;
            Optional<BinaryData> tenant = default;
            Optional<BinaryData> azureCloudType = default;
            Optional<CosmosDBConnectionMode> connectionMode = default;
            Optional<BinaryData> encryptedCredential = default;
            Optional<FactoryCredentialReference> credential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BinaryData.FromString(item.GetRawText()));
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("connectionString"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectionString = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accountEndpoint"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accountEndpoint = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("database"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            database = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accountKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            accountKey = FactorySecretBaseDefinition.DeserializeFactorySecretBaseDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            servicePrincipalId = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredentialType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            servicePrincipalCredentialType = new CosmosDBServicePrincipalCredentialType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipalCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            servicePrincipalCredential = FactorySecretBaseDefinition.DeserializeFactorySecretBaseDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("tenant"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tenant = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("azureCloudType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            azureCloudType = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("connectionMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            connectionMode = new CosmosDBConnectionMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            encryptedCredential = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("credential"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            credential = FactoryCredentialReference.DeserializeFactoryCredentialReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CosmosDBLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), Optional.ToList(annotations), additionalProperties, connectionString.Value, accountEndpoint.Value, database.Value, accountKey.Value, servicePrincipalId.Value, Optional.ToNullable(servicePrincipalCredentialType), servicePrincipalCredential.Value, tenant.Value, azureCloudType.Value, Optional.ToNullable(connectionMode), encryptedCredential.Value, credential.Value);
        }
    }
}
