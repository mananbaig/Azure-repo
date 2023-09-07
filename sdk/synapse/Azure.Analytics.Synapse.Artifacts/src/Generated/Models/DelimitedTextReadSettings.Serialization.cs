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
    [JsonConverter(typeof(DelimitedTextReadSettingsConverter))]
    public partial class DelimitedTextReadSettings : IUtf8JsonSerializable, IModelJsonSerializable<DelimitedTextReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DelimitedTextReadSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DelimitedTextReadSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DelimitedTextReadSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SkipLineCount))
            {
                writer.WritePropertyName("skipLineCount"u8);
                writer.WriteObjectValue(SkipLineCount);
            }
            if (Optional.IsDefined(CompressionProperties))
            {
                writer.WritePropertyName("compressionProperties"u8);
                if (CompressionProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CompressionReadSettings>)CompressionProperties).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DelimitedTextReadSettings DeserializeDelimitedTextReadSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> skipLineCount = default;
            Optional<CompressionReadSettings> compressionProperties = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipLineCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipLineCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("compressionProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressionProperties = CompressionReadSettings.DeserializeCompressionReadSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DelimitedTextReadSettings(type, additionalProperties, skipLineCount.Value, compressionProperties.Value);
        }

        DelimitedTextReadSettings IModelJsonSerializable<DelimitedTextReadSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DelimitedTextReadSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDelimitedTextReadSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DelimitedTextReadSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DelimitedTextReadSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DelimitedTextReadSettings IModelSerializable<DelimitedTextReadSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DelimitedTextReadSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDelimitedTextReadSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DelimitedTextReadSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DelimitedTextReadSettings"/> to convert. </param>
        public static implicit operator RequestContent(DelimitedTextReadSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DelimitedTextReadSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DelimitedTextReadSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDelimitedTextReadSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class DelimitedTextReadSettingsConverter : JsonConverter<DelimitedTextReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, DelimitedTextReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DelimitedTextReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDelimitedTextReadSettings(document.RootElement);
            }
        }
    }
}
