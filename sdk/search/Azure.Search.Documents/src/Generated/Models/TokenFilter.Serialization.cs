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
using Azure.Search.Documents.Models;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class TokenFilter : IUtf8JsonSerializable, IModelJsonSerializable<TokenFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TokenFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TokenFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TokenFilter>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        internal static TokenFilter DeserializeTokenFilter(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.AsciiFoldingTokenFilter": return AsciiFoldingTokenFilter.DeserializeAsciiFoldingTokenFilter(element);
                    case "#Microsoft.Azure.Search.CjkBigramTokenFilter": return CjkBigramTokenFilter.DeserializeCjkBigramTokenFilter(element);
                    case "#Microsoft.Azure.Search.CommonGramTokenFilter": return CommonGramTokenFilter.DeserializeCommonGramTokenFilter(element);
                    case "#Microsoft.Azure.Search.DictionaryDecompounderTokenFilter": return DictionaryDecompounderTokenFilter.DeserializeDictionaryDecompounderTokenFilter(element);
                    case "#Microsoft.Azure.Search.EdgeNGramTokenFilter": return EdgeNGramTokenFilter.DeserializeEdgeNGramTokenFilter(element);
                    case "#Microsoft.Azure.Search.EdgeNGramTokenFilterV2": return EdgeNGramTokenFilter.DeserializeEdgeNGramTokenFilter(element);
                    case "#Microsoft.Azure.Search.ElisionTokenFilter": return ElisionTokenFilter.DeserializeElisionTokenFilter(element);
                    case "#Microsoft.Azure.Search.KeepTokenFilter": return KeepTokenFilter.DeserializeKeepTokenFilter(element);
                    case "#Microsoft.Azure.Search.KeywordMarkerTokenFilter": return KeywordMarkerTokenFilter.DeserializeKeywordMarkerTokenFilter(element);
                    case "#Microsoft.Azure.Search.LengthTokenFilter": return LengthTokenFilter.DeserializeLengthTokenFilter(element);
                    case "#Microsoft.Azure.Search.LimitTokenFilter": return LimitTokenFilter.DeserializeLimitTokenFilter(element);
                    case "#Microsoft.Azure.Search.NGramTokenFilter": return NGramTokenFilter.DeserializeNGramTokenFilter(element);
                    case "#Microsoft.Azure.Search.NGramTokenFilterV2": return NGramTokenFilter.DeserializeNGramTokenFilter(element);
                    case "#Microsoft.Azure.Search.PatternCaptureTokenFilter": return PatternCaptureTokenFilter.DeserializePatternCaptureTokenFilter(element);
                    case "#Microsoft.Azure.Search.PatternReplaceTokenFilter": return PatternReplaceTokenFilter.DeserializePatternReplaceTokenFilter(element);
                    case "#Microsoft.Azure.Search.PhoneticTokenFilter": return PhoneticTokenFilter.DeserializePhoneticTokenFilter(element);
                    case "#Microsoft.Azure.Search.ShingleTokenFilter": return ShingleTokenFilter.DeserializeShingleTokenFilter(element);
                    case "#Microsoft.Azure.Search.SnowballTokenFilter": return SnowballTokenFilter.DeserializeSnowballTokenFilter(element);
                    case "#Microsoft.Azure.Search.StemmerOverrideTokenFilter": return StemmerOverrideTokenFilter.DeserializeStemmerOverrideTokenFilter(element);
                    case "#Microsoft.Azure.Search.StemmerTokenFilter": return StemmerTokenFilter.DeserializeStemmerTokenFilter(element);
                    case "#Microsoft.Azure.Search.StopwordsTokenFilter": return StopwordsTokenFilter.DeserializeStopwordsTokenFilter(element);
                    case "#Microsoft.Azure.Search.SynonymTokenFilter": return SynonymTokenFilter.DeserializeSynonymTokenFilter(element);
                    case "#Microsoft.Azure.Search.TruncateTokenFilter": return TruncateTokenFilter.DeserializeTruncateTokenFilter(element);
                    case "#Microsoft.Azure.Search.UniqueTokenFilter": return UniqueTokenFilter.DeserializeUniqueTokenFilter(element);
                    case "#Microsoft.Azure.Search.WordDelimiterTokenFilter": return WordDelimiterTokenFilter.DeserializeWordDelimiterTokenFilter(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string odataType = default;
            string name = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownTokenFilter(odataType, name, serializedAdditionalRawData);
        }

        TokenFilter IModelJsonSerializable<TokenFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TokenFilter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTokenFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TokenFilter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TokenFilter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TokenFilter IModelSerializable<TokenFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TokenFilter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTokenFilter(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TokenFilter"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TokenFilter"/> to convert. </param>
        public static implicit operator RequestContent(TokenFilter model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TokenFilter"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TokenFilter(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTokenFilter(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
