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

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class ImportRedisEnterpriseDatabaseContent : IUtf8JsonSerializable, IModelJsonSerializable<ImportRedisEnterpriseDatabaseContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ImportRedisEnterpriseDatabaseContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ImportRedisEnterpriseDatabaseContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImportRedisEnterpriseDatabaseContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sasUris"u8);
            writer.WriteStartArray();
            foreach (var item in SasUris)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item.AbsoluteUri);
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

        internal static ImportRedisEnterpriseDatabaseContent DeserializeImportRedisEnterpriseDatabaseContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<Uri> sasUris = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUris"u8))
                {
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new Uri(item.GetString()));
                        }
                    }
                    sasUris = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ImportRedisEnterpriseDatabaseContent(sasUris, serializedAdditionalRawData);
        }

        ImportRedisEnterpriseDatabaseContent IModelJsonSerializable<ImportRedisEnterpriseDatabaseContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImportRedisEnterpriseDatabaseContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeImportRedisEnterpriseDatabaseContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ImportRedisEnterpriseDatabaseContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImportRedisEnterpriseDatabaseContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ImportRedisEnterpriseDatabaseContent IModelSerializable<ImportRedisEnterpriseDatabaseContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ImportRedisEnterpriseDatabaseContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeImportRedisEnterpriseDatabaseContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ImportRedisEnterpriseDatabaseContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ImportRedisEnterpriseDatabaseContent"/> to convert. </param>
        public static implicit operator RequestContent(ImportRedisEnterpriseDatabaseContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ImportRedisEnterpriseDatabaseContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ImportRedisEnterpriseDatabaseContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeImportRedisEnterpriseDatabaseContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
