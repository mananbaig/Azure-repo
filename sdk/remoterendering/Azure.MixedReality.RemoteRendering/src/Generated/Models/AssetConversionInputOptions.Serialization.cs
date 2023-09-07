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

namespace Azure.MixedReality.RemoteRendering
{
    public partial class AssetConversionInputOptions : IUtf8JsonSerializable, IModelJsonSerializable<AssetConversionInputOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AssetConversionInputOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AssetConversionInputOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AssetConversionInputOptions>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("storageContainerUri"u8);
            writer.WriteStringValue(StorageContainerUri.AbsoluteUri);
            if (Optional.IsDefined(StorageContainerReadListSas))
            {
                writer.WritePropertyName("storageContainerReadListSas"u8);
                writer.WriteStringValue(StorageContainerReadListSas);
            }
            if (Optional.IsDefined(BlobPrefix))
            {
                writer.WritePropertyName("blobPrefix"u8);
                writer.WriteStringValue(BlobPrefix);
            }
            writer.WritePropertyName("relativeInputAssetPath"u8);
            writer.WriteStringValue(RelativeInputAssetPath);
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

        internal static AssetConversionInputOptions DeserializeAssetConversionInputOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri storageContainerUri = default;
            Optional<string> storageContainerReadListSas = default;
            Optional<string> blobPrefix = default;
            string relativeInputAssetPath = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageContainerUri"u8))
                {
                    storageContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageContainerReadListSas"u8))
                {
                    storageContainerReadListSas = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobPrefix"u8))
                {
                    blobPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeInputAssetPath"u8))
                {
                    relativeInputAssetPath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AssetConversionInputOptions(storageContainerUri, storageContainerReadListSas.Value, blobPrefix.Value, relativeInputAssetPath, serializedAdditionalRawData);
        }

        AssetConversionInputOptions IModelJsonSerializable<AssetConversionInputOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AssetConversionInputOptions>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAssetConversionInputOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AssetConversionInputOptions>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AssetConversionInputOptions>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AssetConversionInputOptions IModelSerializable<AssetConversionInputOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AssetConversionInputOptions>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAssetConversionInputOptions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AssetConversionInputOptions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AssetConversionInputOptions"/> to convert. </param>
        public static implicit operator RequestContent(AssetConversionInputOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AssetConversionInputOptions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AssetConversionInputOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAssetConversionInputOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
