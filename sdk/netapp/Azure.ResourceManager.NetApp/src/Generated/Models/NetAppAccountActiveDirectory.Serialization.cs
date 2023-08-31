// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppAccountActiveDirectory : IUtf8JsonSerializable, IModelJsonSerializable<NetAppAccountActiveDirectory>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetAppAccountActiveDirectory>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetAppAccountActiveDirectory>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveDirectoryId))
            {
                if (ActiveDirectoryId != null)
                {
                    writer.WritePropertyName("activeDirectoryId"u8);
                    writer.WriteStringValue(ActiveDirectoryId);
                }
                else
                {
                    writer.WriteNull("activeDirectoryId");
                }
            }
            if (Optional.IsDefined(Username))
            {
                writer.WritePropertyName("username"u8);
                writer.WriteStringValue(Username);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (Optional.IsDefined(Dns))
            {
                writer.WritePropertyName("dns"u8);
                writer.WriteStringValue(Dns);
            }
            if (Optional.IsDefined(SmbServerName))
            {
                writer.WritePropertyName("smbServerName"u8);
                writer.WriteStringValue(SmbServerName);
            }
            if (Optional.IsDefined(OrganizationalUnit))
            {
                writer.WritePropertyName("organizationalUnit"u8);
                writer.WriteStringValue(OrganizationalUnit);
            }
            if (Optional.IsDefined(Site))
            {
                writer.WritePropertyName("site"u8);
                writer.WriteStringValue(Site);
            }
            if (Optional.IsCollectionDefined(BackupOperators))
            {
                writer.WritePropertyName("backupOperators"u8);
                writer.WriteStartArray();
                foreach (var item in BackupOperators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Administrators))
            {
                writer.WritePropertyName("administrators"u8);
                writer.WriteStartArray();
                foreach (var item in Administrators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(KdcIP))
            {
                writer.WritePropertyName("kdcIP"u8);
                writer.WriteStringValue(KdcIP.ToString());
            }
            if (Optional.IsDefined(AdName))
            {
                writer.WritePropertyName("adName"u8);
                writer.WriteStringValue(AdName);
            }
            if (Optional.IsDefined(ServerRootCACertificate))
            {
                writer.WritePropertyName("serverRootCACertificate"u8);
                writer.WriteStringValue(ServerRootCACertificate);
            }
            if (Optional.IsDefined(IsAesEncryptionEnabled))
            {
                writer.WritePropertyName("aesEncryption"u8);
                writer.WriteBooleanValue(IsAesEncryptionEnabled.Value);
            }
            if (Optional.IsDefined(IsLdapSigningEnabled))
            {
                writer.WritePropertyName("ldapSigning"u8);
                writer.WriteBooleanValue(IsLdapSigningEnabled.Value);
            }
            if (Optional.IsCollectionDefined(SecurityOperators))
            {
                writer.WritePropertyName("securityOperators"u8);
                writer.WriteStartArray();
                foreach (var item in SecurityOperators)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsLdapOverTlsEnabled))
            {
                writer.WritePropertyName("ldapOverTLS"u8);
                writer.WriteBooleanValue(IsLdapOverTlsEnabled.Value);
            }
            if (Optional.IsDefined(AllowLocalNfsUsersWithLdap))
            {
                writer.WritePropertyName("allowLocalNfsUsersWithLdap"u8);
                writer.WriteBooleanValue(AllowLocalNfsUsersWithLdap.Value);
            }
            if (Optional.IsDefined(EncryptDCConnections))
            {
                writer.WritePropertyName("encryptDCConnections"u8);
                writer.WriteBooleanValue(EncryptDCConnections.Value);
            }
            if (Optional.IsDefined(LdapSearchScope))
            {
                writer.WritePropertyName("ldapSearchScope"u8);
                if (LdapSearchScope is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NetAppLdapSearchScopeConfiguration>)LdapSearchScope).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(PreferredServersForLdapClient))
            {
                writer.WritePropertyName("preferredServersForLdapClient"u8);
                writer.WriteStringValue(PreferredServersForLdapClient);
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

        internal static NetAppAccountActiveDirectory DeserializeNetAppAccountActiveDirectory(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> activeDirectoryId = default;
            Optional<string> username = default;
            Optional<string> password = default;
            Optional<string> domain = default;
            Optional<string> dns = default;
            Optional<NetAppAccountActiveDirectoryStatus> status = default;
            Optional<string> statusDetails = default;
            Optional<string> smbServerName = default;
            Optional<string> organizationalUnit = default;
            Optional<string> site = default;
            Optional<IList<string>> backupOperators = default;
            Optional<IList<string>> administrators = default;
            Optional<IPAddress> kdcIP = default;
            Optional<string> adName = default;
            Optional<string> serverRootCACertificate = default;
            Optional<bool> aesEncryption = default;
            Optional<bool> ldapSigning = default;
            Optional<IList<string>> securityOperators = default;
            Optional<bool> ldapOverTls = default;
            Optional<bool> allowLocalNfsUsersWithLdap = default;
            Optional<bool> encryptDCConnections = default;
            Optional<NetAppLdapSearchScopeConfiguration> ldapSearchScope = default;
            Optional<string> preferredServersForLdapClient = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeDirectoryId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        activeDirectoryId = null;
                        continue;
                    }
                    activeDirectoryId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("username"u8))
                {
                    username = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dns"u8))
                {
                    dns = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new NetAppAccountActiveDirectoryStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusDetails"u8))
                {
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("smbServerName"u8))
                {
                    smbServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("organizationalUnit"u8))
                {
                    organizationalUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("site"u8))
                {
                    site = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupOperators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    backupOperators = array;
                    continue;
                }
                if (property.NameEquals("administrators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    administrators = array;
                    continue;
                }
                if (property.NameEquals("kdcIP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kdcIP = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adName"u8))
                {
                    adName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverRootCACertificate"u8))
                {
                    serverRootCACertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aesEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    aesEncryption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapSigning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapSigning = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("securityOperators"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    securityOperators = array;
                    continue;
                }
                if (property.NameEquals("ldapOverTLS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapOverTls = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowLocalNfsUsersWithLdap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowLocalNfsUsersWithLdap = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptDCConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptDCConnections = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapSearchScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapSearchScope = NetAppLdapSearchScopeConfiguration.DeserializeNetAppLdapSearchScopeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("preferredServersForLdapClient"u8))
                {
                    preferredServersForLdapClient = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppAccountActiveDirectory(activeDirectoryId.Value, username.Value, password.Value, domain.Value, dns.Value, Optional.ToNullable(status), statusDetails.Value, smbServerName.Value, organizationalUnit.Value, site.Value, Optional.ToList(backupOperators), Optional.ToList(administrators), kdcIP.Value, adName.Value, serverRootCACertificate.Value, Optional.ToNullable(aesEncryption), Optional.ToNullable(ldapSigning), Optional.ToList(securityOperators), Optional.ToNullable(ldapOverTls), Optional.ToNullable(allowLocalNfsUsersWithLdap), Optional.ToNullable(encryptDCConnections), ldapSearchScope.Value, preferredServersForLdapClient.Value, rawData);
        }

        NetAppAccountActiveDirectory IModelJsonSerializable<NetAppAccountActiveDirectory>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppAccountActiveDirectory(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppAccountActiveDirectory>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppAccountActiveDirectory IModelSerializable<NetAppAccountActiveDirectory>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppAccountActiveDirectory(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetAppAccountActiveDirectory"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetAppAccountActiveDirectory"/> to convert. </param>
        public static implicit operator RequestContent(NetAppAccountActiveDirectory model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetAppAccountActiveDirectory"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetAppAccountActiveDirectory(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppAccountActiveDirectory(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
