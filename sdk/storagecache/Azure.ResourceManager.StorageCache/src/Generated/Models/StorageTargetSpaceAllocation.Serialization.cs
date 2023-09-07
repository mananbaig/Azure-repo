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
    public partial class StorageTargetSpaceAllocation : IUtf8JsonSerializable, IModelJsonSerializable<StorageTargetSpaceAllocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageTargetSpaceAllocation>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageTargetSpaceAllocation>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageTargetSpaceAllocation>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AllocationPercentage))
            {
                writer.WritePropertyName("allocationPercentage"u8);
                writer.WriteNumberValue(AllocationPercentage.Value);
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

        internal static StorageTargetSpaceAllocation DeserializeStorageTargetSpaceAllocation(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<int> allocationPercentage = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allocationPercentage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationPercentage = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageTargetSpaceAllocation(name.Value, Optional.ToNullable(allocationPercentage), serializedAdditionalRawData);
        }

        StorageTargetSpaceAllocation IModelJsonSerializable<StorageTargetSpaceAllocation>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageTargetSpaceAllocation>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageTargetSpaceAllocation(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageTargetSpaceAllocation>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageTargetSpaceAllocation>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageTargetSpaceAllocation IModelSerializable<StorageTargetSpaceAllocation>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageTargetSpaceAllocation>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageTargetSpaceAllocation(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageTargetSpaceAllocation"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageTargetSpaceAllocation"/> to convert. </param>
        public static implicit operator RequestContent(StorageTargetSpaceAllocation model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageTargetSpaceAllocation"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageTargetSpaceAllocation(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageTargetSpaceAllocation(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
