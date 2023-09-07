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
    internal partial class StorageCacheSecuritySettings : IUtf8JsonSerializable, IModelJsonSerializable<StorageCacheSecuritySettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageCacheSecuritySettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageCacheSecuritySettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheSecuritySettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AccessPolicies))
            {
                writer.WritePropertyName("accessPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in AccessPolicies)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<NfsAccessPolicy>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static StorageCacheSecuritySettings DeserializeStorageCacheSecuritySettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<NfsAccessPolicy>> accessPolicies = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessPolicies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NfsAccessPolicy> array = new List<NfsAccessPolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NfsAccessPolicy.DeserializeNfsAccessPolicy(item));
                    }
                    accessPolicies = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageCacheSecuritySettings(Optional.ToList(accessPolicies), serializedAdditionalRawData);
        }

        StorageCacheSecuritySettings IModelJsonSerializable<StorageCacheSecuritySettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheSecuritySettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheSecuritySettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageCacheSecuritySettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheSecuritySettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageCacheSecuritySettings IModelSerializable<StorageCacheSecuritySettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageCacheSecuritySettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageCacheSecuritySettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageCacheSecuritySettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageCacheSecuritySettings"/> to convert. </param>
        public static implicit operator RequestContent(StorageCacheSecuritySettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageCacheSecuritySettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageCacheSecuritySettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageCacheSecuritySettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
