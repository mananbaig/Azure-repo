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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ReplicationResumeJobContent : IUtf8JsonSerializable, IModelJsonSerializable<ReplicationResumeJobContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReplicationResumeJobContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReplicationResumeJobContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplicationResumeJobContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ReplicationResumeJobProperties>)Properties).Serialize(writer, options);
                }
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

        internal static ReplicationResumeJobContent DeserializeReplicationResumeJobContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ReplicationResumeJobProperties> properties = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ReplicationResumeJobProperties.DeserializeReplicationResumeJobProperties(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReplicationResumeJobContent(properties.Value, serializedAdditionalRawData);
        }

        ReplicationResumeJobContent IModelJsonSerializable<ReplicationResumeJobContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplicationResumeJobContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationResumeJobContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReplicationResumeJobContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplicationResumeJobContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReplicationResumeJobContent IModelSerializable<ReplicationResumeJobContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplicationResumeJobContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReplicationResumeJobContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReplicationResumeJobContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReplicationResumeJobContent"/> to convert. </param>
        public static implicit operator RequestContent(ReplicationResumeJobContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReplicationResumeJobContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReplicationResumeJobContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReplicationResumeJobContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
