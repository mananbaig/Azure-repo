// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class CacheActiveDirectorySettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("primaryDnsIpAddress");
            writer.WriteStringValue(PrimaryDnsIPAddress);
            if (Optional.IsDefined(SecondaryDnsIPAddress))
            {
                writer.WritePropertyName("secondaryDnsIpAddress");
                writer.WriteStringValue(SecondaryDnsIPAddress);
            }
            writer.WritePropertyName("domainName");
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("domainNetBiosName");
            writer.WriteStringValue(DomainNetBiosName);
            writer.WritePropertyName("cacheNetBiosName");
            writer.WriteStringValue(CacheNetBiosName);
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials");
                writer.WriteObjectValue(Credentials);
            }
            writer.WriteEndObject();
        }

        internal static CacheActiveDirectorySettings DeserializeCacheActiveDirectorySettings(JsonElement element)
        {
            string primaryDnsIPAddress = default;
            Optional<string> secondaryDnsIPAddress = default;
            string domainName = default;
            string domainNetBiosName = default;
            string cacheNetBiosName = default;
            Optional<DomainJoinedType> domainJoined = default;
            Optional<CacheActiveDirectorySettingsCredentials> credentials = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryDnsIpAddress"))
                {
                    primaryDnsIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryDnsIpAddress"))
                {
                    secondaryDnsIPAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainName"))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainNetBiosName"))
                {
                    domainNetBiosName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cacheNetBiosName"))
                {
                    cacheNetBiosName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainJoined"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    domainJoined = new DomainJoinedType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    credentials = CacheActiveDirectorySettingsCredentials.DeserializeCacheActiveDirectorySettingsCredentials(property.Value);
                    continue;
                }
            }
            return new CacheActiveDirectorySettings(primaryDnsIPAddress, secondaryDnsIPAddress.Value, domainName, domainNetBiosName, cacheNetBiosName, Optional.ToNullable(domainJoined), credentials.Value);
        }
    }
}
