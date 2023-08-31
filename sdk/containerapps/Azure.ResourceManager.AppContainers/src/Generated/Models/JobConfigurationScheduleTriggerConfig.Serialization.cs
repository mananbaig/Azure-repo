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

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class JobConfigurationScheduleTriggerConfig : IUtf8JsonSerializable, IModelJsonSerializable<JobConfigurationScheduleTriggerConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JobConfigurationScheduleTriggerConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JobConfigurationScheduleTriggerConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ReplicaCompletionCount))
            {
                writer.WritePropertyName("replicaCompletionCount"u8);
                writer.WriteNumberValue(ReplicaCompletionCount.Value);
            }
            writer.WritePropertyName("cronExpression"u8);
            writer.WriteStringValue(CronExpression);
            if (Optional.IsDefined(Parallelism))
            {
                writer.WritePropertyName("parallelism"u8);
                writer.WriteNumberValue(Parallelism.Value);
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

        internal static JobConfigurationScheduleTriggerConfig DeserializeJobConfigurationScheduleTriggerConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> replicaCompletionCount = default;
            string cronExpression = default;
            Optional<int> parallelism = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicaCompletionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCompletionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("cronExpression"u8))
                {
                    cronExpression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parallelism"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parallelism = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JobConfigurationScheduleTriggerConfig(Optional.ToNullable(replicaCompletionCount), cronExpression, Optional.ToNullable(parallelism), rawData);
        }

        JobConfigurationScheduleTriggerConfig IModelJsonSerializable<JobConfigurationScheduleTriggerConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJobConfigurationScheduleTriggerConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JobConfigurationScheduleTriggerConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JobConfigurationScheduleTriggerConfig IModelSerializable<JobConfigurationScheduleTriggerConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJobConfigurationScheduleTriggerConfig(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="JobConfigurationScheduleTriggerConfig"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="JobConfigurationScheduleTriggerConfig"/> to convert. </param>
        public static implicit operator RequestContent(JobConfigurationScheduleTriggerConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="JobConfigurationScheduleTriggerConfig"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator JobConfigurationScheduleTriggerConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJobConfigurationScheduleTriggerConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
