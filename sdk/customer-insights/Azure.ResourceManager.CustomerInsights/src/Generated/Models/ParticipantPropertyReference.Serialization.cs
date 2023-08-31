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

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ParticipantPropertyReference : IUtf8JsonSerializable, IModelJsonSerializable<ParticipantPropertyReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ParticipantPropertyReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ParticipantPropertyReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourcePropertyName"u8);
            writer.WriteStringValue(SourcePropertyName);
            writer.WritePropertyName("targetPropertyName"u8);
            writer.WriteStringValue(TargetPropertyName);
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

        internal static ParticipantPropertyReference DeserializeParticipantPropertyReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourcePropertyName = default;
            string targetPropertyName = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourcePropertyName"u8))
                {
                    sourcePropertyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetPropertyName"u8))
                {
                    targetPropertyName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ParticipantPropertyReference(sourcePropertyName, targetPropertyName, rawData);
        }

        ParticipantPropertyReference IModelJsonSerializable<ParticipantPropertyReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeParticipantPropertyReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ParticipantPropertyReference>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ParticipantPropertyReference IModelSerializable<ParticipantPropertyReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeParticipantPropertyReference(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ParticipantPropertyReference"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ParticipantPropertyReference"/> to convert. </param>
        public static implicit operator RequestContent(ParticipantPropertyReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ParticipantPropertyReference"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ParticipantPropertyReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeParticipantPropertyReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
