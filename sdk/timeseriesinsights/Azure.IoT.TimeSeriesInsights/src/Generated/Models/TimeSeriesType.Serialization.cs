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
    public partial class TimeSeriesType : IUtf8JsonSerializable, IModelJsonSerializable<TimeSeriesType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TimeSeriesType>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TimeSeriesType>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesType>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("variables"u8);
            writer.WriteStartObject();
            foreach (var item in Variables)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TimeSeriesVariable>)item.Value).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
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

        internal static TimeSeriesType DeserializeTimeSeriesType(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            string name = default;
            Optional<string> description = default;
            IDictionary<string, TimeSeriesVariable> variables = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("variables"u8))
                {
                    Dictionary<string, TimeSeriesVariable> dictionary = new Dictionary<string, TimeSeriesVariable>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, TimeSeriesVariable.DeserializeTimeSeriesVariable(property0.Value));
                    }
                    variables = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TimeSeriesType(id.Value, name, description.Value, variables, serializedAdditionalRawData);
        }

        TimeSeriesType IModelJsonSerializable<TimeSeriesType>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesType>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeSeriesType(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TimeSeriesType>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesType>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TimeSeriesType IModelSerializable<TimeSeriesType>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesType>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTimeSeriesType(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TimeSeriesType"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TimeSeriesType"/> to convert. </param>
        public static implicit operator RequestContent(TimeSeriesType model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TimeSeriesType"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TimeSeriesType(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTimeSeriesType(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
