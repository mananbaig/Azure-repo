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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class TriggeredJobHistoryListResult : IUtf8JsonSerializable, IModelJsonSerializable<TriggeredJobHistoryListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TriggeredJobHistoryListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TriggeredJobHistoryListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggeredJobHistoryListResult>(this, options.Format);

            writer.WriteStartObject();
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
                    ((IModelJsonSerializable<TriggeredJobHistoryData>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
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

        internal static TriggeredJobHistoryListResult DeserializeTriggeredJobHistoryListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<TriggeredJobHistoryData> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<TriggeredJobHistoryData> array = new List<TriggeredJobHistoryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggeredJobHistoryData.DeserializeTriggeredJobHistoryData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TriggeredJobHistoryListResult(value, nextLink.Value, serializedAdditionalRawData);
        }

        TriggeredJobHistoryListResult IModelJsonSerializable<TriggeredJobHistoryListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggeredJobHistoryListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggeredJobHistoryListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TriggeredJobHistoryListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggeredJobHistoryListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TriggeredJobHistoryListResult IModelSerializable<TriggeredJobHistoryListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggeredJobHistoryListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTriggeredJobHistoryListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TriggeredJobHistoryListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TriggeredJobHistoryListResult"/> to convert. </param>
        public static implicit operator RequestContent(TriggeredJobHistoryListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TriggeredJobHistoryListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TriggeredJobHistoryListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTriggeredJobHistoryListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
