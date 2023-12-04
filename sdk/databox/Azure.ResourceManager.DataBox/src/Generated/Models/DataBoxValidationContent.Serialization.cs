// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [PersistableModelProxy(typeof(UnknownValidationRequest))]
    public partial class DataBoxValidationContent : IUtf8JsonSerializable, IJsonModel<DataBoxValidationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxValidationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxValidationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataBoxValidationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("validationCategory"u8);
            writer.WriteStringValue(ValidationCategory.ToString());
            writer.WritePropertyName("individualRequestDetails"u8);
            writer.WriteStartArray();
            foreach (var item in IndividualRequestDetails)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        DataBoxValidationContent IJsonModel<DataBoxValidationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataBoxValidationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxValidationContent(document.RootElement, options);
        }

        internal static DataBoxValidationContent DeserializeDataBoxValidationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("validationCategory", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "JobCreationValidation": return CreateJobValidationContent.DeserializeCreateJobValidationContent(element);
                }
            }
            return UnknownValidationRequest.DeserializeUnknownValidationRequest(element);
        }

        BinaryData IPersistableModel<DataBoxValidationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DataBoxValidationContent)} does not support '{options.Format}' format.");
            }
        }

        DataBoxValidationContent IPersistableModel<DataBoxValidationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxValidationContent(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DataBoxValidationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxValidationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
