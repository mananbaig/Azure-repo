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

namespace Azure.ResourceManager.Automation.Models
{
    public partial class GraphicalRunbookContent : IUtf8JsonSerializable, IModelJsonSerializable<GraphicalRunbookContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GraphicalRunbookContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GraphicalRunbookContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RawContent))
            {
                if (RawContent != null)
                {
                    writer.WritePropertyName("rawContent"u8);
                    writer.WriteObjectValue(RawContent);
                }
                else
                {
                    writer.WriteNull("rawContent");
                }
            }
            if (Optional.IsDefined(GraphRunbookJson))
            {
                if (GraphRunbookJson != null)
                {
                    writer.WritePropertyName("graphRunbookJson"u8);
                    writer.WriteStringValue(GraphRunbookJson);
                }
                else
                {
                    writer.WriteNull("graphRunbookJson");
                }
            }
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

        internal static GraphicalRunbookContent DeserializeGraphicalRunbookContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RawGraphicalRunbookContent> rawContent = default;
            Optional<string> graphRunbookJson = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rawContent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rawContent = null;
                        continue;
                    }
                    rawContent = RawGraphicalRunbookContent.DeserializeRawGraphicalRunbookContent(property.Value);
                    continue;
                }
                if (property.NameEquals("graphRunbookJson"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        graphRunbookJson = null;
                        continue;
                    }
                    graphRunbookJson = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GraphicalRunbookContent(rawContent.Value, graphRunbookJson.Value, rawData);
        }

        GraphicalRunbookContent IModelJsonSerializable<GraphicalRunbookContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGraphicalRunbookContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GraphicalRunbookContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GraphicalRunbookContent IModelSerializable<GraphicalRunbookContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGraphicalRunbookContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GraphicalRunbookContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GraphicalRunbookContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGraphicalRunbookContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
