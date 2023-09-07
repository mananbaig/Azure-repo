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

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkStatementCollection : IUtf8JsonSerializable, IModelJsonSerializable<SparkStatementCollection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SparkStatementCollection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SparkStatementCollection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkStatementCollection>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("total_statements"u8);
            writer.WriteNumberValue(Total);
            if (Optional.IsCollectionDefined(Statements))
            {
                writer.WritePropertyName("statements"u8);
                writer.WriteStartArray();
                foreach (var item in Statements)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SparkStatement>)item).Serialize(writer, options);
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

        internal static SparkStatementCollection DeserializeSparkStatementCollection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int totalStatements = default;
            Optional<IReadOnlyList<SparkStatement>> statements = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("total_statements"u8))
                {
                    totalStatements = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("statements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SparkStatement> array = new List<SparkStatement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SparkStatement.DeserializeSparkStatement(item));
                    }
                    statements = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SparkStatementCollection(totalStatements, Optional.ToList(statements), serializedAdditionalRawData);
        }

        SparkStatementCollection IModelJsonSerializable<SparkStatementCollection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkStatementCollection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkStatementCollection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SparkStatementCollection>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkStatementCollection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SparkStatementCollection IModelSerializable<SparkStatementCollection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkStatementCollection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSparkStatementCollection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SparkStatementCollection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SparkStatementCollection"/> to convert. </param>
        public static implicit operator RequestContent(SparkStatementCollection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SparkStatementCollection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SparkStatementCollection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSparkStatementCollection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
