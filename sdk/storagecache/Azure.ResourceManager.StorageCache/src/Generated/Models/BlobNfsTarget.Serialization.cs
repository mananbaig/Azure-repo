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
    public partial class BlobNfsTarget : IUtf8JsonSerializable, IModelJsonSerializable<BlobNfsTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BlobNfsTarget>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BlobNfsTarget>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobNfsTarget>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsDefined(UsageModel))
            {
                writer.WritePropertyName("usageModel"u8);
                writer.WriteStringValue(UsageModel);
            }
            if (Optional.IsDefined(VerificationDelayInSeconds))
            {
                writer.WritePropertyName("verificationTimer"u8);
                writer.WriteNumberValue(VerificationDelayInSeconds.Value);
            }
            if (Optional.IsDefined(WriteBackDelayInSeconds))
            {
                writer.WritePropertyName("writeBackTimer"u8);
                writer.WriteNumberValue(WriteBackDelayInSeconds.Value);
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

        internal static BlobNfsTarget DeserializeBlobNfsTarget(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> target = default;
            Optional<string> usageModel = default;
            Optional<int> verificationTimer = default;
            Optional<int> writeBackTimer = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("usageModel"u8))
                {
                    usageModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verificationTimer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    verificationTimer = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("writeBackTimer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBackTimer = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BlobNfsTarget(target.Value, usageModel.Value, Optional.ToNullable(verificationTimer), Optional.ToNullable(writeBackTimer), serializedAdditionalRawData);
        }

        BlobNfsTarget IModelJsonSerializable<BlobNfsTarget>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobNfsTarget>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobNfsTarget(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BlobNfsTarget>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobNfsTarget>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BlobNfsTarget IModelSerializable<BlobNfsTarget>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<BlobNfsTarget>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBlobNfsTarget(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BlobNfsTarget"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BlobNfsTarget"/> to convert. </param>
        public static implicit operator RequestContent(BlobNfsTarget model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BlobNfsTarget"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BlobNfsTarget(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBlobNfsTarget(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
