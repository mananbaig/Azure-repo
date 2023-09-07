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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class RawReferenceInputDataSource : IUtf8JsonSerializable, IModelJsonSerializable<RawReferenceInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RawReferenceInputDataSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RawReferenceInputDataSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RawReferenceInputDataSource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ReferenceInputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Payload))
            {
                writer.WritePropertyName("payload"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Payload);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Payload.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(PayloadUri))
            {
                writer.WritePropertyName("payloadUri"u8);
                writer.WriteStringValue(PayloadUri.AbsoluteUri);
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

        internal static RawReferenceInputDataSource DeserializeRawReferenceInputDataSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<BinaryData> payload = default;
            Optional<Uri> payloadUri = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("payload"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            payload = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("payloadUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            payloadUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RawReferenceInputDataSource(type, payload.Value, payloadUri.Value, serializedAdditionalRawData);
        }

        RawReferenceInputDataSource IModelJsonSerializable<RawReferenceInputDataSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RawReferenceInputDataSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRawReferenceInputDataSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RawReferenceInputDataSource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RawReferenceInputDataSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RawReferenceInputDataSource IModelSerializable<RawReferenceInputDataSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RawReferenceInputDataSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRawReferenceInputDataSource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RawReferenceInputDataSource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RawReferenceInputDataSource"/> to convert. </param>
        public static implicit operator RequestContent(RawReferenceInputDataSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RawReferenceInputDataSource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RawReferenceInputDataSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRawReferenceInputDataSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
