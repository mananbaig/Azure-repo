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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ConnectorMappingFormat : IUtf8JsonSerializable, IModelJsonSerializable<ConnectorMappingFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConnectorMappingFormat>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConnectorMappingFormat>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("formatType"u8);
            writer.WriteStringValue(FormatType.ToString());
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter"u8);
                writer.WriteStringValue(ColumnDelimiter);
            }
            if (Optional.IsDefined(AcceptLanguage))
            {
                writer.WritePropertyName("acceptLanguage"u8);
                writer.WriteStringValue(AcceptLanguage);
            }
            if (Optional.IsDefined(QuoteCharacter))
            {
                writer.WritePropertyName("quoteCharacter"u8);
                writer.WriteStringValue(QuoteCharacter);
            }
            if (Optional.IsDefined(QuoteEscapeCharacter))
            {
                writer.WritePropertyName("quoteEscapeCharacter"u8);
                writer.WriteStringValue(QuoteEscapeCharacter);
            }
            if (Optional.IsDefined(ArraySeparator))
            {
                writer.WritePropertyName("arraySeparator"u8);
                writer.WriteStringValue(ArraySeparator);
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

        internal static ConnectorMappingFormat DeserializeConnectorMappingFormat(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FormatType formatType = default;
            Optional<string> columnDelimiter = default;
            Optional<string> acceptLanguage = default;
            Optional<string> quoteCharacter = default;
            Optional<string> quoteEscapeCharacter = default;
            Optional<string> arraySeparator = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatType"u8))
                {
                    formatType = new FormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("columnDelimiter"u8))
                {
                    columnDelimiter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acceptLanguage"u8))
                {
                    acceptLanguage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quoteCharacter"u8))
                {
                    quoteCharacter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quoteEscapeCharacter"u8))
                {
                    quoteEscapeCharacter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arraySeparator"u8))
                {
                    arraySeparator = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConnectorMappingFormat(formatType, columnDelimiter.Value, acceptLanguage.Value, quoteCharacter.Value, quoteEscapeCharacter.Value, arraySeparator.Value, rawData);
        }

        ConnectorMappingFormat IModelJsonSerializable<ConnectorMappingFormat>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectorMappingFormat(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConnectorMappingFormat>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConnectorMappingFormat IModelSerializable<ConnectorMappingFormat>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConnectorMappingFormat(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConnectorMappingFormat"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConnectorMappingFormat"/> to convert. </param>
        public static implicit operator RequestContent(ConnectorMappingFormat model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConnectorMappingFormat"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConnectorMappingFormat(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConnectorMappingFormat(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
