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
    public partial class TimeSeriesOperationError : IUtf8JsonSerializable, IModelJsonSerializable<TimeSeriesOperationError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TimeSeriesOperationError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TimeSeriesOperationError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesOperationError>(this, options.Format);

            writer.WriteStartObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TimeSeriesOperationError DeserializeTimeSeriesOperationError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<TimeSeriesOperationError> innerError = default;
            Optional<IReadOnlyList<TimeSeriesOperationErrorDetails>> details = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    innerError = DeserializeTimeSeriesOperationError(property.Value);
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TimeSeriesOperationErrorDetails> array = new List<TimeSeriesOperationErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimeSeriesOperationErrorDetails.DeserializeTimeSeriesOperationErrorDetails(item));
                    }
                    details = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TimeSeriesOperationError(code.Value, message.Value, target.Value, innerError.Value, Optional.ToList(details), additionalProperties);
        }

        TimeSeriesOperationError IModelJsonSerializable<TimeSeriesOperationError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesOperationError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeSeriesOperationError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TimeSeriesOperationError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesOperationError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TimeSeriesOperationError IModelSerializable<TimeSeriesOperationError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesOperationError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTimeSeriesOperationError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TimeSeriesOperationError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TimeSeriesOperationError"/> to convert. </param>
        public static implicit operator RequestContent(TimeSeriesOperationError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TimeSeriesOperationError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TimeSeriesOperationError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTimeSeriesOperationError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
