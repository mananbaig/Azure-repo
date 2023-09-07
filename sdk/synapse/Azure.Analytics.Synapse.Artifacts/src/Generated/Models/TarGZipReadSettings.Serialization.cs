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
    [JsonConverter(typeof(TarGZipReadSettingsConverter))]
    public partial class TarGZipReadSettings : IUtf8JsonSerializable, IModelJsonSerializable<TarGZipReadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TarGZipReadSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TarGZipReadSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TarGZipReadSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PreserveCompressionFileNameAsFolder))
            {
                writer.WritePropertyName("preserveCompressionFileNameAsFolder"u8);
                writer.WriteObjectValue(PreserveCompressionFileNameAsFolder);
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

        internal static TarGZipReadSettings DeserializeTarGZipReadSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> preserveCompressionFileNameAsFolder = default;
            string type = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preserveCompressionFileNameAsFolder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveCompressionFileNameAsFolder = property.Value.GetObject();
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
            return new TarGZipReadSettings(type, additionalProperties, preserveCompressionFileNameAsFolder.Value);
        }

        TarGZipReadSettings IModelJsonSerializable<TarGZipReadSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TarGZipReadSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTarGZipReadSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TarGZipReadSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TarGZipReadSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TarGZipReadSettings IModelSerializable<TarGZipReadSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TarGZipReadSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTarGZipReadSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TarGZipReadSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TarGZipReadSettings"/> to convert. </param>
        public static implicit operator RequestContent(TarGZipReadSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TarGZipReadSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TarGZipReadSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTarGZipReadSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class TarGZipReadSettingsConverter : JsonConverter<TarGZipReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, TarGZipReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override TarGZipReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeTarGZipReadSettings(document.RootElement);
            }
        }
    }
}
