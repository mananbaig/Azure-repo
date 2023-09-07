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
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    internal partial class HDInsightPrivateLinkResourceListResult : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightPrivateLinkResourceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightPrivateLinkResourceListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightPrivateLinkResourceListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightPrivateLinkResourceListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<HDInsightPrivateLinkResourceData>)item).Serialize(writer, options);
                    }
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

        internal static HDInsightPrivateLinkResourceListResult DeserializeHDInsightPrivateLinkResourceListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<HDInsightPrivateLinkResourceData>> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HDInsightPrivateLinkResourceData> array = new List<HDInsightPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HDInsightPrivateLinkResourceData.DeserializeHDInsightPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightPrivateLinkResourceListResult(Optional.ToList(value), serializedAdditionalRawData);
        }

        HDInsightPrivateLinkResourceListResult IModelJsonSerializable<HDInsightPrivateLinkResourceListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightPrivateLinkResourceListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightPrivateLinkResourceListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightPrivateLinkResourceListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightPrivateLinkResourceListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightPrivateLinkResourceListResult IModelSerializable<HDInsightPrivateLinkResourceListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightPrivateLinkResourceListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightPrivateLinkResourceListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightPrivateLinkResourceListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightPrivateLinkResourceListResult"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightPrivateLinkResourceListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightPrivateLinkResourceListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightPrivateLinkResourceListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightPrivateLinkResourceListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
