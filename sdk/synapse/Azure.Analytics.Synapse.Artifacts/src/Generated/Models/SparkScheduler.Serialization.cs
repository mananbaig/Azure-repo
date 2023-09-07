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
    [JsonConverter(typeof(SparkSchedulerConverter))]
    public partial class SparkScheduler : IUtf8JsonSerializable, IModelJsonSerializable<SparkScheduler>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SparkScheduler>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SparkScheduler>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkScheduler>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SubmittedAt))
            {
                if (SubmittedAt != null)
                {
                    writer.WritePropertyName("submittedAt"u8);
                    writer.WriteStringValue(SubmittedAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("submittedAt");
                }
            }
            if (Optional.IsDefined(ScheduledAt))
            {
                if (ScheduledAt != null)
                {
                    writer.WritePropertyName("scheduledAt"u8);
                    writer.WriteStringValue(ScheduledAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("scheduledAt");
                }
            }
            if (Optional.IsDefined(EndedAt))
            {
                if (EndedAt != null)
                {
                    writer.WritePropertyName("endedAt"u8);
                    writer.WriteStringValue(EndedAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("endedAt");
                }
            }
            if (Optional.IsDefined(CancellationRequestedAt))
            {
                if (CancellationRequestedAt != null)
                {
                    writer.WritePropertyName("cancellationRequestedAt"u8);
                    writer.WriteStringValue(CancellationRequestedAt.Value, "O");
                }
                else
                {
                    writer.WriteNull("cancellationRequestedAt");
                }
            }
            if (Optional.IsDefined(CurrentState))
            {
                writer.WritePropertyName("currentState"u8);
                writer.WriteStringValue(CurrentState.Value.ToString());
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

        internal static SparkScheduler DeserializeSparkScheduler(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset?> submittedAt = default;
            Optional<DateTimeOffset?> scheduledAt = default;
            Optional<DateTimeOffset?> endedAt = default;
            Optional<DateTimeOffset?> cancellationRequestedAt = default;
            Optional<SchedulerCurrentState> currentState = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("submittedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        submittedAt = null;
                        continue;
                    }
                    submittedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scheduledAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        scheduledAt = null;
                        continue;
                    }
                    scheduledAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endedAt = null;
                        continue;
                    }
                    endedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cancellationRequestedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cancellationRequestedAt = null;
                        continue;
                    }
                    cancellationRequestedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = new SchedulerCurrentState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SparkScheduler(Optional.ToNullable(submittedAt), Optional.ToNullable(scheduledAt), Optional.ToNullable(endedAt), Optional.ToNullable(cancellationRequestedAt), Optional.ToNullable(currentState), serializedAdditionalRawData);
        }

        SparkScheduler IModelJsonSerializable<SparkScheduler>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkScheduler>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSparkScheduler(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SparkScheduler>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkScheduler>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SparkScheduler IModelSerializable<SparkScheduler>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SparkScheduler>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSparkScheduler(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SparkScheduler"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SparkScheduler"/> to convert. </param>
        public static implicit operator RequestContent(SparkScheduler model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SparkScheduler"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SparkScheduler(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSparkScheduler(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SparkSchedulerConverter : JsonConverter<SparkScheduler>
        {
            public override void Write(Utf8JsonWriter writer, SparkScheduler model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkScheduler Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkScheduler(document.RootElement);
            }
        }
    }
}
