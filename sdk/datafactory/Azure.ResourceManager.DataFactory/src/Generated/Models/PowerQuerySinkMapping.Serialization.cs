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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PowerQuerySinkMapping : IUtf8JsonSerializable, IModelJsonSerializable<PowerQuerySinkMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PowerQuerySinkMapping>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PowerQuerySinkMapping>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(QueryName))
            {
                writer.WritePropertyName("queryName"u8);
                writer.WriteStringValue(QueryName);
            }
            if (Optional.IsCollectionDefined(DataflowSinks))
            {
                writer.WritePropertyName("dataflowSinks"u8);
                writer.WriteStartArray();
                foreach (var item in DataflowSinks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static PowerQuerySinkMapping DeserializePowerQuerySinkMapping(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> queryName = default;
            Optional<IList<PowerQuerySink>> dataflowSinks = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryName"u8))
                {
                    queryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataflowSinks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PowerQuerySink> array = new List<PowerQuerySink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PowerQuerySink.DeserializePowerQuerySink(item));
                    }
                    dataflowSinks = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PowerQuerySinkMapping(queryName.Value, Optional.ToList(dataflowSinks), rawData);
        }

        PowerQuerySinkMapping IModelJsonSerializable<PowerQuerySinkMapping>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePowerQuerySinkMapping(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PowerQuerySinkMapping>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PowerQuerySinkMapping IModelSerializable<PowerQuerySinkMapping>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePowerQuerySinkMapping(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PowerQuerySinkMapping model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PowerQuerySinkMapping(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePowerQuerySinkMapping(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
