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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class FlinkHiveCatalogOption : IUtf8JsonSerializable, IModelJsonSerializable<FlinkHiveCatalogOption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<FlinkHiveCatalogOption>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<FlinkHiveCatalogOption>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FlinkHiveCatalogOption>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("metastoreDbConnectionPasswordSecret"u8);
            writer.WriteStringValue(MetastoreDBConnectionPasswordSecret);
            writer.WritePropertyName("metastoreDbConnectionURL"u8);
            writer.WriteStringValue(MetastoreDBConnectionUriString);
            writer.WritePropertyName("metastoreDbConnectionUserName"u8);
            writer.WriteStringValue(MetastoreDBConnectionUserName);
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

        internal static FlinkHiveCatalogOption DeserializeFlinkHiveCatalogOption(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string metastoreDBConnectionPasswordSecret = default;
            string metastoreDBConnectionURL = default;
            string metastoreDBConnectionUserName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metastoreDbConnectionPasswordSecret"u8))
                {
                    metastoreDBConnectionPasswordSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionURL"u8))
                {
                    metastoreDBConnectionURL = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metastoreDbConnectionUserName"u8))
                {
                    metastoreDBConnectionUserName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new FlinkHiveCatalogOption(metastoreDBConnectionPasswordSecret, metastoreDBConnectionURL, metastoreDBConnectionUserName, serializedAdditionalRawData);
        }

        FlinkHiveCatalogOption IModelJsonSerializable<FlinkHiveCatalogOption>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FlinkHiveCatalogOption>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeFlinkHiveCatalogOption(doc.RootElement, options);
        }

        BinaryData IModelSerializable<FlinkHiveCatalogOption>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FlinkHiveCatalogOption>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        FlinkHiveCatalogOption IModelSerializable<FlinkHiveCatalogOption>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<FlinkHiveCatalogOption>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeFlinkHiveCatalogOption(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="FlinkHiveCatalogOption"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="FlinkHiveCatalogOption"/> to convert. </param>
        public static implicit operator RequestContent(FlinkHiveCatalogOption model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="FlinkHiveCatalogOption"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator FlinkHiveCatalogOption(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeFlinkHiveCatalogOption(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
