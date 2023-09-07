// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    internal partial class UnknownDataDeletionDetectionPolicy : IUtf8JsonSerializable, IModelJsonSerializable<DataDeletionDetectionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataDeletionDetectionPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataDeletionDetectionPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataDeletionDetectionPolicy>(this, options.Format);

            writer.WriteStartObject();
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

        internal static DataDeletionDetectionPolicy DeserializeUnknownDataDeletionDetectionPolicy(JsonElement element, ModelSerializerOptions options = default) => DeserializeDataDeletionDetectionPolicy(element, options);

        DataDeletionDetectionPolicy IModelJsonSerializable<DataDeletionDetectionPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataDeletionDetectionPolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownDataDeletionDetectionPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataDeletionDetectionPolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataDeletionDetectionPolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataDeletionDetectionPolicy IModelSerializable<DataDeletionDetectionPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DataDeletionDetectionPolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataDeletionDetectionPolicy(doc.RootElement, options);
        }
    }
}
