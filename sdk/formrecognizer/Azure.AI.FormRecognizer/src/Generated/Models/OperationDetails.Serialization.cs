// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class OperationDetails : IUtf8JsonSerializable, IJsonModel<OperationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<OperationDetails>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<OperationDetails>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("operationId"u8);
            writer.WriteStringValue(OperationId);
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToSerialString());
            if (Optional.IsDefined(PercentCompleted))
            {
                writer.WritePropertyName("percentCompleted"u8);
                writer.WriteNumberValue(PercentCompleted.Value);
            }
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedOn, "O");
            writer.WritePropertyName("lastUpdatedDateTime"u8);
            writer.WriteStringValue(LastUpdatedOn, "O");
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("resourceLocation"u8);
            writer.WriteStringValue(ResourceLocation.AbsoluteUri);
            if (Optional.IsDefined(ServiceVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ServiceVersion);
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
            if (Optional.IsDefined(JsonError))
            {
                writer.WritePropertyName("error"u8);
                JsonError.WriteTo(writer);
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

        OperationDetails IJsonModel<OperationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationDetails(document.RootElement, options);
        }

        internal static OperationDetails DeserializeOperationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "documentClassifierBuild": return DocumentClassifierBuildOperationDetails.DeserializeDocumentClassifierBuildOperationDetails(element);
                    case "documentModelBuild": return DocumentModelBuildOperationDetails.DeserializeDocumentModelBuildOperationDetails(element);
                    case "documentModelCompose": return DocumentModelComposeOperationDetails.DeserializeDocumentModelComposeOperationDetails(element);
                    case "documentModelCopyTo": return DocumentModelCopyToOperationDetails.DeserializeDocumentModelCopyToOperationDetails(element);
                }
            }
            return UnknownOperationDetails.DeserializeUnknownOperationDetails(element);
        }

        BinaryData IPersistableModel<OperationDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        OperationDetails IPersistableModel<OperationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(OperationDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeOperationDetails(document.RootElement, options);
        }

        string IPersistableModel<OperationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
