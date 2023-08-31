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

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class LogFileSettingsText : IUtf8JsonSerializable, IModelJsonSerializable<LogFileSettingsText>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<LogFileSettingsText>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<LogFileSettingsText>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LogFileSettingsText>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("recordStartTimestampFormat"u8);
            writer.WriteStringValue(RecordStartTimestampFormat.ToString());
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

        internal static LogFileSettingsText DeserializeLogFileSettingsText(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LogFileTextSettingsRecordStartTimestampFormat recordStartTimestampFormat = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordStartTimestampFormat"u8))
                {
                    recordStartTimestampFormat = new LogFileTextSettingsRecordStartTimestampFormat(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new LogFileSettingsText(recordStartTimestampFormat, rawData);
        }

        LogFileSettingsText IModelJsonSerializable<LogFileSettingsText>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LogFileSettingsText>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeLogFileSettingsText(doc.RootElement, options);
        }

        BinaryData IModelSerializable<LogFileSettingsText>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LogFileSettingsText>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        LogFileSettingsText IModelSerializable<LogFileSettingsText>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<LogFileSettingsText>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeLogFileSettingsText(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="LogFileSettingsText"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="LogFileSettingsText"/> to convert. </param>
        public static implicit operator RequestContent(LogFileSettingsText model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="LogFileSettingsText"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator LogFileSettingsText(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeLogFileSettingsText(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
