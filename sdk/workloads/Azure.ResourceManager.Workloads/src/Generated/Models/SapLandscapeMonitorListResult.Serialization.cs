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
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    internal partial class SapLandscapeMonitorListResult : IUtf8JsonSerializable, IModelJsonSerializable<SapLandscapeMonitorListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapLandscapeMonitorListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapLandscapeMonitorListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapLandscapeMonitorListResult>(this, options.Format);

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
                        ((IModelJsonSerializable<SapLandscapeMonitorData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        internal static SapLandscapeMonitorListResult DeserializeSapLandscapeMonitorListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SapLandscapeMonitorData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SapLandscapeMonitorData> array = new List<SapLandscapeMonitorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SapLandscapeMonitorData.DeserializeSapLandscapeMonitorData(item));
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
            return new SapLandscapeMonitorListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        SapLandscapeMonitorListResult IModelJsonSerializable<SapLandscapeMonitorListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapLandscapeMonitorListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapLandscapeMonitorListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapLandscapeMonitorListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapLandscapeMonitorListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapLandscapeMonitorListResult IModelSerializable<SapLandscapeMonitorListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapLandscapeMonitorListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapLandscapeMonitorListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SapLandscapeMonitorListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SapLandscapeMonitorListResult"/> to convert. </param>
        public static implicit operator RequestContent(SapLandscapeMonitorListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SapLandscapeMonitorListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SapLandscapeMonitorListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapLandscapeMonitorListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
