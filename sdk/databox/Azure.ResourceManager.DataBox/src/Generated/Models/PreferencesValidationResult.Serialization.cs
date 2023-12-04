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

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class PreferencesValidationResult : IUtf8JsonSerializable, IJsonModel<PreferencesValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PreferencesValidationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PreferencesValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreferencesValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PreferencesValidationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            writer.WritePropertyName("validationType"u8);
            writer.WriteStringValue(ValidationType.ToSerialString());
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
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

        PreferencesValidationResult IJsonModel<PreferencesValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreferencesValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(PreferencesValidationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePreferencesValidationResult(document.RootElement, options);
        }

        internal static PreferencesValidationResult DeserializePreferencesValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataBoxValidationStatus> status = default;
            DataBoxValidationInputDiscriminator validationType = default;
            Optional<ResponseError> error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToDataBoxValidationStatus();
                    continue;
                }
                if (property.NameEquals("validationType"u8))
                {
                    validationType = property.Value.GetString().ToDataBoxValidationInputDiscriminator();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PreferencesValidationResult(validationType, error.Value, serializedAdditionalRawData, Optional.ToNullable(status));
        }

        BinaryData IPersistableModel<PreferencesValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreferencesValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(PreferencesValidationResult)} does not support '{options.Format}' format.");
            }
        }

        PreferencesValidationResult IPersistableModel<PreferencesValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PreferencesValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePreferencesValidationResult(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(PreferencesValidationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PreferencesValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
