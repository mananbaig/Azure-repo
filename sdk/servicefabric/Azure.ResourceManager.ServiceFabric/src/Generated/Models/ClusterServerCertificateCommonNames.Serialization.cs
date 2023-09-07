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
    public partial class ClusterServerCertificateCommonNames : IUtf8JsonSerializable, IModelJsonSerializable<ClusterServerCertificateCommonNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ClusterServerCertificateCommonNames>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ClusterServerCertificateCommonNames>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterServerCertificateCommonNames>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CommonNames))
            {
                writer.WritePropertyName("commonNames"u8);
                writer.WriteStartArray();
                foreach (var item in CommonNames)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ClusterServerCertificateCommonName>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(X509StoreName))
            {
                writer.WritePropertyName("x509StoreName"u8);
                writer.WriteStringValue(X509StoreName.Value.ToString());
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

        internal static ClusterServerCertificateCommonNames DeserializeClusterServerCertificateCommonNames(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ClusterServerCertificateCommonName>> commonNames = default;
            Optional<ClusterCertificateStoreName> x509StoreName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("commonNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterServerCertificateCommonName> array = new List<ClusterServerCertificateCommonName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterServerCertificateCommonName.DeserializeClusterServerCertificateCommonName(item));
                    }
                    commonNames = array;
                    continue;
                }
                if (property.NameEquals("x509StoreName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    x509StoreName = new ClusterCertificateStoreName(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ClusterServerCertificateCommonNames(Optional.ToList(commonNames), Optional.ToNullable(x509StoreName), serializedAdditionalRawData);
        }

        ClusterServerCertificateCommonNames IModelJsonSerializable<ClusterServerCertificateCommonNames>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterServerCertificateCommonNames>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterServerCertificateCommonNames(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ClusterServerCertificateCommonNames>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterServerCertificateCommonNames>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ClusterServerCertificateCommonNames IModelSerializable<ClusterServerCertificateCommonNames>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ClusterServerCertificateCommonNames>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeClusterServerCertificateCommonNames(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ClusterServerCertificateCommonNames"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ClusterServerCertificateCommonNames"/> to convert. </param>
        public static implicit operator RequestContent(ClusterServerCertificateCommonNames model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ClusterServerCertificateCommonNames"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ClusterServerCertificateCommonNames(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeClusterServerCertificateCommonNames(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
