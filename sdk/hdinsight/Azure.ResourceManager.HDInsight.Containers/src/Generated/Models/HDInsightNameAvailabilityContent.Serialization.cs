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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class HDInsightNameAvailabilityContent : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightNameAvailabilityContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightNameAvailabilityContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightNameAvailabilityContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightNameAvailabilityContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
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

        internal static HDInsightNameAvailabilityContent DeserializeHDInsightNameAvailabilityContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> type = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightNameAvailabilityContent(name.Value, type.Value, serializedAdditionalRawData);
        }

        HDInsightNameAvailabilityContent IModelJsonSerializable<HDInsightNameAvailabilityContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightNameAvailabilityContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightNameAvailabilityContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightNameAvailabilityContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightNameAvailabilityContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightNameAvailabilityContent IModelSerializable<HDInsightNameAvailabilityContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<HDInsightNameAvailabilityContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightNameAvailabilityContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HDInsightNameAvailabilityContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HDInsightNameAvailabilityContent"/> to convert. </param>
        public static implicit operator RequestContent(HDInsightNameAvailabilityContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HDInsightNameAvailabilityContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HDInsightNameAvailabilityContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightNameAvailabilityContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
