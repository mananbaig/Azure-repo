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
    [JsonConverter(typeof(GetSsisObjectMetadataRequestConverter))]
    public partial class GetSsisObjectMetadataRequest : IUtf8JsonSerializable, IModelJsonSerializable<GetSsisObjectMetadataRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GetSsisObjectMetadataRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GetSsisObjectMetadataRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetSsisObjectMetadataRequest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MetadataPath))
            {
                writer.WritePropertyName("metadataPath"u8);
                writer.WriteStringValue(MetadataPath);
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

        internal static GetSsisObjectMetadataRequest DeserializeGetSsisObjectMetadataRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metadataPath = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metadataPath"u8))
                {
                    metadataPath = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GetSsisObjectMetadataRequest(metadataPath.Value, serializedAdditionalRawData);
        }

        GetSsisObjectMetadataRequest IModelJsonSerializable<GetSsisObjectMetadataRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetSsisObjectMetadataRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGetSsisObjectMetadataRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GetSsisObjectMetadataRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetSsisObjectMetadataRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GetSsisObjectMetadataRequest IModelSerializable<GetSsisObjectMetadataRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<GetSsisObjectMetadataRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGetSsisObjectMetadataRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="GetSsisObjectMetadataRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="GetSsisObjectMetadataRequest"/> to convert. </param>
        public static implicit operator RequestContent(GetSsisObjectMetadataRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="GetSsisObjectMetadataRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator GetSsisObjectMetadataRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGetSsisObjectMetadataRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class GetSsisObjectMetadataRequestConverter : JsonConverter<GetSsisObjectMetadataRequest>
        {
            public override void Write(Utf8JsonWriter writer, GetSsisObjectMetadataRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override GetSsisObjectMetadataRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGetSsisObjectMetadataRequest(document.RootElement);
            }
        }
    }
}
