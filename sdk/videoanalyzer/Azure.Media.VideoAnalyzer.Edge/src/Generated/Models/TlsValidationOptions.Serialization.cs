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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class TlsValidationOptions : IUtf8JsonSerializable, IModelJsonSerializable<TlsValidationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TlsValidationOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TlsValidationOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TlsValidationOptions>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IgnoreHostname))
            {
                writer.WritePropertyName("ignoreHostname"u8);
                writer.WriteStringValue(IgnoreHostname);
            }
            if (Optional.IsDefined(IgnoreSignature))
            {
                writer.WritePropertyName("ignoreSignature"u8);
                writer.WriteStringValue(IgnoreSignature);
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

        internal static TlsValidationOptions DeserializeTlsValidationOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ignoreHostname = default;
            Optional<string> ignoreSignature = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ignoreHostname"u8))
                {
                    ignoreHostname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ignoreSignature"u8))
                {
                    ignoreSignature = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TlsValidationOptions(ignoreHostname.Value, ignoreSignature.Value, serializedAdditionalRawData);
        }

        TlsValidationOptions IModelJsonSerializable<TlsValidationOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TlsValidationOptions>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTlsValidationOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TlsValidationOptions>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TlsValidationOptions>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TlsValidationOptions IModelSerializable<TlsValidationOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TlsValidationOptions>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTlsValidationOptions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TlsValidationOptions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TlsValidationOptions"/> to convert. </param>
        public static implicit operator RequestContent(TlsValidationOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TlsValidationOptions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TlsValidationOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTlsValidationOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
