// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class WebLinkedServiceTypeProperties : IUtf8JsonSerializable, IModelJsonSerializable<WebLinkedServiceTypeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebLinkedServiceTypeProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebLinkedServiceTypeProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            JsonSerializer.Serialize(writer, Uri);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
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

        internal static WebLinkedServiceTypeProperties DeserializeWebLinkedServiceTypeProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authenticationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Anonymous": return WebAnonymousAuthentication.DeserializeWebAnonymousAuthentication(element);
                    case "Basic": return WebBasicAuthentication.DeserializeWebBasicAuthentication(element);
                    case "ClientCertificate": return WebClientCertificateAuthentication.DeserializeWebClientCertificateAuthentication(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            DataFactoryElement<string> url = default;
            WebAuthenticationType authenticationType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new WebAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownWebLinkedServiceTypeProperties(url, authenticationType, rawData);
        }

        WebLinkedServiceTypeProperties IModelJsonSerializable<WebLinkedServiceTypeProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebLinkedServiceTypeProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebLinkedServiceTypeProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebLinkedServiceTypeProperties IModelSerializable<WebLinkedServiceTypeProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebLinkedServiceTypeProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WebLinkedServiceTypeProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WebLinkedServiceTypeProperties"/> to convert. </param>
        public static implicit operator RequestContent(WebLinkedServiceTypeProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WebLinkedServiceTypeProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WebLinkedServiceTypeProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebLinkedServiceTypeProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
