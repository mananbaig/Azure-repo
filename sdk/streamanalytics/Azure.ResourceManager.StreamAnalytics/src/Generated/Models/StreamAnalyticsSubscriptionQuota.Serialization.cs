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
    public partial class StreamAnalyticsSubscriptionQuota : IUtf8JsonSerializable, IModelJsonSerializable<StreamAnalyticsSubscriptionQuota>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StreamAnalyticsSubscriptionQuota>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StreamAnalyticsSubscriptionQuota>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsSubscriptionQuota>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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

        internal static StreamAnalyticsSubscriptionQuota DeserializeStreamAnalyticsSubscriptionQuota(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<int> maxCount = default;
            Optional<int> currentCount = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("maxCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("currentCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentCount = property0.Value.GetInt32();
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
            return new StreamAnalyticsSubscriptionQuota(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(maxCount), Optional.ToNullable(currentCount), serializedAdditionalRawData);
        }

        StreamAnalyticsSubscriptionQuota IModelJsonSerializable<StreamAnalyticsSubscriptionQuota>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsSubscriptionQuota>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamAnalyticsSubscriptionQuota(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StreamAnalyticsSubscriptionQuota>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsSubscriptionQuota>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StreamAnalyticsSubscriptionQuota IModelSerializable<StreamAnalyticsSubscriptionQuota>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamAnalyticsSubscriptionQuota>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStreamAnalyticsSubscriptionQuota(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StreamAnalyticsSubscriptionQuota"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StreamAnalyticsSubscriptionQuota"/> to convert. </param>
        public static implicit operator RequestContent(StreamAnalyticsSubscriptionQuota model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StreamAnalyticsSubscriptionQuota"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StreamAnalyticsSubscriptionQuota(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStreamAnalyticsSubscriptionQuota(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
