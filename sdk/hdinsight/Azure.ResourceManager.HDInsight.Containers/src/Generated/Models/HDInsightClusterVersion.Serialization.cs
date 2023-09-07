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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class HDInsightClusterVersion : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightClusterVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightClusterVersion>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightClusterVersion>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterVersion>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterType))
            {
                writer.WritePropertyName("clusterType"u8);
                writer.WriteStringValue(ClusterType);
            }
            if (Optional.IsDefined(ClusterVersion))
            {
                writer.WritePropertyName("clusterVersion"u8);
                writer.WriteStringValue(ClusterVersion);
            }
            if (Optional.IsDefined(OssVersion))
            {
                writer.WritePropertyName("ossVersion"u8);
                writer.WriteStringValue(OssVersion);
            }
            if (Optional.IsDefined(ClusterPoolVersion))
            {
                writer.WritePropertyName("clusterPoolVersion"u8);
                writer.WriteStringValue(ClusterPoolVersion);
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            writer.WriteEndObject();
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

        internal static HDInsightClusterVersion DeserializeHDInsightClusterVersion(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> clusterType = default;
            Optional<string> clusterVersion = default;
            Optional<string> ossVersion = default;
            Optional<string> clusterPoolVersion = default;
            Optional<bool> isPreview = default;
            Optional<IReadOnlyList<ClusterComponentItem>> components = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("clusterType"u8))
                        {
                            clusterType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterVersion"u8))
                        {
                            clusterVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ossVersion"u8))
                        {
                            ossVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterPoolVersion"u8))
                        {
                            clusterPoolVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isPreview"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPreview = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("components"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ClusterComponentItem> array = new List<ClusterComponentItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ClusterComponentItem.DeserializeClusterComponentItem(item));
                            }
                            components = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightClusterVersion(id, name, type, systemData.Value, clusterType.Value, clusterVersion.Value, ossVersion.Value, clusterPoolVersion.Value, Optional.ToNullable(isPreview), Optional.ToList(components), serializedAdditionalRawData);
        }

        HDInsightClusterVersion IModelJsonSerializable<HDInsightClusterVersion>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterVersion>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterVersion(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightClusterVersion>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterVersion>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightClusterVersion IModelSerializable<HDInsightClusterVersion>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterVersion>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightClusterVersion(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightClusterVersion"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightClusterVersion"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightClusterVersion model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightClusterVersion"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightClusterVersion(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightClusterVersion(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
