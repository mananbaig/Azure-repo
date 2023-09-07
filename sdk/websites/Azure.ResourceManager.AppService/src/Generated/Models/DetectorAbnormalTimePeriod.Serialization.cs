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
    public partial class DetectorAbnormalTimePeriod : IUtf8JsonSerializable, IModelJsonSerializable<DetectorAbnormalTimePeriod>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DetectorAbnormalTimePeriod>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DetectorAbnormalTimePeriod>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectorAbnormalTimePeriod>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsCollectionDefined(MetaData))
            {
                writer.WritePropertyName("metaData"u8);
                writer.WriteStartArray();
                foreach (var item in MetaData)
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
                            ((IModelJsonSerializable<AppServiceNameValuePair>)item0).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IssueType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IssueType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Solutions))
            {
                writer.WritePropertyName("solutions"u8);
                writer.WriteStartArray();
                foreach (var item in Solutions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DiagnosticSolution>)item).Serialize(writer, options);
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

        internal static DetectorAbnormalTimePeriod DeserializeDetectorAbnormalTimePeriod(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> message = default;
            Optional<string> source = default;
            Optional<double> priority = default;
            Optional<IList<IList<AppServiceNameValuePair>>> metaData = default;
            Optional<DetectorIssueType> type = default;
            Optional<IList<DiagnosticSolution>> solutions = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    priority = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("metaData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IList<AppServiceNameValuePair>> array = new List<IList<AppServiceNameValuePair>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            List<AppServiceNameValuePair> array0 = new List<AppServiceNameValuePair>();
                            foreach (var item0 in item.EnumerateArray())
                            {
                                array0.Add(AppServiceNameValuePair.DeserializeAppServiceNameValuePair(item0));
                            }
                            array.Add(array0);
                        }
                    }
                    metaData = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToDetectorIssueType();
                    continue;
                }
                if (property.NameEquals("solutions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiagnosticSolution> array = new List<DiagnosticSolution>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiagnosticSolution.DeserializeDiagnosticSolution(item));
                    }
                    solutions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DetectorAbnormalTimePeriod(Optional.ToNullable(startTime), Optional.ToNullable(endTime), message.Value, source.Value, Optional.ToNullable(priority), Optional.ToList(metaData), Optional.ToNullable(type), Optional.ToList(solutions), serializedAdditionalRawData);
        }

        DetectorAbnormalTimePeriod IModelJsonSerializable<DetectorAbnormalTimePeriod>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectorAbnormalTimePeriod>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectorAbnormalTimePeriod(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DetectorAbnormalTimePeriod>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectorAbnormalTimePeriod>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DetectorAbnormalTimePeriod IModelSerializable<DetectorAbnormalTimePeriod>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DetectorAbnormalTimePeriod>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDetectorAbnormalTimePeriod(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DetectorAbnormalTimePeriod"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DetectorAbnormalTimePeriod"/> to convert. </param>
        public static implicit operator RequestContent(DetectorAbnormalTimePeriod model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DetectorAbnormalTimePeriod"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DetectorAbnormalTimePeriod(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDetectorAbnormalTimePeriod(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
