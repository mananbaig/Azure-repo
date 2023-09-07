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

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class ElasticCloudUser : IUtf8JsonSerializable, IModelJsonSerializable<ElasticCloudUser>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ElasticCloudUser>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ElasticCloudUser>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticCloudUser>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ElasticCloudUser DeserializeElasticCloudUser(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> emailAddress = default;
            Optional<string> id = default;
            Optional<Uri> elasticCloudSsoDefaultUrl = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("emailAddress"u8))
                {
                    emailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticCloudSsoDefaultUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elasticCloudSsoDefaultUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ElasticCloudUser(emailAddress.Value, id.Value, elasticCloudSsoDefaultUrl.Value, serializedAdditionalRawData);
        }

        ElasticCloudUser IModelJsonSerializable<ElasticCloudUser>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticCloudUser>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticCloudUser(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ElasticCloudUser>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticCloudUser>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ElasticCloudUser IModelSerializable<ElasticCloudUser>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ElasticCloudUser>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeElasticCloudUser(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ElasticCloudUser"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ElasticCloudUser"/> to convert. </param>
        public static implicit operator RequestContent(ElasticCloudUser model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ElasticCloudUser"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ElasticCloudUser(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeElasticCloudUser(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
