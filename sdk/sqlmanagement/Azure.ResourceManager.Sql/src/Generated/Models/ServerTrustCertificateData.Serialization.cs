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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class ServerTrustCertificateData : IUtf8JsonSerializable, IModelJsonSerializable<ServerTrustCertificateData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServerTrustCertificateData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServerTrustCertificateData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerTrustCertificateData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicBlob))
            {
                writer.WritePropertyName("publicBlob"u8);
                writer.WriteStringValue(PublicBlob);
            }
            writer.WriteEndObject();
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

        internal static ServerTrustCertificateData DeserializeServerTrustCertificateData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> publicBlob = default;
            Optional<string> thumbprint = default;
            Optional<string> certificateName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("publicBlob"u8))
                        {
                            publicBlob = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("thumbprint"u8))
                        {
                            thumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("certificateName"u8))
                        {
                            certificateName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServerTrustCertificateData(id, name, type, systemData.Value, publicBlob.Value, thumbprint.Value, certificateName.Value, serializedAdditionalRawData);
        }

        ServerTrustCertificateData IModelJsonSerializable<ServerTrustCertificateData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerTrustCertificateData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServerTrustCertificateData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServerTrustCertificateData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerTrustCertificateData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServerTrustCertificateData IModelSerializable<ServerTrustCertificateData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerTrustCertificateData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServerTrustCertificateData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServerTrustCertificateData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServerTrustCertificateData"/> to convert. </param>
        public static implicit operator RequestContent(ServerTrustCertificateData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServerTrustCertificateData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServerTrustCertificateData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServerTrustCertificateData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
