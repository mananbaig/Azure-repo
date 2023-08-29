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

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class TelemetryExceptionData : IUtf8JsonSerializable, IModelJsonSerializable<TelemetryExceptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TelemetryExceptionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TelemetryExceptionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TelemetryExceptionData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("exceptions"u8);
            writer.WriteStartArray();
            foreach (var item in Exceptions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SeverityLevel))
            {
                if (SeverityLevel != null)
                {
                    writer.WritePropertyName("severityLevel"u8);
                    writer.WriteStringValue(SeverityLevel.Value.ToString());
                }
                else
                {
                    writer.WriteNull("severityLevel");
                }
            }
            if (Optional.IsDefined(ProblemId))
            {
                writer.WritePropertyName("problemId"u8);
                writer.WriteStringValue(ProblemId);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Measurements))
            {
                writer.WritePropertyName("measurements"u8);
                writer.WriteStartObject();
                foreach (var item in Measurements)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("ver"u8);
            writer.WriteNumberValue(Version);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static TelemetryExceptionData DeserializeTelemetryExceptionData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<TelemetryExceptionDetails> exceptions = default;
            Optional<SeverityLevel?> severityLevel = default;
            Optional<string> problemId = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, double>> measurements = default;
            int ver = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exceptions"u8))
                {
                    List<TelemetryExceptionDetails> array = new List<TelemetryExceptionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TelemetryExceptionDetails.DeserializeTelemetryExceptionDetails(item));
                    }
                    exceptions = array;
                    continue;
                }
                if (property.NameEquals("severityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        severityLevel = null;
                        continue;
                    }
                    severityLevel = new SeverityLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("problemId"u8))
                {
                    problemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
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
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("measurements"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, double> dictionary = new Dictionary<string, double>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetDouble());
                    }
                    measurements = dictionary;
                    continue;
                }
                if (property.NameEquals("ver"u8))
                {
                    ver = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TelemetryExceptionData(ver, additionalProperties, exceptions, Optional.ToNullable(severityLevel), problemId.Value, Optional.ToDictionary(properties), Optional.ToDictionary(measurements));
        }

        TelemetryExceptionData IModelJsonSerializable<TelemetryExceptionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TelemetryExceptionData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTelemetryExceptionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TelemetryExceptionData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TelemetryExceptionData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TelemetryExceptionData IModelSerializable<TelemetryExceptionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<TelemetryExceptionData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTelemetryExceptionData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(TelemetryExceptionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator TelemetryExceptionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTelemetryExceptionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
