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
    public partial class CloudTieringVolumeFreeSpacePolicyStatus : IUtf8JsonSerializable, IModelJsonSerializable<CloudTieringVolumeFreeSpacePolicyStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudTieringVolumeFreeSpacePolicyStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudTieringVolumeFreeSpacePolicyStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudTieringVolumeFreeSpacePolicyStatus>(this, options.Format);

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

        internal static CloudTieringVolumeFreeSpacePolicyStatus DeserializeCloudTieringVolumeFreeSpacePolicyStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<int> effectiveVolumeFreeSpacePolicy = default;
            Optional<int> currentVolumeFreeSpacePercent = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("effectiveVolumeFreeSpacePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveVolumeFreeSpacePolicy = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentVolumeFreeSpacePercent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentVolumeFreeSpacePercent = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudTieringVolumeFreeSpacePolicyStatus(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(effectiveVolumeFreeSpacePolicy), Optional.ToNullable(currentVolumeFreeSpacePercent), serializedAdditionalRawData);
        }

        CloudTieringVolumeFreeSpacePolicyStatus IModelJsonSerializable<CloudTieringVolumeFreeSpacePolicyStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudTieringVolumeFreeSpacePolicyStatus>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudTieringVolumeFreeSpacePolicyStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudTieringVolumeFreeSpacePolicyStatus>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudTieringVolumeFreeSpacePolicyStatus>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudTieringVolumeFreeSpacePolicyStatus IModelSerializable<CloudTieringVolumeFreeSpacePolicyStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudTieringVolumeFreeSpacePolicyStatus>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudTieringVolumeFreeSpacePolicyStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CloudTieringVolumeFreeSpacePolicyStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CloudTieringVolumeFreeSpacePolicyStatus"/> to convert. </param>
        public static implicit operator RequestContent(CloudTieringVolumeFreeSpacePolicyStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CloudTieringVolumeFreeSpacePolicyStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CloudTieringVolumeFreeSpacePolicyStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudTieringVolumeFreeSpacePolicyStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
