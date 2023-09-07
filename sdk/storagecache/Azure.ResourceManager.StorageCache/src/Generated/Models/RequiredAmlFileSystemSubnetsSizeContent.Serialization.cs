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
    public partial class RequiredAmlFileSystemSubnetsSizeContent : IUtf8JsonSerializable, IModelJsonSerializable<RequiredAmlFileSystemSubnetsSizeContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RequiredAmlFileSystemSubnetsSizeContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RequiredAmlFileSystemSubnetsSizeContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RequiredAmlFileSystemSubnetsSizeContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StorageCapacityTiB))
            {
                writer.WritePropertyName("storageCapacityTiB"u8);
                writer.WriteNumberValue(StorageCapacityTiB.Value);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<StorageCacheSkuName>)Sku).Serialize(writer, options);
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

        internal static RequiredAmlFileSystemSubnetsSizeContent DeserializeRequiredAmlFileSystemSubnetsSizeContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> storageCapacityTiB = default;
            Optional<StorageCacheSkuName> sku = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageCapacityTiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageCapacityTiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageCacheSkuName.DeserializeStorageCacheSkuName(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RequiredAmlFileSystemSubnetsSizeContent(Optional.ToNullable(storageCapacityTiB), sku.Value, serializedAdditionalRawData);
        }

        RequiredAmlFileSystemSubnetsSizeContent IModelJsonSerializable<RequiredAmlFileSystemSubnetsSizeContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RequiredAmlFileSystemSubnetsSizeContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRequiredAmlFileSystemSubnetsSizeContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RequiredAmlFileSystemSubnetsSizeContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RequiredAmlFileSystemSubnetsSizeContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RequiredAmlFileSystemSubnetsSizeContent IModelSerializable<RequiredAmlFileSystemSubnetsSizeContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RequiredAmlFileSystemSubnetsSizeContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRequiredAmlFileSystemSubnetsSizeContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RequiredAmlFileSystemSubnetsSizeContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RequiredAmlFileSystemSubnetsSizeContent"/> to convert. </param>
        public static implicit operator RequestContent(RequiredAmlFileSystemSubnetsSizeContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RequiredAmlFileSystemSubnetsSizeContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RequiredAmlFileSystemSubnetsSizeContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRequiredAmlFileSystemSubnetsSizeContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
