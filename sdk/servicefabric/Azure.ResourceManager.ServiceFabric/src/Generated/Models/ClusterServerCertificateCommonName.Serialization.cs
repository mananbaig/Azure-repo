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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterServerCertificateCommonName : IUtf8JsonSerializable, IModelJsonSerializable<ClusterServerCertificateCommonName>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClusterServerCertificateCommonName>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClusterServerCertificateCommonName>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterServerCertificateCommonName>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("certificateCommonName"u8);
            writer.WriteStringValue(CertificateCommonName);
            writer.WritePropertyName("certificateIssuerThumbprint"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CertificateIssuerThumbprint);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(CertificateIssuerThumbprint.ToString()).RootElement);
#endif
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

        internal static ClusterServerCertificateCommonName DeserializeClusterServerCertificateCommonName(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string certificateCommonName = default;
            BinaryData certificateIssuerThumbprint = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateCommonName"u8))
                {
                    certificateCommonName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificateIssuerThumbprint"u8))
                {
                    certificateIssuerThumbprint = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClusterServerCertificateCommonName(certificateCommonName, certificateIssuerThumbprint, serializedAdditionalRawData);
        }

        ClusterServerCertificateCommonName IModelJsonSerializable<ClusterServerCertificateCommonName>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterServerCertificateCommonName>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterServerCertificateCommonName(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClusterServerCertificateCommonName>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterServerCertificateCommonName>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClusterServerCertificateCommonName IModelSerializable<ClusterServerCertificateCommonName>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterServerCertificateCommonName>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClusterServerCertificateCommonName(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClusterServerCertificateCommonName"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClusterServerCertificateCommonName"/> to convert. </param>
        public static implicit operator RequestContent(ClusterServerCertificateCommonName model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClusterServerCertificateCommonName"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClusterServerCertificateCommonName(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClusterServerCertificateCommonName(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
