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

namespace Azure.AI.FormRecognizer.Training
{
    public partial class CustomFormModelField : IUtf8JsonSerializable, IJsonModel<CustomFormModelField>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomFormModelField>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomFormModelField>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomFormModelField>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CustomFormModelField)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fieldName"u8);
            writer.WriteStringValue(Name);
            if (Accuracy != null)
            {
                writer.WritePropertyName("accuracy"u8);
                writer.WriteNumberValue(Accuracy.Value);
            }
            else
            {
                writer.WriteNull("accuracy");
            }
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

        CustomFormModelField IJsonModel<CustomFormModelField>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomFormModelField>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(CustomFormModelField)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomFormModelField(document.RootElement, options);
        }

        internal static CustomFormModelField DeserializeCustomFormModelField(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fieldName = default;
            float? accuracy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accuracy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accuracy = null;
                        continue;
                    }
                    accuracy = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomFormModelField(fieldName, accuracy, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomFormModelField>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomFormModelField>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(CustomFormModelField)} does not support '{options.Format}' format.");
            }
        }

        CustomFormModelField IPersistableModel<CustomFormModelField>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomFormModelField>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomFormModelField(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(CustomFormModelField)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomFormModelField>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
