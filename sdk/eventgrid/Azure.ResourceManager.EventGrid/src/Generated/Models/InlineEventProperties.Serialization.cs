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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class InlineEventProperties : IUtf8JsonSerializable, IModelJsonSerializable<InlineEventProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InlineEventProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<InlineEventProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InlineEventProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(DocumentationUri))
            {
                writer.WritePropertyName("documentationUrl"u8);
                writer.WriteStringValue(DocumentationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DataSchemaUri))
            {
                writer.WritePropertyName("dataSchemaUrl"u8);
                writer.WriteStringValue(DataSchemaUri.AbsoluteUri);
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

        internal static InlineEventProperties DeserializeInlineEventProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<Uri> documentationUri = default;
            Optional<Uri> dataSchemaUri = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("documentationUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    documentationUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataSchemaUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataSchemaUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new InlineEventProperties(description.Value, displayName.Value, documentationUri.Value, dataSchemaUri.Value, serializedAdditionalRawData);
        }

        InlineEventProperties IModelJsonSerializable<InlineEventProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InlineEventProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeInlineEventProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InlineEventProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InlineEventProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        InlineEventProperties IModelSerializable<InlineEventProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<InlineEventProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeInlineEventProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="InlineEventProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="InlineEventProperties"/> to convert. </param>
        public static implicit operator RequestContent(InlineEventProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="InlineEventProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator InlineEventProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeInlineEventProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
