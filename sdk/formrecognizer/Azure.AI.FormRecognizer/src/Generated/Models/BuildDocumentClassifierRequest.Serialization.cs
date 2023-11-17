// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    internal partial class BuildDocumentClassifierRequest : IUtf8JsonSerializable, IJsonModel<BuildDocumentClassifierRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BuildDocumentClassifierRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BuildDocumentClassifierRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BuildDocumentClassifierRequest>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BuildDocumentClassifierRequest>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("classifierId"u8);
            writer.WriteStringValue(ClassifierId);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("docTypes"u8);
            writer.WriteStartObject();
            foreach (var item in DocTypes)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
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

        BuildDocumentClassifierRequest IJsonModel<BuildDocumentClassifierRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BuildDocumentClassifierRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBuildDocumentClassifierRequest(document.RootElement, options);
        }

        internal static BuildDocumentClassifierRequest DeserializeBuildDocumentClassifierRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string classifierId = default;
            Optional<string> description = default;
            IDictionary<string, ClassifierDocumentTypeDetails> docTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("classifierId"u8))
                {
                    classifierId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("docTypes"u8))
                {
                    Dictionary<string, ClassifierDocumentTypeDetails> dictionary = new Dictionary<string, ClassifierDocumentTypeDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ClassifierDocumentTypeDetails.DeserializeClassifierDocumentTypeDetails(property0.Value));
                    }
                    docTypes = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BuildDocumentClassifierRequest(classifierId, description.Value, docTypes, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BuildDocumentClassifierRequest>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BuildDocumentClassifierRequest)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BuildDocumentClassifierRequest IPersistableModel<BuildDocumentClassifierRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BuildDocumentClassifierRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBuildDocumentClassifierRequest(document.RootElement, options);
        }

        string IPersistableModel<BuildDocumentClassifierRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
