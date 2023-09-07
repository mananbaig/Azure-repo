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
    public partial class SparkMetastoreSpec : IUtf8JsonSerializable, IModelJsonSerializable<SparkMetastoreSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SparkMetastoreSpec>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SparkMetastoreSpec>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkMetastoreSpec>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("dbServerHost"u8);
            writer.WriteStringValue(DBServerHost);
            writer.WritePropertyName("dbName"u8);
            writer.WriteStringValue(DBName);
            writer.WritePropertyName("dbUserName"u8);
            writer.WriteStringValue(DBUserName);
            writer.WritePropertyName("dbPasswordSecretName"u8);
            writer.WriteStringValue(DBPasswordSecretName);
            writer.WritePropertyName("keyVaultId"u8);
            writer.WriteStringValue(KeyVaultId);
            if (Optional.IsDefined(ThriftUriString))
            {
                writer.WritePropertyName("thriftUrl"u8);
                writer.WriteStringValue(ThriftUriString);
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

        internal static SparkMetastoreSpec DeserializeSparkMetastoreSpec(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dbServerHost = default;
            string dbName = default;
            string dbUserName = default;
            string dbPasswordSecretName = default;
            string keyVaultId = default;
            Optional<string> thriftUrl = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dbServerHost"u8))
                {
                    dbServerHost = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbName"u8))
                {
                    dbName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbUserName"u8))
                {
                    dbUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dbPasswordSecretName"u8))
                {
                    dbPasswordSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultId"u8))
                {
                    keyVaultId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thriftUrl"u8))
                {
                    thriftUrl = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SparkMetastoreSpec(dbServerHost, dbName, dbUserName, dbPasswordSecretName, keyVaultId, thriftUrl.Value, serializedAdditionalRawData);
        }

        SparkMetastoreSpec IModelJsonSerializable<SparkMetastoreSpec>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkMetastoreSpec>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkMetastoreSpec(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SparkMetastoreSpec>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkMetastoreSpec>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SparkMetastoreSpec IModelSerializable<SparkMetastoreSpec>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkMetastoreSpec>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSparkMetastoreSpec(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SparkMetastoreSpec"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SparkMetastoreSpec"/> to convert. </param>
        public static implicit operator RequestContent(SparkMetastoreSpec model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SparkMetastoreSpec"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SparkMetastoreSpec(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSparkMetastoreSpec(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
