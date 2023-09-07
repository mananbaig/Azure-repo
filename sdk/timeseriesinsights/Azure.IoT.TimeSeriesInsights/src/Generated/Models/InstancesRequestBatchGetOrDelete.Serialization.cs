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
    internal partial class InstancesRequestBatchGetOrDelete : IUtf8JsonSerializable, IModelJsonSerializable<InstancesRequestBatchGetOrDelete>
    {
        void IModelJsonSerializable<InstancesRequestBatchGetOrDelete>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstancesRequestBatchGetOrDelete>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TimeSeriesIdsInternal))
            {
                writer.WritePropertyName("timeSeriesIds"u8);
                writer.WriteStartArray();
                foreach (var item in TimeSeriesIdsInternal)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        if (item0 == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
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

        internal static InstancesRequestBatchGetOrDelete DeserializeInstancesRequestBatchGetOrDelete(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<IList<object>>> timeSeriesIds = default;
            Optional<IList<string>> names = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeSeriesIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<object>> array = new List<IList<object>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<object> array0 = new List<object>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                if (item0.ValueKind == JsonValueKind.Null)
                                {
                                    array0.Add(null);
                                }
                                else
                                {
                                    array0.Add(item0.GetObject());
                                }
                            }
                            array.Add(array0);
                        }
                    }
                    timeSeriesIds = array;
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
            return new InstancesRequestBatchGetOrDelete(Optional.ToList(timeSeriesIds), Optional.ToList(names), serializedAdditionalRawData);
        }

        InstancesRequestBatchGetOrDelete IModelJsonSerializable<InstancesRequestBatchGetOrDelete>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstancesRequestBatchGetOrDelete>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancesRequestBatchGetOrDelete(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InstancesRequestBatchGetOrDelete>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstancesRequestBatchGetOrDelete>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InstancesRequestBatchGetOrDelete IModelSerializable<InstancesRequestBatchGetOrDelete>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InstancesRequestBatchGetOrDelete>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInstancesRequestBatchGetOrDelete(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InstancesRequestBatchGetOrDelete"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InstancesRequestBatchGetOrDelete"/> to convert. </param>
        public static implicit operator RequestContent(InstancesRequestBatchGetOrDelete model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InstancesRequestBatchGetOrDelete"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InstancesRequestBatchGetOrDelete(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInstancesRequestBatchGetOrDelete(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
