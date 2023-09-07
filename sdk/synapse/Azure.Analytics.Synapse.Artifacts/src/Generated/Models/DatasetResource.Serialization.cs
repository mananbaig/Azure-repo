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
    [JsonConverter(typeof(DatasetResourceConverter))]
    public partial class DatasetResource : IUtf8JsonSerializable, IModelJsonSerializable<DatasetResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DatasetResource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DatasetResource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatasetResource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            if (Properties is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<Dataset>)Properties).Serialize(writer, options);
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

        internal static DatasetResource DeserializeDatasetResource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Dataset properties = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = Dataset.DeserializeDataset(property.Value);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
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
            return new DatasetResource(id.Value, name.Value, type.Value, etag.Value, properties, serializedAdditionalRawData);
        }

        DatasetResource IModelJsonSerializable<DatasetResource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatasetResource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDatasetResource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DatasetResource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatasetResource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DatasetResource IModelSerializable<DatasetResource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatasetResource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDatasetResource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DatasetResource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DatasetResource"/> to convert. </param>
        public static implicit operator RequestContent(DatasetResource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DatasetResource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DatasetResource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDatasetResource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class DatasetResourceConverter : JsonConverter<DatasetResource>
        {
            public override void Write(Utf8JsonWriter writer, DatasetResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DatasetResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDatasetResource(document.RootElement);
            }
        }
    }
}
