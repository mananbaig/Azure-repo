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

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentTypeDetails : IUtf8JsonSerializable, IModelJsonSerializable<DocumentTypeDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DocumentTypeDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DocumentTypeDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentTypeDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(BuildMode))
            {
                writer.WritePropertyName("buildMode"u8);
                writer.WriteStringValue(BuildMode.Value.ToString());
            }
            writer.WritePropertyName("fieldSchema"u8);
            writer.WriteStartObject();
            foreach (var item in FieldSchema)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DocumentFieldSchema>)item.Value).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            if (Optional.IsCollectionDefined(FieldConfidence))
            {
                writer.WritePropertyName("fieldConfidence"u8);
                writer.WriteStartObject();
                foreach (var item in FieldConfidence)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static DocumentTypeDetails DeserializeDocumentTypeDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<DocumentBuildMode> buildMode = default;
            IReadOnlyDictionary<string, DocumentFieldSchema> fieldSchema = default;
            Optional<IReadOnlyDictionary<string, float>> fieldConfidence = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("buildMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    buildMode = new DocumentBuildMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fieldSchema"u8))
                {
                    Dictionary<string, DocumentFieldSchema> dictionary = new Dictionary<string, DocumentFieldSchema>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DocumentFieldSchema.DeserializeDocumentFieldSchema(property0.Value));
                    }
                    fieldSchema = dictionary;
                    continue;
                }
                if (property.NameEquals("fieldConfidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, float> dictionary = new Dictionary<string, float>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetSingle());
                    }
                    fieldConfidence = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DocumentTypeDetails(description.Value, Optional.ToNullable(buildMode), fieldSchema, Optional.ToDictionary(fieldConfidence), serializedAdditionalRawData);
        }

        DocumentTypeDetails IModelJsonSerializable<DocumentTypeDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentTypeDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentTypeDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DocumentTypeDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentTypeDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DocumentTypeDetails IModelSerializable<DocumentTypeDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DocumentTypeDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDocumentTypeDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DocumentTypeDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DocumentTypeDetails"/> to convert. </param>
        public static implicit operator RequestContent(DocumentTypeDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DocumentTypeDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DocumentTypeDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDocumentTypeDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
