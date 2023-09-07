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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceAppendTags : IUtf8JsonSerializable, IModelJsonSerializable<ThreatIntelligenceAppendTags>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ThreatIntelligenceAppendTags>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ThreatIntelligenceAppendTags>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ThreatIntelligenceAppendTags>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ThreatIntelligenceTags))
            {
                writer.WritePropertyName("threatIntelligenceTags"u8);
                writer.WriteStartArray();
                foreach (var item in ThreatIntelligenceTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static ThreatIntelligenceAppendTags DeserializeThreatIntelligenceAppendTags(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> threatIntelligenceTags = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("threatIntelligenceTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    threatIntelligenceTags = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ThreatIntelligenceAppendTags(Optional.ToList(threatIntelligenceTags), serializedAdditionalRawData);
        }

        ThreatIntelligenceAppendTags IModelJsonSerializable<ThreatIntelligenceAppendTags>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ThreatIntelligenceAppendTags>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceAppendTags(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ThreatIntelligenceAppendTags>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ThreatIntelligenceAppendTags>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ThreatIntelligenceAppendTags IModelSerializable<ThreatIntelligenceAppendTags>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ThreatIntelligenceAppendTags>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeThreatIntelligenceAppendTags(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ThreatIntelligenceAppendTags"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ThreatIntelligenceAppendTags"/> to convert. </param>
        public static implicit operator RequestContent(ThreatIntelligenceAppendTags model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ThreatIntelligenceAppendTags"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ThreatIntelligenceAppendTags(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeThreatIntelligenceAppendTags(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
