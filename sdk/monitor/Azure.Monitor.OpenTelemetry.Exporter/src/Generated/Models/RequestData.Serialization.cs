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
    internal partial class RequestData : IUtf8JsonSerializable, IModelJsonSerializable<RequestData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RequestData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RequestData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RequestData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("duration"u8);
            writer.WriteStringValue(Duration);
            writer.WritePropertyName("success"u8);
            writer.WriteBooleanValue(Success);
            writer.WritePropertyName("responseCode"u8);
            writer.WriteStringValue(ResponseCode);
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url);
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

        internal static RequestData DeserializeRequestData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<string> name = default;
            string duration = default;
            bool success = default;
            string responseCode = default;
            Optional<string> source = default;
            Optional<string> url = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, double>> measurements = default;
            int ver = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    duration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("success"u8))
                {
                    success = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("responseCode"u8))
                {
                    responseCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
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
            return new RequestData(ver, additionalProperties, id, name.Value, duration, success, responseCode, source.Value, url.Value, Optional.ToDictionary(properties), Optional.ToDictionary(measurements));
        }

        RequestData IModelJsonSerializable<RequestData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RequestData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RequestData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RequestData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RequestData IModelSerializable<RequestData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<RequestData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRequestData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RequestData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RequestData"/> to convert. </param>
        public static implicit operator RequestContent(RequestData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RequestData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RequestData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRequestData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
