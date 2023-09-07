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
    [JsonConverter(typeof(RedshiftUnloadSettingsConverter))]
    public partial class RedshiftUnloadSettings : IUtf8JsonSerializable, IModelJsonSerializable<RedshiftUnloadSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RedshiftUnloadSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RedshiftUnloadSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedshiftUnloadSettings>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("s3LinkedServiceName"u8);
            if (S3LinkedServiceName is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<LinkedServiceReference>)S3LinkedServiceName).Serialize(writer, options);
            }
            writer.WritePropertyName("bucketName"u8);
            writer.WriteObjectValue(BucketName);
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

        internal static RedshiftUnloadSettings DeserializeRedshiftUnloadSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LinkedServiceReference s3LinkedServiceName = default;
            object bucketName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("s3LinkedServiceName"u8))
                {
                    s3LinkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("bucketName"u8))
                {
                    bucketName = property.Value.GetObject();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RedshiftUnloadSettings(s3LinkedServiceName, bucketName, serializedAdditionalRawData);
        }

        RedshiftUnloadSettings IModelJsonSerializable<RedshiftUnloadSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedshiftUnloadSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRedshiftUnloadSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RedshiftUnloadSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedshiftUnloadSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RedshiftUnloadSettings IModelSerializable<RedshiftUnloadSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedshiftUnloadSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRedshiftUnloadSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RedshiftUnloadSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RedshiftUnloadSettings"/> to convert. </param>
        public static implicit operator RequestContent(RedshiftUnloadSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RedshiftUnloadSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RedshiftUnloadSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRedshiftUnloadSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class RedshiftUnloadSettingsConverter : JsonConverter<RedshiftUnloadSettings>
        {
            public override void Write(Utf8JsonWriter writer, RedshiftUnloadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RedshiftUnloadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRedshiftUnloadSettings(document.RootElement);
            }
        }
    }
}
