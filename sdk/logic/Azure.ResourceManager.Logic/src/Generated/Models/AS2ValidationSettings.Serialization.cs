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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2ValidationSettings : IUtf8JsonSerializable, IModelJsonSerializable<AS2ValidationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AS2ValidationSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AS2ValidationSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("overrideMessageProperties"u8);
            writer.WriteBooleanValue(OverrideMessageProperties);
            writer.WritePropertyName("encryptMessage"u8);
            writer.WriteBooleanValue(EncryptMessage);
            writer.WritePropertyName("signMessage"u8);
            writer.WriteBooleanValue(SignMessage);
            writer.WritePropertyName("compressMessage"u8);
            writer.WriteBooleanValue(CompressMessage);
            writer.WritePropertyName("checkDuplicateMessage"u8);
            writer.WriteBooleanValue(CheckDuplicateMessage);
            writer.WritePropertyName("interchangeDuplicatesValidityDays"u8);
            writer.WriteNumberValue(InterchangeDuplicatesValidityDays);
            writer.WritePropertyName("checkCertificateRevocationListOnSend"u8);
            writer.WriteBooleanValue(CheckCertificateRevocationListOnSend);
            writer.WritePropertyName("checkCertificateRevocationListOnReceive"u8);
            writer.WriteBooleanValue(CheckCertificateRevocationListOnReceive);
            writer.WritePropertyName("encryptionAlgorithm"u8);
            writer.WriteStringValue(EncryptionAlgorithm.ToString());
            if (Optional.IsDefined(SigningAlgorithm))
            {
                writer.WritePropertyName("signingAlgorithm"u8);
                writer.WriteStringValue(SigningAlgorithm.Value.ToString());
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

        internal static AS2ValidationSettings DeserializeAS2ValidationSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool overrideMessageProperties = default;
            bool encryptMessage = default;
            bool signMessage = default;
            bool compressMessage = default;
            bool checkDuplicateMessage = default;
            int interchangeDuplicatesValidityDays = default;
            bool checkCertificateRevocationListOnSend = default;
            bool checkCertificateRevocationListOnReceive = default;
            AS2EncryptionAlgorithm encryptionAlgorithm = default;
            Optional<AS2SigningAlgorithm> signingAlgorithm = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("overrideMessageProperties"u8))
                {
                    overrideMessageProperties = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptMessage"u8))
                {
                    encryptMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("signMessage"u8))
                {
                    signMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("compressMessage"u8))
                {
                    compressMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("checkDuplicateMessage"u8))
                {
                    checkDuplicateMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("interchangeDuplicatesValidityDays"u8))
                {
                    interchangeDuplicatesValidityDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("checkCertificateRevocationListOnSend"u8))
                {
                    checkCertificateRevocationListOnSend = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("checkCertificateRevocationListOnReceive"u8))
                {
                    checkCertificateRevocationListOnReceive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionAlgorithm"u8))
                {
                    encryptionAlgorithm = new AS2EncryptionAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signingAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signingAlgorithm = new AS2SigningAlgorithm(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AS2ValidationSettings(overrideMessageProperties, encryptMessage, signMessage, compressMessage, checkDuplicateMessage, interchangeDuplicatesValidityDays, checkCertificateRevocationListOnSend, checkCertificateRevocationListOnReceive, encryptionAlgorithm, Optional.ToNullable(signingAlgorithm), rawData);
        }

        AS2ValidationSettings IModelJsonSerializable<AS2ValidationSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAS2ValidationSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AS2ValidationSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AS2ValidationSettings IModelSerializable<AS2ValidationSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAS2ValidationSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AS2ValidationSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AS2ValidationSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAS2ValidationSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
