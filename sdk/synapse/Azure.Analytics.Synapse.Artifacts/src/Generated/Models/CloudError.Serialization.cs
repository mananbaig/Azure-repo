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
    [JsonConverter(typeof(CloudErrorConverter))]
    public partial class CloudError : IUtf8JsonSerializable, IModelJsonSerializable<CloudError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudError>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("error"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("code"u8);
            writer.WriteStringValue(Code);
            writer.WritePropertyName("message"u8);
            writer.WriteStringValue(Message);
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<CloudError>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static CloudError DeserializeCloudError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<CloudError>> details = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("code"u8))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"u8))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CloudError> array = new List<CloudError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeCloudError(item));
                            }
                            details = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudError(code, message, target.Value, Optional.ToList(details), serializedAdditionalRawData);
        }

        CloudError IModelJsonSerializable<CloudError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudError IModelSerializable<CloudError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CloudError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CloudError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CloudError"/> to convert. </param>
        public static implicit operator RequestContent(CloudError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CloudError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CloudError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class CloudErrorConverter : JsonConverter<CloudError>
        {
            public override void Write(Utf8JsonWriter writer, CloudError model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override CloudError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCloudError(document.RootElement);
            }
        }
    }
}
