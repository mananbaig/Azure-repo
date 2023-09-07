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
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class StreamAnalyticsTestContent : IUtf8JsonSerializable, IModelJsonSerializable<StreamAnalyticsTestContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StreamAnalyticsTestContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StreamAnalyticsTestContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsTestContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("input"u8);
            if (Input is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<StreamingJobInputData>)Input).Serialize(writer, options);
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

        internal static StreamAnalyticsTestContent DeserializeStreamAnalyticsTestContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StreamingJobInputData input = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("input"u8))
                {
                    input = StreamingJobInputData.DeserializeStreamingJobInputData(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StreamAnalyticsTestContent(input, serializedAdditionalRawData);
        }

        StreamAnalyticsTestContent IModelJsonSerializable<StreamAnalyticsTestContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsTestContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsTestContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StreamAnalyticsTestContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsTestContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StreamAnalyticsTestContent IModelSerializable<StreamAnalyticsTestContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsTestContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStreamAnalyticsTestContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StreamAnalyticsTestContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StreamAnalyticsTestContent"/> to convert. </param>
        public static implicit operator RequestContent(StreamAnalyticsTestContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StreamAnalyticsTestContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StreamAnalyticsTestContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStreamAnalyticsTestContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
