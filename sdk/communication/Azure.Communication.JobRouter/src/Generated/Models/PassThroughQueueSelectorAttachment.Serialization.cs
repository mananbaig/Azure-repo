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
    public partial class PassThroughQueueSelectorAttachment : IUtf8JsonSerializable, IModelJsonSerializable<PassThroughQueueSelectorAttachment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PassThroughQueueSelectorAttachment>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PassThroughQueueSelectorAttachment>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PassThroughQueueSelectorAttachment>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key);
            writer.WritePropertyName("labelOperator"u8);
            writer.WriteStringValue(LabelOperator.ToString());
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

        internal static PassThroughQueueSelectorAttachment DeserializePassThroughQueueSelectorAttachment(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            LabelOperator labelOperator = default;
            string kind = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelOperator"u8))
                {
                    labelOperator = new LabelOperator(property.Value.GetString());
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
            return new PassThroughQueueSelectorAttachment(kind, key, labelOperator, rawData);
        }

        PassThroughQueueSelectorAttachment IModelJsonSerializable<PassThroughQueueSelectorAttachment>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PassThroughQueueSelectorAttachment>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePassThroughQueueSelectorAttachment(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PassThroughQueueSelectorAttachment>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PassThroughQueueSelectorAttachment>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PassThroughQueueSelectorAttachment IModelSerializable<PassThroughQueueSelectorAttachment>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PassThroughQueueSelectorAttachment>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePassThroughQueueSelectorAttachment(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PassThroughQueueSelectorAttachment"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PassThroughQueueSelectorAttachment"/> to convert. </param>
        public static implicit operator RequestContent(PassThroughQueueSelectorAttachment model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PassThroughQueueSelectorAttachment"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PassThroughQueueSelectorAttachment(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePassThroughQueueSelectorAttachment(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
