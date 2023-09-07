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

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class TypesRequestBatchGetOrDelete : IUtf8JsonSerializable, IModelJsonSerializable<TypesRequestBatchGetOrDelete>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TypesRequestBatchGetOrDelete>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TypesRequestBatchGetOrDelete>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TypesRequestBatchGetOrDelete>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TypeIds))
            {
                writer.WritePropertyName("typeIds"u8);
                writer.WriteStartArray();
                foreach (var item in TypeIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Names))
            {
                writer.WritePropertyName("names"u8);
                writer.WriteStartArray();
                foreach (var item in Names)
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

        internal static TypesRequestBatchGetOrDelete DeserializeTypesRequestBatchGetOrDelete(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> typeIds = default;
            Optional<IList<string>> names = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeIds"u8))
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
                    typeIds = array;
                    continue;
                }
                if (property.NameEquals("names"u8))
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
                    names = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TypesRequestBatchGetOrDelete(Optional.ToList(typeIds), Optional.ToList(names), serializedAdditionalRawData);
        }

        TypesRequestBatchGetOrDelete IModelJsonSerializable<TypesRequestBatchGetOrDelete>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TypesRequestBatchGetOrDelete>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTypesRequestBatchGetOrDelete(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TypesRequestBatchGetOrDelete>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TypesRequestBatchGetOrDelete>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TypesRequestBatchGetOrDelete IModelSerializable<TypesRequestBatchGetOrDelete>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TypesRequestBatchGetOrDelete>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTypesRequestBatchGetOrDelete(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TypesRequestBatchGetOrDelete"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TypesRequestBatchGetOrDelete"/> to convert. </param>
        public static implicit operator RequestContent(TypesRequestBatchGetOrDelete model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TypesRequestBatchGetOrDelete"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TypesRequestBatchGetOrDelete(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTypesRequestBatchGetOrDelete(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
