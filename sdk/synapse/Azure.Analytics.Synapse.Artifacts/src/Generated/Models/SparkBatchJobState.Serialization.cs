// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkBatchJobStateConverter))]
    public partial class SparkBatchJobState : IUtf8JsonSerializable, IModelJsonSerializable<SparkBatchJobState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SparkBatchJobState>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SparkBatchJobState>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkBatchJobState>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NotStartedAt))
            {
                if (NotStartedAt != null)
                {
                    writer.WritePropertyName("notStartedAt"u8);
                    writer.WriteStringValue(NotStartedAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("notStartedAt");
                }
            }
            if (Optional.IsDefined(StartingAt))
            {
                if (StartingAt != null)
                {
                    writer.WritePropertyName("startingAt"u8);
                    writer.WriteStringValue(StartingAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("startingAt");
                }
            }
            if (Optional.IsDefined(RunningAt))
            {
                if (RunningAt != null)
                {
                    writer.WritePropertyName("runningAt"u8);
                    writer.WriteStringValue(RunningAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("runningAt");
                }
            }
            if (Optional.IsDefined(DeadAt))
            {
                if (DeadAt != null)
                {
                    writer.WritePropertyName("deadAt"u8);
                    writer.WriteStringValue(DeadAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("deadAt");
                }
            }
            if (Optional.IsDefined(SuccessAt))
            {
                if (SuccessAt != null)
                {
                    writer.WritePropertyName("successAt"u8);
                    writer.WriteStringValue(SuccessAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("successAt");
                }
            }
            if (Optional.IsDefined(TerminatedAt))
            {
                if (TerminatedAt != null)
                {
                    writer.WritePropertyName("killedAt"u8);
                    writer.WriteStringValue(TerminatedAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("killedAt");
                }
            }
            if (Optional.IsDefined(RecoveringAt))
            {
                if (RecoveringAt != null)
                {
                    writer.WritePropertyName("recoveringAt"u8);
                    writer.WriteStringValue(RecoveringAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("recoveringAt");
                }
            }
            if (Optional.IsDefined(CurrentState))
            {
                writer.WritePropertyName("currentState"u8);
                writer.WriteStringValue(CurrentState);
            }
            if (Optional.IsDefined(JobCreationRequest))
            {
                writer.WritePropertyName("jobCreationRequest"u8);
                if (JobCreationRequest is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SparkRequest>)JobCreationRequest).Serialize(writer, options);
                }
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

        internal static SparkBatchJobState DeserializeSparkBatchJobState(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset?> notStartedAt = default;
            Optional<DateTimeOffset?> startingAt = default;
            Optional<DateTimeOffset?> runningAt = default;
            Optional<DateTimeOffset?> deadAt = default;
            Optional<DateTimeOffset?> successAt = default;
            Optional<DateTimeOffset?> killedAt = default;
            Optional<DateTimeOffset?> recoveringAt = default;
            Optional<string> currentState = default;
            Optional<SparkRequest> jobCreationRequest = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notStartedAt = null;
                        continue;
                    }
                    notStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startingAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startingAt = null;
                        continue;
                    }
                    startingAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runningAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        runningAt = null;
                        continue;
                    }
                    runningAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deadAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadAt = null;
                        continue;
                    }
                    deadAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("successAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        successAt = null;
                        continue;
                    }
                    successAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("killedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        killedAt = null;
                        continue;
                    }
                    killedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveringAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        recoveringAt = null;
                        continue;
                    }
                    recoveringAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    currentState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCreationRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobCreationRequest = SparkRequest.DeserializeSparkRequest(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SparkBatchJobState(Optional.ToNullable(notStartedAt), Optional.ToNullable(startingAt), Optional.ToNullable(runningAt), Optional.ToNullable(deadAt), Optional.ToNullable(successAt), Optional.ToNullable(killedAt), Optional.ToNullable(recoveringAt), currentState.Value, jobCreationRequest.Value, serializedAdditionalRawData);
        }

        SparkBatchJobState IModelJsonSerializable<SparkBatchJobState>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkBatchJobState>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkBatchJobState(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SparkBatchJobState>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkBatchJobState>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SparkBatchJobState IModelSerializable<SparkBatchJobState>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkBatchJobState>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSparkBatchJobState(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SparkBatchJobState"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SparkBatchJobState"/> to convert. </param>
        public static implicit operator RequestContent(SparkBatchJobState model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SparkBatchJobState"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SparkBatchJobState(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSparkBatchJobState(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SparkBatchJobStateConverter : JsonConverter<SparkBatchJobState>
        {
            public override void Write(Utf8JsonWriter writer, SparkBatchJobState model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkBatchJobState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkBatchJobState(document.RootElement);
            }
        }
    }
}
