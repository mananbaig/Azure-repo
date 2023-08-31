// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AmazonRdsForOracleSource : IUtf8JsonSerializable, IModelJsonSerializable<AmazonRdsForOracleSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AmazonRdsForOracleSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AmazonRdsForOracleSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AmazonRdsForOracleSource>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(OracleReaderQuery))
            {
                writer.WritePropertyName("oracleReaderQuery"u8);
                JsonSerializer.Serialize(writer, OracleReaderQuery);
            }
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout"u8);
                JsonSerializer.Serialize(writer, QueryTimeout);
            }
            if (Optional.IsDefined(PartitionOption))
            {
                writer.WritePropertyName("partitionOption"u8);
                JsonSerializer.Serialize(writer, PartitionOption);
            }
            if (Optional.IsDefined(PartitionSettings))
            {
                writer.WritePropertyName("partitionSettings"u8);
                if (PartitionSettings is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AmazonRdsForOraclePartitionSettings>)PartitionSettings).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(AdditionalColumns);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(AdditionalColumns.ToString()).RootElement);
#endif
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySourceType);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                JsonSerializer.Serialize(writer, SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                JsonSerializer.Serialize(writer, SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (Optional.IsDefined(DisableMetricsCollection))
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static AmazonRdsForOracleSource DeserializeAmazonRdsForOracleSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> oracleReaderQuery = default;
            Optional<DataFactoryElement<string>> queryTimeout = default;
            Optional<DataFactoryElement<string>> partitionOption = default;
            Optional<AmazonRdsForOraclePartitionSettings> partitionSettings = default;
            Optional<BinaryData> additionalColumns = default;
            string type = default;
            Optional<DataFactoryElement<int>> sourceRetryCount = default;
            Optional<DataFactoryElement<string>> sourceRetryWait = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("oracleReaderQuery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oracleReaderQuery = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionOption = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("partitionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionSettings = AmazonRdsForOraclePartitionSettings.DeserializeAmazonRdsForOraclePartitionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AmazonRdsForOracleSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, disableMetricsCollection.Value, additionalProperties, oracleReaderQuery.Value, queryTimeout.Value, partitionOption.Value, partitionSettings.Value, additionalColumns.Value);
        }

        AmazonRdsForOracleSource IModelJsonSerializable<AmazonRdsForOracleSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AmazonRdsForOracleSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAmazonRdsForOracleSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AmazonRdsForOracleSource>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AmazonRdsForOracleSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AmazonRdsForOracleSource IModelSerializable<AmazonRdsForOracleSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AmazonRdsForOracleSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAmazonRdsForOracleSource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AmazonRdsForOracleSource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AmazonRdsForOracleSource"/> to convert. </param>
        public static implicit operator RequestContent(AmazonRdsForOracleSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AmazonRdsForOracleSource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AmazonRdsForOracleSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAmazonRdsForOracleSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
