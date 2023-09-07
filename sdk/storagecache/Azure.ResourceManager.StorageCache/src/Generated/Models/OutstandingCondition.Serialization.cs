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

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class OutstandingCondition : IUtf8JsonSerializable, IModelJsonSerializable<OutstandingCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OutstandingCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OutstandingCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutstandingCondition>(this, options.Format);

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

        internal static OutstandingCondition DeserializeOutstandingCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> message = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OutstandingCondition(Optional.ToNullable(timestamp), message.Value, serializedAdditionalRawData);
        }

        OutstandingCondition IModelJsonSerializable<OutstandingCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutstandingCondition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOutstandingCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OutstandingCondition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutstandingCondition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OutstandingCondition IModelSerializable<OutstandingCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutstandingCondition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOutstandingCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OutstandingCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OutstandingCondition"/> to convert. </param>
        public static implicit operator RequestContent(OutstandingCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OutstandingCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OutstandingCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOutstandingCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
