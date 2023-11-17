// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    public partial class BuildDocumentModelContent : IUtf8JsonSerializable, IJsonModel<BuildDocumentModelContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BuildDocumentModelContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BuildDocumentModelContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BuildDocumentModelContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BuildDocumentModelContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("buildMode"u8);
            writer.WriteStringValue(BuildMode.ToString());
            if (Optional.IsDefined(AzureBlobSource))
            {
                writer.WritePropertyName("azureBlobSource"u8);
                writer.WriteObjectValue(AzureBlobSource);
            }
            if (Optional.IsDefined(AzureBlobFileListSource))
            {
                writer.WritePropertyName("azureBlobFileListSource"u8);
                writer.WriteObjectValue(AzureBlobFileListSource);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        BuildDocumentModelContent IJsonModel<BuildDocumentModelContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BuildDocumentModelContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBuildDocumentModelContent(document.RootElement, options);
        }

        internal static BuildDocumentModelContent DeserializeBuildDocumentModelContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            Optional<string> description = default;
            DocumentBuildMode buildMode = default;
            Optional<AzureBlobContentSource> azureBlobSource = default;
            Optional<AzureBlobFileListContentSource> azureBlobFileListSource = default;
            Optional<IDictionary<string, string>> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("buildMode"u8))
                {
                    buildMode = new DocumentBuildMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureBlobSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobSource = AzureBlobContentSource.DeserializeAzureBlobContentSource(property.Value);
                    continue;
                }
                if (property.NameEquals("azureBlobFileListSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobFileListSource = AzureBlobFileListContentSource.DeserializeAzureBlobFileListContentSource(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BuildDocumentModelContent(modelId, description.Value, buildMode, azureBlobSource.Value, azureBlobFileListSource.Value, Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BuildDocumentModelContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BuildDocumentModelContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BuildDocumentModelContent IPersistableModel<BuildDocumentModelContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BuildDocumentModelContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBuildDocumentModelContent(document.RootElement, options);
        }

        string IPersistableModel<BuildDocumentModelContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BuildDocumentModelContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBuildDocumentModelContent(document.RootElement, new ModelReaderWriterOptions("W"));
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
