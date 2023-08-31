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

namespace Azure.Containers.ContainerRegistry
{
    internal partial class JWKHeader : IUtf8JsonSerializable, IModelJsonSerializable<JWKHeader>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JWKHeader>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JWKHeader>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Crv))
            {
                writer.WritePropertyName("crv"u8);
                writer.WriteStringValue(Crv);
            }
            if (Optional.IsDefined(Kid))
            {
                writer.WritePropertyName("kid"u8);
                writer.WriteStringValue(Kid);
            }
            if (Optional.IsDefined(Kty))
            {
                writer.WritePropertyName("kty"u8);
                writer.WriteStringValue(Kty);
            }
            if (Optional.IsDefined(X))
            {
                writer.WritePropertyName("x"u8);
                writer.WriteStringValue(X);
            }
            if (Optional.IsDefined(Y))
            {
                writer.WritePropertyName("y"u8);
                writer.WriteStringValue(Y);
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

        internal static JWKHeader DeserializeJWKHeader(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> crv = default;
            Optional<string> kid = default;
            Optional<string> kty = default;
            Optional<string> x = default;
            Optional<string> y = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("crv"u8))
                {
                    crv = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kid"u8))
                {
                    kid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kty"u8))
                {
                    kty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x"u8))
                {
                    x = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("y"u8))
                {
                    y = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JWKHeader(crv.Value, kid.Value, kty.Value, x.Value, y.Value, rawData);
        }

        JWKHeader IModelJsonSerializable<JWKHeader>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJWKHeader(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JWKHeader>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JWKHeader IModelSerializable<JWKHeader>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJWKHeader(doc.RootElement, options);
        }

        public static implicit operator RequestContent(JWKHeader model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator JWKHeader(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJWKHeader(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
