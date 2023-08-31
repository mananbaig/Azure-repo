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

namespace Azure.Communication.JobRouter
{
    public partial class StaticQueueSelectorAttachment : IUtf8JsonSerializable, IModelJsonSerializable<StaticQueueSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StaticQueueSelectorAttachment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StaticQueueSelectorAttachment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<StaticQueueSelectorAttachment>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("queueSelector"u8);
            if (QueueSelector is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<RouterQueueSelector>)QueueSelector).Serialize(writer, options);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
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

        internal static StaticQueueSelectorAttachment DeserializeStaticQueueSelectorAttachment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RouterQueueSelector queueSelector = default;
            string kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueSelector"u8))
                {
                    queueSelector = RouterQueueSelector.DeserializeRouterQueueSelector(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StaticQueueSelectorAttachment(kind, queueSelector, rawData);
        }

        StaticQueueSelectorAttachment IModelJsonSerializable<StaticQueueSelectorAttachment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<StaticQueueSelectorAttachment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticQueueSelectorAttachment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StaticQueueSelectorAttachment>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<StaticQueueSelectorAttachment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StaticQueueSelectorAttachment IModelSerializable<StaticQueueSelectorAttachment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<StaticQueueSelectorAttachment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStaticQueueSelectorAttachment(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StaticQueueSelectorAttachment"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StaticQueueSelectorAttachment"/> to convert. </param>
        public static implicit operator RequestContent(StaticQueueSelectorAttachment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StaticQueueSelectorAttachment"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StaticQueueSelectorAttachment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStaticQueueSelectorAttachment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
