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
    public partial class StreamingJobExternal : IUtf8JsonSerializable, IModelJsonSerializable<StreamingJobExternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StreamingJobExternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StreamingJobExternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingJobExternal>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccount))
            {
                writer.WritePropertyName("storageAccount"u8);
                if (StorageAccount is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StreamAnalyticsStorageAccount>)StorageAccount).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container"u8);
                writer.WriteStringValue(Container);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(RefreshConfiguration))
            {
                writer.WritePropertyName("refreshConfiguration"u8);
                if (RefreshConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StreamingJobRefreshConfiguration>)RefreshConfiguration).Serialize(writer, options);
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

        internal static StreamingJobExternal DeserializeStreamingJobExternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<StreamAnalyticsStorageAccount> storageAccount = default;
            Optional<string> container = default;
            Optional<string> path = default;
            Optional<StreamingJobRefreshConfiguration> refreshConfiguration = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccount = StreamAnalyticsStorageAccount.DeserializeStreamAnalyticsStorageAccount(property.Value);
                    continue;
                }
                if (property.NameEquals("container"u8))
                {
                    container = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshConfiguration = StreamingJobRefreshConfiguration.DeserializeStreamingJobRefreshConfiguration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StreamingJobExternal(storageAccount.Value, container.Value, path.Value, refreshConfiguration.Value, serializedAdditionalRawData);
        }

        StreamingJobExternal IModelJsonSerializable<StreamingJobExternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingJobExternal>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingJobExternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StreamingJobExternal>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingJobExternal>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StreamingJobExternal IModelSerializable<StreamingJobExternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StreamingJobExternal>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStreamingJobExternal(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StreamingJobExternal"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StreamingJobExternal"/> to convert. </param>
        public static implicit operator RequestContent(StreamingJobExternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StreamingJobExternal"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StreamingJobExternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStreamingJobExternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
