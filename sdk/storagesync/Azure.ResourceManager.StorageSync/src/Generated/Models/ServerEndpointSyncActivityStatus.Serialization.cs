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

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class ServerEndpointSyncActivityStatus : IUtf8JsonSerializable, IModelJsonSerializable<ServerEndpointSyncActivityStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServerEndpointSyncActivityStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServerEndpointSyncActivityStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerEndpointSyncActivityStatus>(this, options.Format);

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

        internal static ServerEndpointSyncActivityStatus DeserializeServerEndpointSyncActivityStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timestamp = default;
            Optional<long> perItemErrorCount = default;
            Optional<long> appliedItemCount = default;
            Optional<long> totalItemCount = default;
            Optional<long> appliedBytes = default;
            Optional<long> totalBytes = default;
            Optional<ServerEndpointSyncMode> syncMode = default;
            Optional<int> sessionMinutesRemaining = default;
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
                if (property.NameEquals("perItemErrorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    perItemErrorCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("appliedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appliedItemCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalItemCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("appliedBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appliedBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("totalBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    syncMode = new ServerEndpointSyncMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sessionMinutesRemaining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sessionMinutesRemaining = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServerEndpointSyncActivityStatus(Optional.ToNullable(timestamp), Optional.ToNullable(perItemErrorCount), Optional.ToNullable(appliedItemCount), Optional.ToNullable(totalItemCount), Optional.ToNullable(appliedBytes), Optional.ToNullable(totalBytes), Optional.ToNullable(syncMode), Optional.ToNullable(sessionMinutesRemaining), serializedAdditionalRawData);
        }

        ServerEndpointSyncActivityStatus IModelJsonSerializable<ServerEndpointSyncActivityStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerEndpointSyncActivityStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServerEndpointSyncActivityStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServerEndpointSyncActivityStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerEndpointSyncActivityStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServerEndpointSyncActivityStatus IModelSerializable<ServerEndpointSyncActivityStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServerEndpointSyncActivityStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServerEndpointSyncActivityStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServerEndpointSyncActivityStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServerEndpointSyncActivityStatus"/> to convert. </param>
        public static implicit operator RequestContent(ServerEndpointSyncActivityStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServerEndpointSyncActivityStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServerEndpointSyncActivityStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServerEndpointSyncActivityStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
