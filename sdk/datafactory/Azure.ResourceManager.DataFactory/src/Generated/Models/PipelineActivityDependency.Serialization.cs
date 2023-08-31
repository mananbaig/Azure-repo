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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PipelineActivityDependency : IUtf8JsonSerializable, IModelJsonSerializable<PipelineActivityDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PipelineActivityDependency>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PipelineActivityDependency>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("activity"u8);
            writer.WriteStringValue(Activity);
            writer.WritePropertyName("dependencyConditions"u8);
            writer.WriteStartArray();
            foreach (var item in DependencyConditions)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
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

        internal static PipelineActivityDependency DeserializePipelineActivityDependency(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activity = default;
            IList<DependencyCondition> dependencyConditions = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activity"u8))
                {
                    activity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependencyConditions"u8))
                {
                    List<DependencyCondition> array = new List<DependencyCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DependencyCondition(item.GetString()));
                    }
                    dependencyConditions = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PipelineActivityDependency(activity, dependencyConditions, additionalProperties);
        }

        PipelineActivityDependency IModelJsonSerializable<PipelineActivityDependency>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineActivityDependency(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PipelineActivityDependency>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PipelineActivityDependency IModelSerializable<PipelineActivityDependency>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePipelineActivityDependency(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PipelineActivityDependency"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PipelineActivityDependency"/> to convert. </param>
        public static implicit operator RequestContent(PipelineActivityDependency model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PipelineActivityDependency"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PipelineActivityDependency(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePipelineActivityDependency(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
