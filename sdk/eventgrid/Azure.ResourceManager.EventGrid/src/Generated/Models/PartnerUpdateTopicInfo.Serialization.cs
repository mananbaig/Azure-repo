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

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class PartnerUpdateTopicInfo : IUtf8JsonSerializable, IModelJsonSerializable<PartnerUpdateTopicInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PartnerUpdateTopicInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PartnerUpdateTopicInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerUpdateTopicInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EventTypeInfo))
            {
                writer.WritePropertyName("eventTypeInfo"u8);
                if (EventTypeInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PartnerTopicEventTypeInfo>)EventTypeInfo).Serialize(writer, options);
                }
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

        internal static PartnerUpdateTopicInfo DeserializePartnerUpdateTopicInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PartnerTopicEventTypeInfo> eventTypeInfo = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventTypeInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventTypeInfo = PartnerTopicEventTypeInfo.DeserializePartnerTopicEventTypeInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PartnerUpdateTopicInfo(eventTypeInfo.Value, serializedAdditionalRawData);
        }

        PartnerUpdateTopicInfo IModelJsonSerializable<PartnerUpdateTopicInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerUpdateTopicInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerUpdateTopicInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PartnerUpdateTopicInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerUpdateTopicInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PartnerUpdateTopicInfo IModelSerializable<PartnerUpdateTopicInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerUpdateTopicInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePartnerUpdateTopicInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PartnerUpdateTopicInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PartnerUpdateTopicInfo"/> to convert. </param>
        public static implicit operator RequestContent(PartnerUpdateTopicInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PartnerUpdateTopicInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PartnerUpdateTopicInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePartnerUpdateTopicInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
