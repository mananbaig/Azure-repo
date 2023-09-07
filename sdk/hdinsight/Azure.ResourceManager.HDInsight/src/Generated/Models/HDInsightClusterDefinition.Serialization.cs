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

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterDefinition : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightClusterDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightClusterDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightClusterDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterDefinition>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Blueprint))
            {
                writer.WritePropertyName("blueprint"u8);
                writer.WriteStringValue(Blueprint);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsCollectionDefined(ComponentVersion))
            {
                writer.WritePropertyName("componentVersion"u8);
                writer.WriteStartObject();
                foreach (var item in ComponentVersion)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Configurations))
            {
                writer.WritePropertyName("configurations"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Configurations);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Configurations.ToString()).RootElement);
#endif
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

        internal static HDInsightClusterDefinition DeserializeHDInsightClusterDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> blueprint = default;
            Optional<string> kind = default;
            Optional<IDictionary<string, string>> componentVersion = default;
            Optional<BinaryData> configurations = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blueprint"u8))
                {
                    blueprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    componentVersion = dictionary;
                    continue;
                }
                if (property.NameEquals("configurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurations = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightClusterDefinition(blueprint.Value, kind.Value, Optional.ToDictionary(componentVersion), configurations.Value, serializedAdditionalRawData);
        }

        HDInsightClusterDefinition IModelJsonSerializable<HDInsightClusterDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterDefinition>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightClusterDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightClusterDefinition>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterDefinition>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightClusterDefinition IModelSerializable<HDInsightClusterDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightClusterDefinition>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightClusterDefinition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightClusterDefinition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightClusterDefinition"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightClusterDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightClusterDefinition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightClusterDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightClusterDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
