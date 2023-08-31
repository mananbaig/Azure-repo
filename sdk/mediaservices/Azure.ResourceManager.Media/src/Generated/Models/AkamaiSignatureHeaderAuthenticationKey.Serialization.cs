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

namespace Azure.ResourceManager.Media.Models
{
    public partial class AkamaiSignatureHeaderAuthenticationKey : IUtf8JsonSerializable, IModelJsonSerializable<AkamaiSignatureHeaderAuthenticationKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AkamaiSignatureHeaderAuthenticationKey>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AkamaiSignatureHeaderAuthenticationKey>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteStringValue(Identifier);
            }
            if (Optional.IsDefined(Base64Key))
            {
                writer.WritePropertyName("base64Key"u8);
                writer.WriteStringValue(Base64Key);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiration"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
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

        internal static AkamaiSignatureHeaderAuthenticationKey DeserializeAkamaiSignatureHeaderAuthenticationKey(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> identifier = default;
            Optional<string> base64Key = default;
            Optional<DateTimeOffset> expiration = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"u8))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("base64Key"u8))
                {
                    base64Key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiration = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AkamaiSignatureHeaderAuthenticationKey(identifier.Value, base64Key.Value, Optional.ToNullable(expiration), rawData);
        }

        AkamaiSignatureHeaderAuthenticationKey IModelJsonSerializable<AkamaiSignatureHeaderAuthenticationKey>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAkamaiSignatureHeaderAuthenticationKey(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AkamaiSignatureHeaderAuthenticationKey>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AkamaiSignatureHeaderAuthenticationKey IModelSerializable<AkamaiSignatureHeaderAuthenticationKey>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAkamaiSignatureHeaderAuthenticationKey(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AkamaiSignatureHeaderAuthenticationKey model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AkamaiSignatureHeaderAuthenticationKey(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAkamaiSignatureHeaderAuthenticationKey(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
