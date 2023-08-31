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

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class LoggingHiddenPropertyPaths : IUtf8JsonSerializable, IModelJsonSerializable<LoggingHiddenPropertyPaths>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LoggingHiddenPropertyPaths>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LoggingHiddenPropertyPaths>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(HiddenPathsOnRequest))
            {
                writer.WritePropertyName("hiddenPathsOnRequest"u8);
                writer.WriteStartArray();
                foreach (var item in HiddenPathsOnRequest)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(HiddenPathsOnResponse))
            {
                writer.WritePropertyName("hiddenPathsOnResponse"u8);
                writer.WriteStartArray();
                foreach (var item in HiddenPathsOnResponse)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static LoggingHiddenPropertyPaths DeserializeLoggingHiddenPropertyPaths(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> hiddenPathsOnRequest = default;
            Optional<IList<string>> hiddenPathsOnResponse = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hiddenPathsOnRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hiddenPathsOnRequest = array;
                    continue;
                }
                if (property.NameEquals("hiddenPathsOnResponse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hiddenPathsOnResponse = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LoggingHiddenPropertyPaths(Optional.ToList(hiddenPathsOnRequest), Optional.ToList(hiddenPathsOnResponse), rawData);
        }

        LoggingHiddenPropertyPaths IModelJsonSerializable<LoggingHiddenPropertyPaths>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLoggingHiddenPropertyPaths(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LoggingHiddenPropertyPaths>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LoggingHiddenPropertyPaths IModelSerializable<LoggingHiddenPropertyPaths>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLoggingHiddenPropertyPaths(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LoggingHiddenPropertyPaths"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LoggingHiddenPropertyPaths"/> to convert. </param>
        public static implicit operator RequestContent(LoggingHiddenPropertyPaths model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LoggingHiddenPropertyPaths"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LoggingHiddenPropertyPaths(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLoggingHiddenPropertyPaths(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
