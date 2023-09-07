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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterAaddsDetail : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightClusterAaddsDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightClusterAaddsDetail>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightClusterAaddsDetail>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterAaddsDetail>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsDefined(IsInitialSyncComplete))
            {
                writer.WritePropertyName("initialSyncComplete"u8);
                writer.WriteBooleanValue(IsInitialSyncComplete.Value);
            }
            if (Optional.IsDefined(IsLdapsEnabled))
            {
                writer.WritePropertyName("ldapsEnabled"u8);
                writer.WriteBooleanValue(IsLdapsEnabled.Value);
            }
            if (Optional.IsDefined(LdapsPublicCertificateInBase64))
            {
                writer.WritePropertyName("ldapsPublicCertificateInBase64"u8);
                writer.WriteStringValue(LdapsPublicCertificateInBase64);
            }
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
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

        internal static HDInsightClusterAaddsDetail DeserializeHDInsightClusterAaddsDetail(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> domainName = default;
            Optional<bool> initialSyncComplete = default;
            Optional<bool> ldapsEnabled = default;
            Optional<string> ldapsPublicCertificateInBase64 = default;
            Optional<ResourceIdentifier> resourceId = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<Guid> tenantId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialSyncComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialSyncComplete = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapsEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ldapsEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ldapsPublicCertificateInBase64"u8))
                {
                    ldapsPublicCertificateInBase64 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightClusterAaddsDetail(domainName.Value, Optional.ToNullable(initialSyncComplete), Optional.ToNullable(ldapsEnabled), ldapsPublicCertificateInBase64.Value, resourceId.Value, subnetId.Value, Optional.ToNullable(tenantId), serializedAdditionalRawData);
        }

        HDInsightClusterAaddsDetail IModelJsonSerializable<HDInsightClusterAaddsDetail>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterAaddsDetail>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterAaddsDetail(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightClusterAaddsDetail>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterAaddsDetail>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightClusterAaddsDetail IModelSerializable<HDInsightClusterAaddsDetail>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterAaddsDetail>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightClusterAaddsDetail(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightClusterAaddsDetail"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightClusterAaddsDetail"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightClusterAaddsDetail model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightClusterAaddsDetail"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightClusterAaddsDetail(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightClusterAaddsDetail(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
