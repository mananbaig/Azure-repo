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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SoftDeleteColumnDeletionDetectionPolicy : IUtf8JsonSerializable, IModelJsonSerializable<SoftDeleteColumnDeletionDetectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SoftDeleteColumnDeletionDetectionPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SoftDeleteColumnDeletionDetectionPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SoftDeleteColumnDeletionDetectionPolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SoftDeleteColumnName))
            {
                writer.WritePropertyName("softDeleteColumnName"u8);
                writer.WriteStringValue(SoftDeleteColumnName);
            }
            if (Optional.IsDefined(SoftDeleteMarkerValue))
            {
                writer.WritePropertyName("softDeleteMarkerValue"u8);
                writer.WriteStringValue(SoftDeleteMarkerValue);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
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

        internal static SoftDeleteColumnDeletionDetectionPolicy DeserializeSoftDeleteColumnDeletionDetectionPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> softDeleteColumnName = default;
            Optional<string> softDeleteMarkerValue = default;
            string odataType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("softDeleteColumnName"u8))
                {
                    softDeleteColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softDeleteMarkerValue"u8))
                {
                    softDeleteMarkerValue = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SoftDeleteColumnDeletionDetectionPolicy(odataType, softDeleteColumnName.Value, softDeleteMarkerValue.Value, serializedAdditionalRawData);
        }

        SoftDeleteColumnDeletionDetectionPolicy IModelJsonSerializable<SoftDeleteColumnDeletionDetectionPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SoftDeleteColumnDeletionDetectionPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftDeleteColumnDeletionDetectionPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SoftDeleteColumnDeletionDetectionPolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SoftDeleteColumnDeletionDetectionPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SoftDeleteColumnDeletionDetectionPolicy IModelSerializable<SoftDeleteColumnDeletionDetectionPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SoftDeleteColumnDeletionDetectionPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSoftDeleteColumnDeletionDetectionPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SoftDeleteColumnDeletionDetectionPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SoftDeleteColumnDeletionDetectionPolicy"/> to convert. </param>
        public static implicit operator RequestContent(SoftDeleteColumnDeletionDetectionPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SoftDeleteColumnDeletionDetectionPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SoftDeleteColumnDeletionDetectionPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSoftDeleteColumnDeletionDetectionPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
