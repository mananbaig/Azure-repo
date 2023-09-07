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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class TriggeredJobRun : IUtf8JsonSerializable, IModelJsonSerializable<TriggeredJobRun>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TriggeredJobRun>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TriggeredJobRun>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggeredJobRun>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(WebJobId))
            {
                writer.WritePropertyName("web_job_id"u8);
                writer.WriteStringValue(WebJobId);
            }
            if (Optional.IsDefined(WebJobName))
            {
                writer.WritePropertyName("web_job_name"u8);
                writer.WriteStringValue(WebJobName);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("start_time"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("end_time"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "c");
            }
            if (Optional.IsDefined(OutputUri))
            {
                writer.WritePropertyName("output_url"u8);
                writer.WriteStringValue(OutputUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ErrorUri))
            {
                writer.WritePropertyName("error_url"u8);
                writer.WriteStringValue(ErrorUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(JobName))
            {
                writer.WritePropertyName("job_name"u8);
                writer.WriteStringValue(JobName);
            }
            if (Optional.IsDefined(Trigger))
            {
                writer.WritePropertyName("trigger"u8);
                writer.WriteStringValue(Trigger);
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

        internal static TriggeredJobRun DeserializeTriggeredJobRun(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> webJobId = default;
            Optional<string> webJobName = default;
            Optional<TriggeredWebJobStatus> status = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<TimeSpan> duration = default;
            Optional<Uri> outputUrl = default;
            Optional<Uri> errorUrl = default;
            Optional<Uri> url = default;
            Optional<string> jobName = default;
            Optional<string> trigger = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("web_job_id"u8))
                {
                    webJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("web_job_name"u8))
                {
                    webJobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToTriggeredWebJobStatus();
                    continue;
                }
                if (property.NameEquals("start_time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("end_time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("output_url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error_url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("job_name"u8))
                {
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trigger"u8))
                {
                    trigger = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TriggeredJobRun(webJobId.Value, webJobName.Value, Optional.ToNullable(status), Optional.ToNullable(startTime), Optional.ToNullable(endTime), Optional.ToNullable(duration), outputUrl.Value, errorUrl.Value, url.Value, jobName.Value, trigger.Value, serializedAdditionalRawData);
        }

        TriggeredJobRun IModelJsonSerializable<TriggeredJobRun>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggeredJobRun>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggeredJobRun(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TriggeredJobRun>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggeredJobRun>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TriggeredJobRun IModelSerializable<TriggeredJobRun>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TriggeredJobRun>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTriggeredJobRun(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TriggeredJobRun"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TriggeredJobRun"/> to convert. </param>
        public static implicit operator RequestContent(TriggeredJobRun model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TriggeredJobRun"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TriggeredJobRun(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTriggeredJobRun(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
