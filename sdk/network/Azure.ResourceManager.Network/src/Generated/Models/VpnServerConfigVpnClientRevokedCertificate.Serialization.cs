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

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnServerConfigVpnClientRevokedCertificate : IUtf8JsonSerializable, IModelJsonSerializable<VpnServerConfigVpnClientRevokedCertificate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VpnServerConfigVpnClientRevokedCertificate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VpnServerConfigVpnClientRevokedCertificate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
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

        internal static VpnServerConfigVpnClientRevokedCertificate DeserializeVpnServerConfigVpnClientRevokedCertificate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> thumbprint = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VpnServerConfigVpnClientRevokedCertificate(name.Value, thumbprint.Value, rawData);
        }

        VpnServerConfigVpnClientRevokedCertificate IModelJsonSerializable<VpnServerConfigVpnClientRevokedCertificate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnServerConfigVpnClientRevokedCertificate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VpnServerConfigVpnClientRevokedCertificate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VpnServerConfigVpnClientRevokedCertificate IModelSerializable<VpnServerConfigVpnClientRevokedCertificate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVpnServerConfigVpnClientRevokedCertificate(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VpnServerConfigVpnClientRevokedCertificate"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VpnServerConfigVpnClientRevokedCertificate"/> to convert. </param>
        public static implicit operator RequestContent(VpnServerConfigVpnClientRevokedCertificate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VpnServerConfigVpnClientRevokedCertificate"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VpnServerConfigVpnClientRevokedCertificate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVpnServerConfigVpnClientRevokedCertificate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
