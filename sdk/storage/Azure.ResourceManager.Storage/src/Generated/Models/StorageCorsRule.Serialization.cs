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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageCorsRule : IUtf8JsonSerializable, IModelJsonSerializable<StorageCorsRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageCorsRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageCorsRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCorsRule>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("allowedOrigins"u8);
            writer.WriteStartArray();
            foreach (var item in AllowedOrigins)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("allowedMethods"u8);
            writer.WriteStartArray();
            foreach (var item in AllowedMethods)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("maxAgeInSeconds"u8);
            writer.WriteNumberValue(MaxAgeInSeconds);
            writer.WritePropertyName("exposedHeaders"u8);
            writer.WriteStartArray();
            foreach (var item in ExposedHeaders)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("allowedHeaders"u8);
            writer.WriteStartArray();
            foreach (var item in AllowedHeaders)
            {
                writer.WriteStringValue(item);
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

        internal static StorageCorsRule DeserializeStorageCorsRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> allowedOrigins = default;
            IList<CorsRuleAllowedMethod> allowedMethods = default;
            int maxAgeInSeconds = default;
            IList<string> exposedHeaders = default;
            IList<string> allowedHeaders = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOrigins = array;
                    continue;
                }
                if (property.NameEquals("allowedMethods"u8))
                {
                    List<CorsRuleAllowedMethod> array = new List<CorsRuleAllowedMethod>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new CorsRuleAllowedMethod(item.GetString()));
                    }
                    allowedMethods = array;
                    continue;
                }
                if (property.NameEquals("maxAgeInSeconds"u8))
                {
                    maxAgeInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exposedHeaders"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    exposedHeaders = array;
                    continue;
                }
                if (property.NameEquals("allowedHeaders"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedHeaders = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageCorsRule(allowedOrigins, allowedMethods, maxAgeInSeconds, exposedHeaders, allowedHeaders, serializedAdditionalRawData);
        }

        StorageCorsRule IModelJsonSerializable<StorageCorsRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCorsRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCorsRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageCorsRule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCorsRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageCorsRule IModelSerializable<StorageCorsRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCorsRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageCorsRule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageCorsRule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageCorsRule"/> to convert. </param>
        public static implicit operator RequestContent(StorageCorsRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageCorsRule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageCorsRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageCorsRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
