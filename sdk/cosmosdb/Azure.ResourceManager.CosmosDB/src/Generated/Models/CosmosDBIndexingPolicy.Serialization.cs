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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBIndexingPolicy : IUtf8JsonSerializable, IModelJsonSerializable<CosmosDBIndexingPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CosmosDBIndexingPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CosmosDBIndexingPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsAutomatic))
            {
                writer.WritePropertyName("automatic"u8);
                writer.WriteBooleanValue(IsAutomatic.Value);
            }
            if (Optional.IsDefined(IndexingMode))
            {
                writer.WritePropertyName("indexingMode"u8);
                writer.WriteStringValue(IndexingMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IncludedPaths))
            {
                writer.WritePropertyName("includedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedPaths)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<CosmosDBIncludedPath>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<CosmosDBExcludedPath>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CompositeIndexes))
            {
                writer.WritePropertyName("compositeIndexes"u8);
                writer.WriteStartArray();
                foreach (var item in CompositeIndexes)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        if (item0 is null)
                        {
                            writer.WriteNullValue();
                        }
                        else
                        {
                            ((IModelJsonSerializable<CosmosDBCompositePath>)item0).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SpatialIndexes))
            {
                writer.WritePropertyName("spatialIndexes"u8);
                writer.WriteStartArray();
                foreach (var item in SpatialIndexes)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SpatialSpec>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static CosmosDBIndexingPolicy DeserializeCosmosDBIndexingPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> automatic = default;
            Optional<CosmosDBIndexingMode> indexingMode = default;
            Optional<IList<CosmosDBIncludedPath>> includedPaths = default;
            Optional<IList<CosmosDBExcludedPath>> excludedPaths = default;
            Optional<IList<IList<CosmosDBCompositePath>>> compositeIndexes = default;
            Optional<IList<SpatialSpec>> spatialIndexes = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automatic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automatic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("indexingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexingMode = new CosmosDBIndexingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("includedPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBIncludedPath> array = new List<CosmosDBIncludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBIncludedPath.DeserializeCosmosDBIncludedPath(item));
                    }
                    includedPaths = array;
                    continue;
                }
                if (property.NameEquals("excludedPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBExcludedPath> array = new List<CosmosDBExcludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBExcludedPath.DeserializeCosmosDBExcludedPath(item));
                    }
                    excludedPaths = array;
                    continue;
                }
                if (property.NameEquals("compositeIndexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<CosmosDBCompositePath>> array = new List<IList<CosmosDBCompositePath>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<CosmosDBCompositePath> array0 = new List<CosmosDBCompositePath>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(CosmosDBCompositePath.DeserializeCosmosDBCompositePath(item0));
                            }
                            array.Add(array0);
                        }
                    }
                    compositeIndexes = array;
                    continue;
                }
                if (property.NameEquals("spatialIndexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpatialSpec> array = new List<SpatialSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialSpec.DeserializeSpatialSpec(item));
                    }
                    spatialIndexes = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CosmosDBIndexingPolicy(Optional.ToNullable(automatic), Optional.ToNullable(indexingMode), Optional.ToList(includedPaths), Optional.ToList(excludedPaths), Optional.ToList(compositeIndexes), Optional.ToList(spatialIndexes), rawData);
        }

        CosmosDBIndexingPolicy IModelJsonSerializable<CosmosDBIndexingPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBIndexingPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CosmosDBIndexingPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CosmosDBIndexingPolicy IModelSerializable<CosmosDBIndexingPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCosmosDBIndexingPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CosmosDBIndexingPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CosmosDBIndexingPolicy"/> to convert. </param>
        public static implicit operator RequestContent(CosmosDBIndexingPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CosmosDBIndexingPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CosmosDBIndexingPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCosmosDBIndexingPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
