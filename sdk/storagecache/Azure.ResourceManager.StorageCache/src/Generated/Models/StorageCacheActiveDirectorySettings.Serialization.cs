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

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheActiveDirectorySettings : IUtf8JsonSerializable, IModelJsonSerializable<StorageCacheActiveDirectorySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageCacheActiveDirectorySettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageCacheActiveDirectorySettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheActiveDirectorySettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("primaryDnsIpAddress"u8);
            writer.WriteStringValue(PrimaryDnsIPAddress.ToString());
            if (Optional.IsDefined(SecondaryDnsIPAddress))
            {
                writer.WritePropertyName("secondaryDnsIpAddress"u8);
                writer.WriteStringValue(SecondaryDnsIPAddress.ToString());
            }
            writer.WritePropertyName("domainName"u8);
            writer.WriteStringValue(DomainName);
            writer.WritePropertyName("domainNetBiosName"u8);
            writer.WriteStringValue(DomainNetBiosName);
            writer.WritePropertyName("cacheNetBiosName"u8);
            writer.WriteStringValue(CacheNetBiosName);
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                if (Credentials is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageCacheActiveDirectorySettingsCredentials>)Credentials).Serialize(writer, options);
                }
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static StorageCacheActiveDirectorySettings DeserializeStorageCacheActiveDirectorySettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IPAddress primaryDnsIPAddress = default;
            Optional<IPAddress> secondaryDnsIPAddress = default;
            string domainName = default;
            string domainNetBiosName = default;
            string cacheNetBiosName = default;
            Optional<DomainJoinedType> domainJoined = default;
            Optional<StorageCacheActiveDirectorySettingsCredentials> credentials = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryDnsIpAddress"u8))
                {
                    primaryDnsIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("secondaryDnsIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryDnsIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainNetBiosName"u8))
                {
                    domainNetBiosName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cacheNetBiosName"u8))
                {
                    cacheNetBiosName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domainJoined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domainJoined = new DomainJoinedType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = StorageCacheActiveDirectorySettingsCredentials.DeserializeStorageCacheActiveDirectorySettingsCredentials(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageCacheActiveDirectorySettings(primaryDnsIPAddress, secondaryDnsIPAddress.Value, domainName, domainNetBiosName, cacheNetBiosName, Optional.ToNullable(domainJoined), credentials.Value, serializedAdditionalRawData);
        }

        StorageCacheActiveDirectorySettings IModelJsonSerializable<StorageCacheActiveDirectorySettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheActiveDirectorySettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheActiveDirectorySettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageCacheActiveDirectorySettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheActiveDirectorySettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageCacheActiveDirectorySettings IModelSerializable<StorageCacheActiveDirectorySettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheActiveDirectorySettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageCacheActiveDirectorySettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageCacheActiveDirectorySettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageCacheActiveDirectorySettings"/> to convert. </param>
        public static implicit operator RequestContent(StorageCacheActiveDirectorySettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageCacheActiveDirectorySettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageCacheActiveDirectorySettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageCacheActiveDirectorySettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
