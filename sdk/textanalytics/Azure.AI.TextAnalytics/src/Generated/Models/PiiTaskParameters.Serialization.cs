// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.TextAnalytics;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class PiiTaskParameters : IUtf8JsonSerializable, IModelJsonSerializable<PiiTaskParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PiiTaskParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PiiTaskParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PiiTaskParameters>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain.Value.ToString());
            }
            if (Optional.IsCollectionDefined(PiiCategories))
            {
                writer.WritePropertyName("piiCategories"u8);
                writer.WriteStartArray();
                foreach (var item in PiiCategories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StringIndexType))
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
            }
            if (Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("modelVersion"u8);
                writer.WriteStringValue(ModelVersion);
            }
            if (Optional.IsDefined(LoggingOptOut))
            {
                writer.WritePropertyName("loggingOptOut"u8);
                writer.WriteBooleanValue(LoggingOptOut.Value);
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

        internal static PiiTaskParameters DeserializePiiTaskParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PiiDomain> domain = default;
            Optional<IList<PiiEntityCategory>> piiCategories = default;
            Optional<StringIndexType> stringIndexType = default;
            Optional<string> modelVersion = default;
            Optional<bool> loggingOptOut = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domain = new PiiDomain(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("piiCategories"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PiiEntityCategory> array = new List<PiiEntityCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PiiEntityCategory(item.GetString()));
                    }
                    piiCategories = array;
                    continue;
                }
                if (property.NameEquals("stringIndexType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingOptOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingOptOut = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PiiTaskParameters(Optional.ToNullable(loggingOptOut), modelVersion.Value, Optional.ToNullable(domain), Optional.ToList(piiCategories), Optional.ToNullable(stringIndexType), serializedAdditionalRawData);
        }

        PiiTaskParameters IModelJsonSerializable<PiiTaskParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PiiTaskParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePiiTaskParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PiiTaskParameters>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PiiTaskParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PiiTaskParameters IModelSerializable<PiiTaskParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PiiTaskParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePiiTaskParameters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PiiTaskParameters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PiiTaskParameters"/> to convert. </param>
        public static implicit operator RequestContent(PiiTaskParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PiiTaskParameters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PiiTaskParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePiiTaskParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
