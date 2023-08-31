// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class AuthenticationMethodLdapProperties : IUtf8JsonSerializable, IModelJsonSerializable<AuthenticationMethodLdapProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AuthenticationMethodLdapProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AuthenticationMethodLdapProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ServerHostname))
            {
                writer.WritePropertyName("serverHostname"u8);
                writer.WriteStringValue(ServerHostname);
            }
            if (Optional.IsDefined(ServerPort))
            {
                writer.WritePropertyName("serverPort"u8);
                writer.WriteNumberValue(ServerPort.Value);
            }
            if (Optional.IsDefined(ServiceUserDistinguishedName))
            {
                writer.WritePropertyName("serviceUserDistinguishedName"u8);
                writer.WriteStringValue(ServiceUserDistinguishedName);
            }
            if (Optional.IsDefined(ServiceUserPassword))
            {
                writer.WritePropertyName("serviceUserPassword"u8);
                writer.WriteStringValue(ServiceUserPassword);
            }
            if (Optional.IsDefined(SearchBaseDistinguishedName))
            {
                writer.WritePropertyName("searchBaseDistinguishedName"u8);
                writer.WriteStringValue(SearchBaseDistinguishedName);
            }
            if (Optional.IsDefined(SearchFilterTemplate))
            {
                writer.WritePropertyName("searchFilterTemplate"u8);
                writer.WriteStringValue(SearchFilterTemplate);
            }
            if (Optional.IsCollectionDefined(ServerCertificates))
            {
                writer.WritePropertyName("serverCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in ServerCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ConnectionTimeoutInMs))
            {
                writer.WritePropertyName("connectionTimeoutInMs"u8);
                writer.WriteNumberValue(ConnectionTimeoutInMs.Value);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AuthenticationMethodLdapProperties DeserializeAuthenticationMethodLdapProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serverHostname = default;
            Optional<int> serverPort = default;
            Optional<string> serviceUserDistinguishedName = default;
            Optional<string> serviceUserPassword = default;
            Optional<string> searchBaseDistinguishedName = default;
            Optional<string> searchFilterTemplate = default;
            Optional<IList<CassandraCertificate>> serverCertificates = default;
            Optional<int> connectionTimeoutInMs = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverHostname"u8))
                {
                    serverHostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("serviceUserDistinguishedName"u8))
                {
                    serviceUserDistinguishedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceUserPassword"u8))
                {
                    serviceUserPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchBaseDistinguishedName"u8))
                {
                    searchBaseDistinguishedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchFilterTemplate"u8))
                {
                    searchFilterTemplate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraCertificate> array = new List<CassandraCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraCertificate.DeserializeCassandraCertificate(item));
                    }
                    serverCertificates = array;
                    continue;
                }
                if (property.NameEquals("connectionTimeoutInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectionTimeoutInMs = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AuthenticationMethodLdapProperties(serverHostname.Value, Optional.ToNullable(serverPort), serviceUserDistinguishedName.Value, serviceUserPassword.Value, searchBaseDistinguishedName.Value, searchFilterTemplate.Value, Optional.ToList(serverCertificates), Optional.ToNullable(connectionTimeoutInMs), rawData);
        }

        AuthenticationMethodLdapProperties IModelJsonSerializable<AuthenticationMethodLdapProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAuthenticationMethodLdapProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AuthenticationMethodLdapProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AuthenticationMethodLdapProperties IModelSerializable<AuthenticationMethodLdapProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAuthenticationMethodLdapProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AuthenticationMethodLdapProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AuthenticationMethodLdapProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAuthenticationMethodLdapProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
