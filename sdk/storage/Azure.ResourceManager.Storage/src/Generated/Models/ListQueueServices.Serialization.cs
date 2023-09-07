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
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    internal partial class ListQueueServices : IUtf8JsonSerializable, IModelJsonSerializable<ListQueueServices>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ListQueueServices>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ListQueueServices>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListQueueServices>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ListQueueServices DeserializeListQueueServices(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<QueueServiceData>> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueueServiceData> array = new List<QueueServiceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueueServiceData.DeserializeQueueServiceData(item));
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
            return new ListQueueServices(Optional.ToList(value), serializedAdditionalRawData);
        }

        ListQueueServices IModelJsonSerializable<ListQueueServices>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListQueueServices>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeListQueueServices(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ListQueueServices>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListQueueServices>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ListQueueServices IModelSerializable<ListQueueServices>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ListQueueServices>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeListQueueServices(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ListQueueServices"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ListQueueServices"/> to convert. </param>
        public static implicit operator RequestContent(ListQueueServices model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ListQueueServices"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ListQueueServices(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeListQueueServices(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
